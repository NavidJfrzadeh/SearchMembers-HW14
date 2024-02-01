using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
namespace Services
{
    [AttributeUsage(AttributeTargets.Property)]
    public class PhoneValidation : ValidationAttribute
    {
        public sealed override bool IsValid(object? value)
        {
            if (value is string phoneNumber)
            {
                string pattern = @"^09[0-9]{9}$";
                return !string.IsNullOrEmpty(phoneNumber) && phoneNumber.StartsWith("09") && Regex.IsMatch(phoneNumber, pattern);
            }

            return false;
        }
    }
}