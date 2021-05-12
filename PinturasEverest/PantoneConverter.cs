using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace PinturasEverest
{
    class PantoneConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null && value is string && (string)value != "")
                return Color.FromHex(value.ToString());
            else
                return Color.Red;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null && value is string && (string)value != "")
                return Color.FromHex(value.ToString());
            else
                return Color.Red;
        }
    }
}
