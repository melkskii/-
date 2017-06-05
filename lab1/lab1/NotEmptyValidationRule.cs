using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace lab1
{
    class NotEmptyValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
           
            var s = value as string;
            int res;
            if (String.IsNullOrWhiteSpace(s))
            {
                return new ValidationResult(false,"Заполните строку");
            }
            else if(Int32.TryParse(s, out res))
            {
                return new ValidationResult(false, "Здесь должен быть текст");
            }
            return new ValidationResult(true, String.Empty);
        }
    }
}
