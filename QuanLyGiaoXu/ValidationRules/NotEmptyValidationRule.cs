using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace QuanLyGiaoXu.ValidationRules
{
    public class NotEmptyValidationRule : ValidationRule
    {
        private const string InvalidInput = "Đây là trường bắt buộc!";

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            return string.IsNullOrWhiteSpace((value ?? "").ToString())
                ? new ValidationResult(false, InvalidInput)
                : ValidationResult.ValidResult;
        }
    }
}
