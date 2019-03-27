using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace QuanLyGiaoXu.ValidationRules
{
    public class MaxLengthValidationRule : ValidationRule
    {
        private const int MaxLength = 20;
        private string InvalidInput = "Độ dài ký tự không được vượt quá " + MaxLength.ToString() + " !";

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            return (value.ToString().Length > MaxLength)
                ? new ValidationResult(false, InvalidInput)
                : ValidationResult.ValidResult;
        }
    }
}
