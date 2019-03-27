using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace QuanLyGiaoXu.Converters
{
    public class GioiConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch(value)
            {
                case 0:
                    return "Thiếu Nhi";
                case 1:
                    return "Giới Trẻ";
                case 2:
                    return "Gia Trưởng";
                case 3:
                    return "Hiền Mẫu";
                case 4:
                    return "Cao Niên";
                default:
                    return value;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (value)
            {
                case "Thiếu Nhi":
                    return 0;
                case "Giới Trẻ":
                    return 1;
                case "Gia Trưởng":
                    return 2;
                case "Hiền Mẫu":
                    return 3;
                case "Cao Niên":
                    return 4;
                default:
                    return value;
            }
        }
    }
}
