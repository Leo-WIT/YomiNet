using System.Globalization;
using System.Windows.Controls;
using YomiNet.Localization.Resources;
using YomiNet.Utilities;

namespace YomiNet.Validators;

public class SubnetmaskValidator : ValidationRule
{
    public override ValidationResult Validate(object value, CultureInfo cultureInfo)
    {
        return value != null && RegexHelper.SubnetmaskRegex().IsMatch((string)value)
            ? ValidationResult.ValidResult
            : new ValidationResult(false, Strings.EnterValidSubnetmask);
    }
}