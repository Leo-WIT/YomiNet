using System.Globalization;
using System.Windows.Controls;
using YomiNet.Localization.Resources;
using YomiNet.Utilities;

namespace YomiNet.Validators;

public class IPv4SubnetValidator : ValidationRule
{
    public override ValidationResult Validate(object value, CultureInfo cultureInfo)
    {
        var subnet = (value as string)?.Trim();

        if (string.IsNullOrEmpty(subnet))
            return new ValidationResult(false, Strings.EnterValidSubnet);

        if (RegexHelper.IPv4AddressCidrRegex().IsMatch(subnet))
            return ValidationResult.ValidResult;

        if (RegexHelper.IPv4AddressSubnetmaskRegex().IsMatch(subnet))
            return ValidationResult.ValidResult;

        return new ValidationResult(false, Strings.EnterValidSubnet);
    }
}