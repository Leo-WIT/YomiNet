using YomiNet.ViewModels;

namespace YomiNet.Views;

public partial class NetworkInterfaceSettingsView
{
    private readonly NetworkInterfaceSettingsViewModel _viewModel = new();

    public NetworkInterfaceSettingsView()
    {
        InitializeComponent();
        DataContext = _viewModel;
    }
}
