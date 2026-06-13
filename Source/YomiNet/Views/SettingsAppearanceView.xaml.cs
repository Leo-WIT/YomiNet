using YomiNet.ViewModels;

namespace YomiNet.Views;

public partial class SettingsAppearanceView
{
    private readonly SettingsAppearanceViewModel _viewModel = new();

    public SettingsAppearanceView()
    {
        InitializeComponent();
        DataContext = _viewModel;
    }
}