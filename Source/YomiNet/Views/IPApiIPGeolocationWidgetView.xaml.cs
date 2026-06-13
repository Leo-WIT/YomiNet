using YomiNet.ViewModels;

namespace YomiNet.Views;

public partial class IPApiIPGeolocationWidgetView
{
    private readonly IPApiIPGeolocationWidgetViewModel _viewModel = new();

    public IPApiIPGeolocationWidgetView()
    {
        InitializeComponent();
        DataContext = _viewModel;
    }

}