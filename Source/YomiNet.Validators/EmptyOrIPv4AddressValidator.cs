using ControlzEx.Standard;
using YomiNet.Localization.Resources;
using YomiNet.Utilities;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace YomiNet.Validators;

public class EmptyOrIPv4AddressValidator : ValidationRule
{
    public override ValidationResult Validate(object value, CultureInfo cultureInfo)
    {
        if (string.IsNullOrEmpty(value as string))
            return ValidationResult.ValidResult;

        return RegexHelper.IPv4AddressRegex().IsMatch((string)value)
            ? ValidationResult.ValidResult
            : new ValidationResult(false, Strings.EnterValidIPv4Address);
    }
}