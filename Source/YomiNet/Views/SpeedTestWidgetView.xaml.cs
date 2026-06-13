using YomiNet.ViewModels;

namespace YomiNet.Views;

public partial class SpeedTestWidgetView
{
    private readonly SpeedTestWidgetViewModel _viewModel = new();

    public SpeedTestWidgetView()
    {
        InitializeComponent();
        DataContext = _viewModel;
    }
}
