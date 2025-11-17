using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace ServerManagement.Validation
{
    public class MinimumCountAttribute : ValidationAttribute
    {
        private readonly int _minCount;

        public MinimumCountAttribute(int minCount)
        {
            _minCount = minCount;
            ErrorMessage = ErrorMessage ?? $"At least {minCount} item(s) must be selected";
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is ICollection collection)
            {
                if (collection.Count < _minCount)
                {
                    return new ValidationResult(ErrorMessage);
                }
            }

            return ValidationResult.Success;
        }
    }
}