using YomiNet.ViewModels;

namespace YomiNet.Views;

public partial class SettingsAutostartView
{
    private readonly SettingsAutostartViewModel _viewModel = new();

    public SettingsAutostartView()
    {
        InitializeComponent();
        DataContext = _viewModel;
    }
}