using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using FileHelpers;

namespace KeystrokeQuaver
{
    public partial class KQRecorder : Form
    {
        //Declare the hook handle as an int.
        static int hHook = 0;

        private const int WH_KEYBOARD_LL = 13;

        private const int keyUp = 128;
        private const int keyDown = 0;

        private Stopwatch recordTimer = new Stopwatch();
        private Timer recordTickCounter = new Timer();

        private string defaultLogFileName = "keystroke_log";

        private List<StruckKey> struckKeys = new List<StruckKey>();
        private List<StruckKey> keystrokeLog = new List<StruckKey>();

        //Declare KeyboardHookProcedure as a HookProc type.
        HookProc KeyboardHookProcedure;

        //This is the Import for the SetWindowsHookEx function.
        //Use this function to install a thread-specific hook.
        [DllImport("user32.dll", CharSet = CharSet.Auto,
         CallingConvention = CallingConvention.StdCall)]
        public static extern int SetWindowsHookEx(int idHook, HookProc lpfn,
        IntPtr hInstance, int threadId);

        //This is the Import for the UnhookWindowsHookEx function.
        //Call this function to uninstall the hook.
        [DllImport("user32.dll", CharSet = CharSet.Auto,
         CallingConvention = CallingConvention.StdCall)]
        public static extern bool UnhookWindowsHookEx(int idHook);

        //This is the Import for the CallNextHookEx function.
        //Use this function to pass the hook information to the next hook procedure in chain.
        [DllImport("user32.dll", CharSet = CharSet.Auto,
         CallingConvention = CallingConvention.StdCall)]
        public static extern int CallNextHookEx(int idHook, int nCode,
        IntPtr wParam, IntPtr lParam);

        public KQRecorder()
        {
            InitializeComponent();
        }

        public delegate int HookProc(int nCode, IntPtr wParam, IntPtr lParam);

        [StructLayout(LayoutKind.Sequential)]
        private class KeyboardHookStruct
        {
            public int vkCode;
            public int scanCode;
            public int flags;
            public int time;
            public int dwExtraInfo;
        }

        public int KeyboardHookProc(int nCode, IntPtr wParam, IntPtr lParam)
        {
            KeyboardHookStruct MyKeyboardHookStruct = (KeyboardHookStruct)Marshal.PtrToStructure(lParam, typeof(KeyboardHookStruct));

            if (nCode < 0)
            {
                return CallNextHookEx(hHook, nCode, wParam, lParam);
            }
            else
            {
                switch(MyKeyboardHookStruct.flags)
                {
                    case keyDown:
                        {
                            StruckKey newKeyStroke = new StruckKey(MyKeyboardHookStruct.vkCode, recordTimer.Elapsed);
                            bool isAlreadyStruck = struckKeys.Exists(x => x.VirtualKey == MyKeyboardHookStruct.vkCode);
                            if (!isAlreadyStruck)
                            {
                                struckKeys.Add(newKeyStroke);
                                keystrokeName.Text = newKeyStroke.Key;
                            }
                            break;
                        }
                    case keyUp:
                        {
                            StruckKey keyStrokeToRemove = struckKeys.Find(x => x.VirtualKey == MyKeyboardHookStruct.vkCode);
                            keyStrokeToRemove.KeyStrokeUpTime = recordTimer.Elapsed;
                            keystrokeName.Text = keyStrokeToRemove.Key;
                            pressedWhileTextBox.Text = keyStrokeToRemove.computeKeyStrokeDuration().ToString(@"ss\.fff");
                            keystrokeLogTextBox.AppendText(keyStrokeToRemove.toString() + Environment.NewLine);
                            struckKeys.Remove(keyStrokeToRemove);
                            keystrokeLog.Add(keyStrokeToRemove);
                            break;
                        }
                }
                
                return CallNextHookEx(hHook, nCode, wParam, lParam);
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            bool ret = UnhookWindowsHookEx(hHook);
            //If the UnhookWindowsHookEx function fails.
            if (ret == false)
            {
                MessageBox.Show("UnhookWindowsHookEx Failed");
                return;
            }
            hHook = 0;

            recordTimer.Stop();
            recordTickCounter.Stop();
            recordButton.Enabled = true;
            stopButton.Enabled = false;
            eraseElapsedTimeButton.Enabled = true;
        }

        private void recordButton_Click(object sender, EventArgs e)
        {

            if (hHook == 0)
            {
                // Create an instance of HookProc.
                KeyboardHookProcedure = new HookProc(KeyboardHookProc);

                hHook = SetWindowsHookEx(WH_KEYBOARD_LL,
                            KeyboardHookProcedure,
                            (IntPtr)0,
                            0);
                //If the SetWindowsHookEx function fails.
                if (hHook == 0)
                {
                    MessageBox.Show("SetWindowsHookEx Failed");
                    return;
                }
            }

            recordTimer.Start();
            recordTickCounter.Interval = 100;
            recordTickCounter.Tick += timerHandler;
            recordTickCounter.Start();

            stopButton.Enabled = true;
            recordButton.Enabled = false;
            eraseElapsedTimeButton.Enabled = false;

        }

        private void timerHandler(object sender, EventArgs e)
        {
            recordElapsedTimeTextBox.Text = recordTimer.Elapsed.ToString(@"mm\:ss\.fff");
        }

        private void clearLogButton_Click(object sender, EventArgs e)
        {
            keystrokeLogTextBox.Text = "";
        }

        private void hotkeysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KQSettings settings = new KQSettings();
            settings.ShowDialog();
        }

        private void eraseElapsedTimeButton_Click(object sender, EventArgs e)
        {
            recordTimer = new Stopwatch();
            recordElapsedTimeTextBox.Text = "";
        }

        private void saveLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.FileName = defaultLogFileName + ".txt";
                dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                dialog.FilterIndex = 2;
                dialog.RestoreDirectory = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllLines(dialog.FileName, keystrokeLogTextBox.Lines);
                }
            }
        }

        private void exportToCSVFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var engine = new FileHelperEngine<StruckKey>();

            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.FileName = defaultLogFileName + ".csv";
                dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                dialog.FilterIndex = 2;
                dialog.RestoreDirectory = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    engine.WriteFile(dialog.FileName, keystrokeLog);
                }
            }
        }
    }
}
