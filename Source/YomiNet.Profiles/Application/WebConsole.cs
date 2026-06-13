using YomiNet.Models.WebConsole;

namespace YomiNet.Profiles.Application;

public class WebConsole
{
    public static WebConsoleSessionInfo CreateSessionInfo(ProfileInfo profileInfo)
    {
        var info = new WebConsoleSessionInfo
        {
            Url = profileInfo.WebConsole_Url
        };

        return info;
    }
}