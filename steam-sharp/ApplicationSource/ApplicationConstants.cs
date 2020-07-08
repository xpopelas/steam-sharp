using System.Windows.Forms;

namespace steam_sharp
{
    public class ApplicationConstants
    {
        public static string SettingsPath => @"data/settings.json";
        public static string AvailableAppsPath => @"data/steam_apps.json";
        public static string SteamStoreAppPrefix => @"https://store.steampowered.com/app/";
        
        public static void ApiNotSetMessage()
        {
            MessageBox.Show("You can set your API key in Settings",
                "API Key not yet set.",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        public static void AppNotAvailable()
        {
            MessageBox.Show("Information about this application is not available from Steam Store.",
                "Selected app not available",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
        
    }
}