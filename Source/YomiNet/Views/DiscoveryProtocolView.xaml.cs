using YomiNet.ViewModels;

namespace YomiNet.Views;

public partial class DiscoveryProtocolView
{
    private readonly DiscoveryProtocolViewModel _viewModel = new();

    public DiscoveryProtocolView()
    {
        InitializeComponent();
        DataContext = _viewModel;
    }

    public void OnViewHide()
    {
        _viewModel.OnViewHide();
    }

    public void OnViewVisible()
    {
        _viewModel.OnViewVisible();
    }
}