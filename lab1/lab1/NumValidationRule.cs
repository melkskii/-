using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace lab1
{
    class NumValidationRule : ValidationRule
    {
        public Int64 minNum { get; set; }
        public Int64 maxNum { get; set; }
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            
        Int64 a = 0;
            try
            {
                a = Convert.ToInt64(value);
            }
            catch(Exception e)
            {
                return new ValidationResult(false, "Введите код");
            }
            
            if ((a<=minNum)||(a>maxNum))
            {
                return new ValidationResult(false, "CVV содержит 3 разряда");
            }
            return new ValidationResult(true, String.Empty);

        }
    }
}
