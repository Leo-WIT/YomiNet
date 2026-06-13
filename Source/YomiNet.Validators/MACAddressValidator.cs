using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Controls;
using YomiNet.Localization.Resources;
using YomiNet.Utilities;

namespace YomiNet.Validators;

public class MACAddressValidator : ValidationRule
{
    public override ValidationResult Validate(object value, CultureInfo cultureInfo)
    {
        return value != null && Regex.IsMatch((string)value, RegexHelper.MACAddressRegex)
            ? ValidationResult.ValidResult
            : new ValidationResult(false, Strings.EnterValidMACAddress);
    }
}