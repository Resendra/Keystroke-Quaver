using FileHelpers;
using System;
using System.Globalization;

namespace KeystrokeQuaver
{
    public class CustomTimeSpanConverter : ConverterBase
    {
        private const string TimeSpanFormat = @"ss\.fff";

        public override object StringToField(string from)
        {
            return TimeSpan.ParseExact(from, TimeSpanFormat, CultureInfo.InvariantCulture);
        }
    }
}
