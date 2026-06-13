using YomiNet.ViewModels;

namespace YomiNet.Views;

public partial class SettingsStatusView
{
    private readonly SettingsStatusViewModel _viewModel = new();

    public SettingsStatusView()
    {
        InitializeComponent();
        DataContext = _viewModel;
    }
}