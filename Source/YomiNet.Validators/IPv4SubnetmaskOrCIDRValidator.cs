using System.Globalization;
using System.Windows.Controls;
using YomiNet.Localization.Resources;
using YomiNet.Utilities;

namespace YomiNet.Validators;

public class IPv4SubnetmaskOrCIDRValidator : ValidationRule
{
    public override ValidationResult Validate(object value, CultureInfo cultureInfo)
    {
        var subnetmaskOrCidr = (value as string)?.Trim();

        if (string.IsNullOrEmpty(subnetmaskOrCidr))
            return new ValidationResult(false, Strings.EnterValidSubnetmaskOrCIDR);


        if (RegexHelper.SubnetmaskRegex().IsMatch(subnetmaskOrCidr))
            return ValidationResult.ValidResult;

        if (int.TryParse(subnetmaskOrCidr.TrimStart('/'), out var cidr))
            if (cidr >= 0 && cidr < 33)
                return ValidationResult.ValidResult;

        return new ValidationResult(false, Strings.EnterValidSubnetmaskOrCIDR);
    }
}