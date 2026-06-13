using YomiNet.ViewModels;

namespace YomiNet.Views;

public partial class PingMonitorSettingsView
{
    private readonly PingMonitorSettingsViewModel _viewModel = new();

    public PingMonitorSettingsView()
    {
        InitializeComponent();
        DataContext = _viewModel;
    }
}