using System.Windows;
using Dragablz;
using YomiNet.Models;

namespace YomiNet.Controls;

public class DragablzInterTabClient(ApplicationName applicationName) : IInterTabClient
{
    public INewTabHost<Window> GetNewHost(IInterTabClient interTabClient, object partition, TabablzControl source)
    {
        var dragablzTabHostWindow = new DragablzTabHostWindow(applicationName);
        return new NewTabHost<DragablzTabHostWindow>(dragablzTabHostWindow, dragablzTabHostWindow.TabsContainer);
    }

    public TabEmptiedResponse TabEmptiedHandler(TabablzControl tabControl, Window window)
    {
        return window is MainWindow
            ? TabEmptiedResponse.CloseWindowOrLayoutBranch
            : TabEmptiedResponse.CloseWindowOrLayoutBranch;
    }
}
