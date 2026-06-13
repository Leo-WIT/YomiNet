using YomiNet.Localization.Resources;
using YomiNet.Utilities;
using System.Globalization;
using System.Windows.Controls;

namespace YomiNet.Validators;

public class IPv4AddressValidator : ValidationRule
{
    public override ValidationResult Validate(object value, CultureInfo cultureInfo)
    {
        var ipAddress = (value as string)?.Trim();

        if (string.IsNullOrEmpty(ipAddress))
            return new ValidationResult(false, Strings.EnterValidIPv4Address);

        return RegexHelper.IPv4AddressRegex().IsMatch(ipAddress)
            ? ValidationResult.ValidResult
            : new ValidationResult(false, Strings.EnterValidIPv4Address);
    }
}