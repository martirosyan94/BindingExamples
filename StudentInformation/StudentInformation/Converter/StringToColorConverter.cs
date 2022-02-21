using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace StudentInformation.Converter
{
    internal class StringToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (value)
            {
                case "Red" : 
                    return nameof(Color.Red);
                    break;
                case "Blue":
                    return nameof(Color.Blue);
                    break;
                case "Orange":
                    return nameof(Color.Orange);
                    break;
                default:
                    return nameof(Color.Purple);
                    break;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
