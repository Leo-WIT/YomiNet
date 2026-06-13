using YomiNet.ViewModels;

namespace YomiNet.Views;

public partial class SettingsLanguageView
{
    private readonly SettingsLanguageViewModel _viewModel = new();

    public SettingsLanguageView()
    {
        InitializeComponent();
        DataContext = _viewModel;
    }
}