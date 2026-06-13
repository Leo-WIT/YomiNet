using System;
using System.Windows;
using System.Windows.Threading;

namespace YomiNet.Views;

public partial class NeighborTableAddEntryChildWindow
{
    public NeighborTableAddEntryChildWindow()
    {
        InitializeComponent();
    }

    private void ChildWindow_OnLoaded(object sender, RoutedEventArgs e)
    {
        Dispatcher.BeginInvoke(DispatcherPriority.ContextIdle, new Action(delegate
        {
            TextBoxIPAddress.Focus();
        }));
    }
}
