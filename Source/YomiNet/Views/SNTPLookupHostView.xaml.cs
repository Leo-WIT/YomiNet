using YomiNet.ViewModels;

namespace YomiNet.Views;

public partial class SNTPLookupHostView
{
    private readonly SNTPLookupHostViewModel _viewModel = new();

    public SNTPLookupHostView()
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