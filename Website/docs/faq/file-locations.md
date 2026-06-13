---
description: "Find where YomiNet stores its files including profiles, settings, and themes for both Setup (MSI) and Portable installations."
keywords: [YomiNet, file locations, profile location, settings location, installation path, portable path]
---

# File locations

## Where are files stored?

The setup installs the application by default in the following path: `%ProgramFiles%\YomiNet`

You can run the archive and portable version from anywhere (e.g. USB stick, network share, etc.).

Profiles, settings and themes are stored in the following folders:

| File(s)  | Setup or Archiv                                     | Portable                  |
| -------- | --------------------------------------------------- | ------------------------- |
| Profiles | `%UserProfile%\Documents\YomiNet\Profiles\*` | `<APP_FOLDER>\Profiles\*` |
| Settings | `%UserProfile%\Documents\YomiNet\Settings\*` | `<APP_FOLDER>\Settings\*` |
| Themes   | `<APP_FOLDER>\Themes\*`                             | `<APP_FOLDER>\Themes\*`   |

:::note

It is recommended to backup the above files on a regular basis.

:::

:::tip

Use a cloud service like OneDrive or Nextcloud to sync the above folders with multiple devices or to use them as a backup.

:::

In addition, some files and settings, as well as the cache, are stored in the following locations:

| File(s)             | Setup, Archiv and Portable                                           |
| ------------------- | -------------------------------------------------------------------- |
| Local settings      | `%LocalAppData%\YomiNet\YomiNet_Url_<RANDOM_STRING>\*` |
| Log                 | `%LocalAppData%\YomiNet\YomiNet.log`                   |
| PowerShell profiles | `HKCU:\Console\<PATH_OF_CONSOLE>`                                    |
| PuTTY log           | `%LocalAppData%\YomiNet\PuTTY_Log\*`                          |
| PuTTY profile       | `HKCU:\Software\SimonTatham\PuTTY\Sessions\YomiNet`           |
| WebConsole cache    | `%LocalAppData%\YomiNet\WebConsole_Cache\*`                   |
