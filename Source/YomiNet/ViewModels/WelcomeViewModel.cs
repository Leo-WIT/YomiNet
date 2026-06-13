using YomiNet.Settings;
using YomiNet.Utilities;
using System;
using System.Windows.Input;

namespace YomiNet.ViewModels;

public class WelcomeViewModel : ViewModelBase
{
    public WelcomeViewModel(Action<WelcomeViewModel> continueCommand)
    {
        ContinueCommand = new RelayCommand(_ => continueCommand(this));
    }

    public ICommand OpenWebsiteCommand => new RelayCommand(OpenWebsiteAction);

    private static void OpenWebsiteAction(object url)
    {
        ExternalProcessStarter.OpenUrl((string)url);
    }

    public ICommand ContinueCommand { get; }

    public bool CheckForUpdatesAtStartup
    {
        get;
        set
        {
            if (value == field)
                return;

            field = value;
            OnPropertyChanged();
        }
    } = GlobalStaticConfiguration.Update_CheckForUpdatesAtStartup;

    public bool CheckPublicIPAddress
    {
        get;
        set
        {
            if (value == field)
                return;

            field = value;
            OnPropertyChanged();
        }
    } = GlobalStaticConfiguration.Dashboard_CheckPublicIPAddress;

    public bool CheckIPApiDNSResolver
    {
        get;
        set
        {
            if (value == field)
                return;

            field = value;
            OnPropertyChanged();
        }
    } = GlobalStaticConfiguration.Dashboard_CheckIPApiDNSResolver;

    public bool PowerShellModifyGlobalProfile
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
}
