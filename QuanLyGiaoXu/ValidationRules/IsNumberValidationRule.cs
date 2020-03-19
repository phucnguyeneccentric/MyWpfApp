using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace QuanLyGiaoXu.ValidationRules
{
    public class IsNumberValidationRule : ValidationRule
    {
        private const string InvalidInput = "Năm sinh không hợp lệ!";

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {

            if (!string.IsNullOrEmpty(value.ToString()))
            {
                return !Regex.IsMatch(value.ToString(), @"^\d+$")
                ? new ValidationResult(false, InvalidInput)
                : ValidationResult.ValidResult;
            }
            else
                return ValidationResult.ValidResult;
        }
    }
}
