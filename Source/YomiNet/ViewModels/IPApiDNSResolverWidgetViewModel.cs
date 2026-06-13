using System.Threading.Tasks;
using System.Windows.Input;
using YomiNet.Models.IPApi;
using YomiNet.Settings;
using YomiNet.Utilities;

namespace YomiNet.ViewModels;

/// <summary>
/// View model for the IP API DNS resolver widget.
/// </summary>
public class IPApiDNSResolverWidgetViewModel : ViewModelBase
{
    #region Variables

    /// <summary>
    /// Gets or sets a value indicating whether the check is running.
    /// </summary>
    public bool IsRunning
    {
        get;
        set
        {
            if (value == field)
                return;

            field = value;
            OnPropertyChanged();
        }
    }

    /// <summary>
    /// Gets the result of the DNS resolver check.
    /// </summary>
    public DNSResolverResult Result
    {
        get;
        private set
        {
            if (value == field)
                return;

            field = value;
            OnPropertyChanged();
        }
    }

    #endregion

    #region Constructor, load settings

    /// <summary>
    /// Initializes a new instance of the <see cref="IPApiDNSResolverWidgetViewModel"/> class.
    /// </summary>
    public IPApiDNSResolverWidgetViewModel()
    {
        LoadSettings();
        Check();
    }

    /// <summary>
    /// Loads the settings.
    /// </summary>
    private void LoadSettings()
    {

    }

    #endregion

    #region ICommands & Actions

    /// <summary>
    /// Gets the command to check the DNS resolver.
    /// </summary>
    public ICommand CheckCommand => new RelayCommand(_ => Check(), _ => !IsRunning);

    #endregion

    #region Methods

    /// <summary>
    /// Checks the DNS resolver.
    /// </summary>
    private void Check()
    {
        _ = CheckAsync();
    }

    /// <summary>
    /// Checks the DNS resolver asynchronously.
    /// </summary>
    private async Task CheckAsync()
    {
        // Check is disabled via settings
        if (!SettingsManager.Current.Dashboard_CheckIPApiDNSResolver)
            return;

        IsRunning = true;
        Result = null;

        // Make the user happy, let him see a reload animation (and he cannot spam the reload command)
        await Task.Delay(GlobalStaticConfiguration.ApplicationUIRefreshInterval);

        Result = await DNSResolverService.GetInstance().GetDNSResolverAsync();

        IsRunning = false;
    }

    #endregion
}