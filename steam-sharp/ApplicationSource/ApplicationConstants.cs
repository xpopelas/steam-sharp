using System.Drawing;
using System.Windows.Forms;

namespace steam_sharp
{
    public class ApplicationConstants
    {
        public static string SettingsPath => @"data/settings.json";
        public static string AvailableAppsPath => @"data/steam_apps.json";
        public static string SteamStoreAppPrefix => @"https://store.steampowered.com/app/";

        public static Color ColorButtonBackground = Color.FromArgb(23, 26, 33);
        public static Color ColorFormBackground = Color.FromArgb(27, 40, 56);

        public static Color ColorStatusOffline = Color.FromArgb(76, 76, 78);
        public static Color ColorStatusOnline = Color.FromArgb(71, 132, 157);
        public static Color ColorStatusAway = ColorStatusOnline;
        public static Color ColorStatusInGame = Color.FromArgb(112, 148, 73);

        public static Color ColorNicknameInGame = Color.FromArgb(186, 209, 162);
        public static Color ColorNicknameOnline = Color.FromArgb(94, 173, 206);
        public static Color ColorNicknameAway = ColorNicknameOnline;
        public static Color ColorNicknameOffline = Color.FromArgb(142, 143, 143);
        
        public static void MessageApiNotSet()
        {
            MessageBox.Show(@"You can set your API key in Settings",
                @"API Key not yet set.",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        public static void MessageUsernameNotSet()
        {
            MessageBox.Show(@"You can set your username in Settings",
                @"Username not yet set",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        public static void MessageAppNotAvailable()
        {
            MessageBox.Show(@"Information about this application is not available from Steam Store.",
                @"Selected app not available",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        public static void MessageApiLinkLocation()
        {
            var result = MessageBox.Show(@"To get your private API key, you have to visit Steam official services." +
                            @"Do you wish to open the website?",
                @"API key URL",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                System.Diagnostics.Process.Start("https://steamcommunity.com/dev/apikey");
            }
        }

        public static void MessageInvalidUsername()
        {
            MessageBox.Show(@"Provided username in the settings could not be fetched, please " +
                    @"check your username in settings.",
                @"Invalid username",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        public static void MessageUsernameIsVanityUrl()
        {
            MessageBox.Show(@"As fetching profile by username is not currently supported, please fill out " +
                            @"your vanity URL. To find your vanity URL, visit your profile and your vanity URL should " +
                            "be in the URL (for example, vanity url of https://steamcommunity.com/id/C9shroud/ is \"C9shroud\"",
                @"Vanity URL is not username",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        public static void MessageProfileNotYetLoaded()
        {
            MessageBox.Show(@"Your profile was not yet loaded, please wait and try again later",
                @"Profile not yet loaded",
                MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk);
        }
        
        public static void MessageUserNotFound()
        {
            MessageBox.Show(@"The current user could not be loaded. The user is either private, or some internal " +
                            @"error occured.",
                @"User not found",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
        
    }
}