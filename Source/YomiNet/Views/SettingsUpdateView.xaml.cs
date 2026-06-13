using YomiNet.ViewModels;

namespace YomiNet.Views;

public partial class SettingsUpdateView
{
    private readonly SettingsUpdateViewModel _viewModel = new();

    public SettingsUpdateView()
    {
        InitializeComponent();
        DataContext = _viewModel;
    }
}