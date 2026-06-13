using YomiNet.ViewModels;

namespace YomiNet.Views;

public partial class WakeOnLANSettingsView
{
    private readonly WakeOnLANSettingsViewModel _viewModel = new();

    public WakeOnLANSettingsView()
    {
        InitializeComponent();
        DataContext = _viewModel;
    }
}