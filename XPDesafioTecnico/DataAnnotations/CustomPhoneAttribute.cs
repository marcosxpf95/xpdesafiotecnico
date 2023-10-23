using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace XPDesafioTecnico.DataAnnotations
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    sealed public class CustomPhoneAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return false;
            }

            string phone = value.ToString();

            // Regular expression pattern for Brazilian phone numbers in the format (XX) 9XXXX-XXXX or (XX) XXXX-XXXX.
            string pattern = @"^\(\d{2}\) (9\d{4}-\d{4}|\d{4}-\d{4})$";

            return Regex.IsMatch(phone, pattern);
        }
    }
}
