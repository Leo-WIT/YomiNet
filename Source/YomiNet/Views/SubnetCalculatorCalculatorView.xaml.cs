using YomiNet.ViewModels;

namespace YomiNet.Views;

public partial class SubnetCalculatorCalculatorView
{
    private readonly SubnetCalculatorCalculatorViewModel _viewModel = new();

    public SubnetCalculatorCalculatorView()
    {
        InitializeComponent();
        DataContext = _viewModel;
    }
}