using YomiNet.Localization.Resources;
using YomiNet.Utilities;
using System.DirectoryServices.ActiveDirectory;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace YomiNet.Validators;

public class RemoteDesktopHostnameAndPortValidator : ValidationRule
{
    public override ValidationResult Validate(object value, CultureInfo cultureInfo)
    {
        var hostnameAndPort = (string)value;

        if (hostnameAndPort.Contains(':'))
        {
            var hostnameAndPortValues = hostnameAndPort.Split(':');

            if (RegexHelper.HostnameOrDomainRegex().IsMatch(hostnameAndPortValues[0]) &&
                !string.IsNullOrEmpty(hostnameAndPortValues[1]) &&
                Regex.IsMatch(hostnameAndPortValues[1], RegexHelper.PortRegex))
                return ValidationResult.ValidResult;

            return new ValidationResult(false, Strings.EnterValidHostnameAndPort);
        }

        return RegexHelper.HostnameOrDomainRegex().IsMatch((string)value)
            ? ValidationResult.ValidResult
            : new ValidationResult(false, Strings.EnterValidHostname);
    }
}