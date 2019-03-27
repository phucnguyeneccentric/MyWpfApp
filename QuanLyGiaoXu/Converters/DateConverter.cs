using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace QuanLyGiaoXu.Converters
{
    [ValueConversion(typeof(object), typeof(string))]
    public class DateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return null;
            }
            else
            {
                var item = (DateTime)value;
                return item.ToString("dd/MM/yyyy");
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            CultureInfo MyCultureInfo = new CultureInfo("vi-VN");
            DateTime date;
            var isValidDate = DateTime.TryParseExact(value.ToString(), "dd/MM/yyyy", MyCultureInfo, DateTimeStyles.None, out date);
            if (isValidDate)
            {
                //return string.Format("{0:d/MM/yyyy}",date);
                return date;
            }
            return null;
        }
    }
}
