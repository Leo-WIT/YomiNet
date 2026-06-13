using YomiNet.ViewModels;

namespace YomiNet.Views;

public partial class SettingsWindowView
{
    private readonly SettingsWindowViewModel _viewModel = new();

    public SettingsWindowView()
    {
        InitializeComponent();
        DataContext = _viewModel;
    }
}