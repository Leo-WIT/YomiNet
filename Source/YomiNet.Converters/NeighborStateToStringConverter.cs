using System;
using System.Globalization;
using System.Windows.Data;
using YomiNet.Localization;
using YomiNet.Models.Network;

namespace YomiNet.Converters;

/// <summary>
///     Convert <see cref="NeighborState" /> to a translated <see cref="string" />.
/// </summary>
public sealed class NeighborStateToStringConverter : IValueConverter
{
    /// <summary>
    ///     Convert <see cref="NeighborState" /> to a translated <see cref="string" />.
    /// </summary>
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return value is not NeighborState state
            ? "-/-"
            : ResourceTranslator.Translate(ResourceIdentifier.NeighborState, state);
    }

    /// <summary>
    ///     !!! Method not implemented !!!
    /// </summary>
    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
