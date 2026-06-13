using System.Net;
using YomiNet.Models.Network;
using YomiNet.Settings;

namespace YomiNet.Profiles.Application;

public static class WakeOnLAN
{
    public static WakeOnLANInfo CreateInfo(ProfileInfo profileInfo)
    {
        var info = new WakeOnLANInfo
        {
            MagicPacket = Models.Network.WakeOnLAN.CreateMagicPacket(profileInfo.WakeOnLAN_MACAddress),
            Broadcast = IPAddress.Parse(profileInfo.WakeOnLAN_Broadcast),
            Port = SettingsManager.Current.WakeOnLAN_Port
        };

        return info;
    }
}