using System.Windows.Input;
using YomiNet.Utilities;

namespace YomiNet.ViewModels;

public abstract class ViewModelBase : PropertyChangedBase
{
    public ICommand CopyDataToClipboardCommand => new RelayCommand(CopyDataToClipboardAction);

    private static void CopyDataToClipboardAction(object data)
    {
        ClipboardHelper.SetClipboard(data.ToString());
    }
}