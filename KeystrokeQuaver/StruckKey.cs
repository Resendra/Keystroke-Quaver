using System;
using System.Windows.Input;
using FileHelpers;

namespace KeystrokeQuaver
{
    [DelimitedRecord(";")]
    class StruckKey
    {
        [FieldOrder(3)]
        [FieldConverter(typeof(CustomTimeSpanConverter))]
        public TimeSpan KeyStrokeDownTime;

        [FieldOrder(4)]
        [FieldConverter(typeof(CustomTimeSpanConverter))]
        public TimeSpan KeyStrokeUpTime;

        [FieldOrder(2)]
        [FieldConverter(typeof(CustomTimeSpanConverter))]
        public TimeSpan KeyStrokeDuration;

        [FieldHidden]
        public int VirtualKey;

        [FieldOrder(1)]
        public string Key { get; set; }

        public StruckKey()
        {

        }

        public StruckKey(int virtualKey)
        {
            VirtualKey = virtualKey;
            Key = KeyInterop.KeyFromVirtualKey(virtualKey).ToString();
            KeyStrokeDownTime = TimeSpan.Zero;
        }

        public StruckKey(int virtualKey, TimeSpan keyStrokeDownTime)
        {
            VirtualKey = virtualKey;
            Key = KeyInterop.KeyFromVirtualKey(virtualKey).ToString();
            KeyStrokeDownTime = keyStrokeDownTime;
        }
        
        public TimeSpan computeKeyStrokeDuration()
        {
            KeyStrokeDuration = KeyStrokeUpTime - KeyStrokeDownTime;
            return KeyStrokeDuration;
        }

        public string toString()
        {
            return Key + " - " + KeyStrokeDuration.ToString(@"ss\.fff") + " - " + KeyStrokeDownTime.ToString(@"ss\.fff") + " - " + KeyStrokeUpTime.ToString(@"ss\.fff");
        }
    }
}
