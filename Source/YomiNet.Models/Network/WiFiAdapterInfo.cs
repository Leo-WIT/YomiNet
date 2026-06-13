using Windows.Devices.WiFi;

namespace YomiNet.Models.Network;

public class WiFiAdapterInfo
{
    public NetworkInterfaceInfo NetworkInterfaceInfo { get; set; }
    public WiFiAdapter WiFiAdapter { get; set; }
}