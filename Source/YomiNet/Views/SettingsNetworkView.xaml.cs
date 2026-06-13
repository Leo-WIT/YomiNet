using YomiNet.ViewModels;

namespace YomiNet.Views;

public partial class SettingsNetworkView
{
    private readonly SettingsNetworkViewModel _viewModel = new();

    public SettingsNetworkView()
    {
        InitializeComponent();
        DataContext = _viewModel;
    }
}