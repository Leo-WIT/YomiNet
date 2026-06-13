using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Controls;
using YomiNet.Localization.Resources;
using YomiNet.Models.Network;
using YomiNet.Utilities;

namespace YomiNet.Validators;

public class SNMPOIDValidator : ValidationRule
{
    public SNMPOIDDependencyObjectWrapper Wrapper { get; set; }

    public override ValidationResult Validate(object value, CultureInfo cultureInfo)
    {
        var oidValue = (value as string)!.Replace(" ", "");

        if (Wrapper.Mode != SNMPMode.Get || !oidValue.Contains(';'))
            return Regex.IsMatch(oidValue, RegexHelper.SnmpOidRegex)
                ? ValidationResult.ValidResult
                : new ValidationResult(false, Strings.EnterValidOID);

        return oidValue.Split(';').Any(oid => !Regex.IsMatch(oid, RegexHelper.SnmpOidRegex))
            ? new ValidationResult(false, Strings.EnterValidOID)
            : ValidationResult.ValidResult;
    }
}