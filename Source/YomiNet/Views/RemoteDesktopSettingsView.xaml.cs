using YomiNet.ViewModels;

namespace YomiNet.Views;

public partial class RemoteDesktopSettingsView
{
    private readonly RemoteDesktopSettingsViewModel _viewModel = new();

    public RemoteDesktopSettingsView()
    {
        InitializeComponent();
        DataContext = _viewModel;
    }
}