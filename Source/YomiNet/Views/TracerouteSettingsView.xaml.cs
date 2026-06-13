using YomiNet.ViewModels;

namespace YomiNet.Views;

public partial class TracerouteSettingsView
{
    private readonly TracerouteSettingsViewModel _viewModel = new();

    public TracerouteSettingsView()
    {
        InitializeComponent();
        DataContext = _viewModel;
    }
}