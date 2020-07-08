using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Steam.Models.SteamStore;
using SteamWebAPI2.Interfaces;
using SteamWebAPI2.Mappings;
using SteamWebAPI2.Utilities;

namespace steam_sharp
{
    public class ApplicationDataClass
    {
        private string _apiKey;
        private SteamWebInterfaceFactory _steamWeb;

        public ApplicationSettings Settings;
        public Dictionary<uint, string> SteamApps { get; private set; }

        public ApplicationDataClass(string apiKey)
        {
            _apiKey = apiKey;
            LoadSettings();
            LoadSteamDetails();
        }

        public ApplicationDataClass()
        {
            LoadSettings();
        }

        public async void UpdateApiKeyAsync(string apiKey)
        {
            _apiKey = apiKey;
            if (Settings.SaveAPIKey) // Save API key to file
            {
                using (StreamWriter sw = new StreamWriter(ApplicationConstants.ApiKeyFolder))
                {
                    await sw.WriteAsync(apiKey);
                }
            }
            LoadSettings();
            LoadSteamDetails();
        }

        private void LoadSettings()
        {
            Settings = new ApplicationSettings();
            Settings = JsonConvert.DeserializeObject<ApplicationSettings>(
                File.ReadAllText(ApplicationConstants.SettingsPath));
        }
        private void LoadSteamDetails()
        {
            _steamWeb = new SteamWebInterfaceFactory(_apiKey);
            FetchApps();
        }

        public async void GetFriends()
        {
            var steamUserInterface = _steamWeb.CreateSteamWebInterface<SteamUser>();
            var steamEconomyInterface = _steamWeb.CreateSteamWebInterface<SteamEconomy>();
            var steamStoreInterface = _steamWeb.CreateSteamStoreInterface();
            var temp = await steamUserInterface.ResolveVanityUrlAsync("xpopelas"); // TODO: this as well
            var kek = await steamStoreInterface.GetStoreAppDetailsAsync(730); // TODO: seems interesting
            var playerFriendList = await steamUserInterface.GetFriendsListAsync(76561198045869684);
            var csgoPriceTest = await steamEconomyInterface.GetAssetPricesAsync(730);
            var playerSummaryResponse = await steamUserInterface.GetPlayerSummaryAsync(76561198045869684);
        }

        public async Task<StoreAppDetailsDataModel> GetAppInfoAsync(uint appId)
        {
            var steamStoreInterface = _steamWeb.CreateSteamStoreInterface();
            StoreAppDetailsDataModel appInfo;
            try
            {
                appInfo = await steamStoreInterface.GetStoreAppDetailsAsync(appId);
            }
            catch (NullReferenceException)
            {
                return null;
            }
            return appInfo;
        }

        public bool DoesAppExist(uint appid)
        {
            return SteamApps.ContainsKey(appid);
        }

        public bool IsApiKeySet()
        {
            return _apiKey != null;
        }

        public Dictionary<uint, string> SearchForApps(string searchPhrase)
        {
            return SteamApps
                .Where(x => x.Value.IndexOf(searchPhrase, StringComparison.OrdinalIgnoreCase) >= 0)
                .OrderBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);
        }

        private async void FetchApps()
        {
            SteamApps = new Dictionary<uint, string>();
            
            //Load from json - if there's any
            if (File.Exists(ApplicationConstants.AvailableAppsPath))
            {
                SteamApps = JsonConvert.DeserializeObject<Dictionary<uint, string>>(File.ReadAllText(ApplicationConstants.AvailableAppsPath));
            }

            int prevSize = SteamApps.Count;
            
            // Load from web/steam async
            var steamWebInterface = _steamWeb.CreateSteamWebInterface<SteamApps>();
            var appList = await steamWebInterface.GetAppListAsync();

            if (appList.Data.Count > prevSize)
            {
                // Convert SteamWebResponse Data to simple Dictionary
                var tempSteamApps = appList.Data
                    .OrderBy(x => x.AppId)
                    .ToDictionary(x => x.AppId, x => x.Name);

                // Update steam apps cached collection
                SteamApps = tempSteamApps;
                using (StreamWriter sw = new StreamWriter(ApplicationConstants.AvailableAppsPath))
                {
                    await sw.WriteAsync(JsonConvert.SerializeObject(SteamApps));
                }
            }
        }
    }
}