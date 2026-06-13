using YomiNet.ViewModels;

namespace YomiNet.Views;

public partial class SettingsHotkeysView
{
    private readonly SettingsHotKeysViewModel _viewModel = new();

    public SettingsHotkeysView()
    {
        InitializeComponent();
        DataContext = _viewModel;
    }
}