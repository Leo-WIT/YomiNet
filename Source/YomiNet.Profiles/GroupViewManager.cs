using System.Collections.Generic;
using MahApps.Metro.IconPacks;
using YomiNet.Models;

namespace YomiNet.Profiles;

public static class GroupViewManager
{
    // List of all applications
    public static List<GroupViewInfo> List =>
    [
        // General
        new GroupViewInfo(GroupViewName.General, new PackIconModern { Kind = PackIconModernKind.Box }),

        // Applications
        new GroupViewInfo(GroupViewName.PowerShell, ApplicationManager.GetIcon(ApplicationName.PowerShell)),
        new GroupViewInfo(GroupViewName.PuTTY, ApplicationManager.GetIcon(ApplicationName.PuTTY)),
        new GroupViewInfo(GroupViewName.SNMP, ApplicationManager.GetIcon(ApplicationName.SNMP))
    ];
}
