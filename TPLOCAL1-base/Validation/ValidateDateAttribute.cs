using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace TPLOCAL1.Validation;

public class ValidateDateAttribute : ValidationAttribute
{
    public override bool IsValid(object? value)
    {
        if (value is string date)
        {
            Regex r = new Regex("\\d\\d/\\d\\d/\\d\\d\\d\\d", RegexOptions.IgnoreCase);
            if (r.IsMatch(date) && DateOnly.TryParse(date, out DateOnly result))
            {
                return result <= new DateOnly(2021, 01, 01) && result >= DateOnly.MinValue;
            }
        }
        return false;
    }
}
