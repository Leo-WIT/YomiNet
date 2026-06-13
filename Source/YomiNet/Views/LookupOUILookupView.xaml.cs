using System;
using System.Windows;
using System.Windows.Controls;
using YomiNet.ViewModels;

namespace YomiNet.Views;

public partial class LookupOUILookupView
{
    private readonly LookupOUILookupViewModel _viewModel = new();

    public LookupOUILookupView()
    {
        InitializeComponent();
        DataContext = _viewModel;
    }

    private void ContextMenu_Opened(object sender, RoutedEventArgs e)
    {
        if (sender is ContextMenu menu)
            menu.DataContext = _viewModel;
    }
}