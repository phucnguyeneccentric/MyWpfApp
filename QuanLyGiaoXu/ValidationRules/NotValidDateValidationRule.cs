using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace QuanLyGiaoXu.ValidationRules
{
    public class NotValidDateValidationRule : ValidationRule
    {
        private const string InvalidInput = "Ngày tháng phải theo định dạng (dd/MM/yyyy)!";

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            CultureInfo MyCultureInfo = new CultureInfo("vi-VN");
            DateTime date;
            var isValidDate = DateTime.TryParseExact(value.ToString(), "dd/MM/yyyy", MyCultureInfo, DateTimeStyles.None, out date);
            if (!isValidDate)
            {
                return new ValidationResult(false, InvalidInput);
            }
            return new ValidationResult(true, null);
        }
    }
}
