using System.ComponentModel.DataAnnotations;
namespace Services
{
    [AttributeUsage(AttributeTargets.Property)]
    public class PhoneValidation : ValidationAttribute
    {
        public sealed override bool IsValid(object? value)
        {
            if (value is string phoneNumber)
            {
                return !string.IsNullOrEmpty(phoneNumber) && phoneNumber.StartsWith("09");
            }

            return false;
        }
    }
}