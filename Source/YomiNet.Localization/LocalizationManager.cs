using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace YomiNet.Localization;

/// <summary>
///     Class provides variables/methods to manage localization.
/// </summary>
public class LocalizationManager
{
    /// <summary>
    ///     Constant for the default culture code.
    /// </summary>
    private const string DefaultCultureCode = "zh-CN";

    /// <summary>
    ///     Constant with the path to the flag images.
    /// </summary>
    private const string BaseFlagImageUri =
        @"pack://application:,,,/YomiNet.Localization;component/Resources/Flags/";

    /// <summary>
    ///     Variable for the instance of the class.
    /// </summary>
    private static LocalizationManager _instance;

    /// <summary>
    ///     Create an instance and load the language based on the culture code.
    /// </summary>
    /// <param name="cultureCode">Culture code (default is "en-US"). See also <see cref="LocalizationInfo.Code" />.</param>
    private LocalizationManager(string cultureCode = DefaultCultureCode)
    {
        if (string.IsNullOrEmpty(cultureCode))
            cultureCode = CultureInfo.CurrentCulture.Name;

        var info = GetLocalizationInfoBasedOnCode(cultureCode) ?? List.First();

        if (info.Code != List.First().Code)
        {
            Change(info);
        }
        else
        {
            Current = info;
            Culture = new CultureInfo(info.Code);
        }
    }

    /// <summary>
    ///     List with all <see cref="LocalizationInfo" />s.
    /// </summary>
    public static List<LocalizationInfo> List =>
    [
        new LocalizationInfo("中文简体", "中国大陆", GetImageUri("zh-CN"), "zh-CN", true),
        new LocalizationInfo("中文繁体", "备注：台湾、香港、澳门", GetImageUri("zh-CN"), "zh-TW", true),
    ];

    /// <summary>
    ///     Variable with the currently used <see cref="LocalizationInfo" />.
    /// </summary>
    public LocalizationInfo Current { get; private set; } = new();

    /// <summary>
    ///     Variable with the currently used <see cref="CultureInfo" />.
    /// </summary>
    public CultureInfo Culture { get; private set; }

    /// <summary>
    ///     Returns the current instance of the class.
    ///     The language can be set on creation (first call), by passing a culture code (like "en-US") as parameter.
    ///     Use <see cref="Change(LocalizationInfo)" /> to change it later.
    /// </summary>
    /// <param name="cultureCode">Culture code (default is "en-US"). See also <see cref="LocalizationInfo.Code" />.</param>
    /// <returns>Instance of the class.</returns>
    public static LocalizationManager GetInstance(string cultureCode = DefaultCultureCode)
    {
        _instance ??= new LocalizationManager(cultureCode);

        return _instance;
    }

    /// <summary>
    ///     Method to build the uri for a flag image based on the culture code.
    /// </summary>
    /// <param name="cultureCode">Culture code like "en-US".</param>
    /// <returns>Uri of the flag image.</returns>
    private static Uri GetImageUri(string cultureCode)
    {
        return new Uri($"{BaseFlagImageUri}{cultureCode}.png");
    }

    /// <summary>
    ///     Method to get the <see cref="LocalizationInfo" /> based on the culture code.
    /// </summary>
    /// <param name="cultureCode"></param>
    /// <returns>Return the <see cref="LocalizationInfo" /> or null if not found.</returns>
    private static LocalizationInfo GetLocalizationInfoBasedOnCode(string cultureCode)
    {
        return List.FirstOrDefault(x => x.Code == cultureCode);
    }

    /// <summary>
    ///     Method to change the language.
    /// </summary>
    /// <param name="info">
    ///     <see cref="LocalizationInfo" />
    /// </param>
    public void Change(LocalizationInfo info)
    {
        Current = info;

        Culture = new CultureInfo(info.Code);
    }
}
