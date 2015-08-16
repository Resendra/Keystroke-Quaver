using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace KeystrokeQuaver
{
    public partial class KQSettings : Form
    {
        public KQSettings()
        {
            InitializeComponent();
        }

        private void KQSettings_Load(object sender, EventArgs e)
        {
            recordHotkeyComboBox.DataSource = Enum.GetValues(typeof(Keys))
                                                    .Cast<Keys>()
                                                    .Select(p => new { Key = (int)p, Value = p.ToString() })
                                                    .ToList();

            recordHotkeyComboBox.DisplayMember = "Value";
            recordHotkeyComboBox.ValueMember = "Key";
        }

        private void recordHotkeyListenerButton_Click(object sender, EventArgs e)
        {
            recordHotkey.Focus();

        }
    
        private void recordHotkey_KeyUp(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            Console.WriteLine(e);
            recordHotkey.AppendText(KeyInterop.KeyFromVirtualKey(e.KeyValue).ToString());
        }
    }
}
