using YomiNet.ViewModels;

namespace YomiNet.Views;

public partial class DashboardView
{
    private readonly DashboardViewModel _viewModel = new();

    private readonly NetworkConnectionWidgetView _networkConnectionWidgetView = new();
    private readonly IPApiDNSResolverWidgetView _ipApiDNSResolverWidgetView = new();


    public DashboardView()
    {
        InitializeComponent();
        DataContext = _viewModel;

        // Load views
        ContentControlNetworkConnection.Content = _networkConnectionWidgetView;
        ContentControlIPApiDNSResolver.Content = _ipApiDNSResolverWidgetView;
    }

    public void OnViewVisible()
    {
        _viewModel.OnViewVisible();

        // Check network connection
        _networkConnectionWidgetView.Check();
    }

    public void OnViewHide()
    {
        _viewModel.OnViewHide();
    }
}
