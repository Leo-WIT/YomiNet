using YomiNet.ViewModels;

namespace YomiNet.Views;

public partial class NetworkConnectionWidgetView
{
    private readonly NetworkConnectionWidgetViewModel _viewModel = new();

    public NetworkConnectionWidgetView()
    {
        InitializeComponent();
        DataContext = _viewModel;
    }

    public void Check()
    {
        _viewModel.Check();
    }
}