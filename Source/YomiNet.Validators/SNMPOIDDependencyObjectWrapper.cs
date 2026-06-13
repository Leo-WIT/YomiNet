using System.Windows;
using YomiNet.Models.Network;

namespace YomiNet.Validators;

public class SNMPOIDDependencyObjectWrapper : DependencyObject
{
    public static readonly DependencyProperty ModeProperty = DependencyProperty.Register("Mode",
        typeof(SNMPMode),
        typeof(SNMPOIDDependencyObjectWrapper));

    public SNMPMode Mode
    {
        get => (SNMPMode)GetValue(ModeProperty);
        set => SetValue(ModeProperty, value);
    }
}