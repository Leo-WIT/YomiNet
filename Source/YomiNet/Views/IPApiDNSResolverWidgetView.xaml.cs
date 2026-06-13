
﻿using YomiNet.ViewModels;

namespace YomiNet.Views;

public partial class IPApiDNSResolverWidgetView
{
    private readonly IPApiDNSResolverWidgetViewModel _viewModel = new();

    public IPApiDNSResolverWidgetView()
    {
        InitializeComponent();
        DataContext = _viewModel;
    }

}