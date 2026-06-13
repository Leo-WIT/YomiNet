using System;
using System.Globalization;
using System.Windows.Data;
using YomiNet.Utilities;

namespace YomiNet.Converters;

public sealed class DateTimeToStringConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return value is DateTime dateTime ? DateTimeHelper.DateTimeToFullDateTimeString(dateTime) : "-/-";
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}