using YomiNet.ViewModels;

namespace YomiNet.Views;

public partial class BitCalculatorSettingsView
{
    private readonly BitCalculatorSettingsViewModel _viewModel = new();

    public BitCalculatorSettingsView()
    {
        InitializeComponent();
        DataContext = _viewModel;
    }
}