using YomiNet.ViewModels;

namespace YomiNet.Views;

public partial class DashboardSettingsView
{
    private readonly DashboardSettingsViewModel _viewModel = new();

    public DashboardSettingsView()
    {
        InitializeComponent();
        DataContext = _viewModel;
    }
}