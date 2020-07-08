using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Steam.Models.SteamCommunity;
using Steam.Models.SteamStore;
using SteamWebAPI2.Exceptions;
using SteamWebAPI2.Interfaces;
using SteamWebAPI2.Mappings;
using SteamWebAPI2.Utilities;

namespace steam_sharp
{
    public class ApplicationDataClass
    {
        private SteamWebInterfaceFactory _steamWeb;
        private SteamUser _steamUser;
        private SteamStore _steamStore;
        private PlayerSummaryModel _playerProfile;
        
        public ApplicationSettings Settings;
        private Dictionary<uint, string> _steamApps;

        public ApplicationDataClass()
        {
            LoadSettings();
        }

        public void UpdateApiKey(string apiKey)
        {
            Settings.ApiKey = apiKey;
            Settings.UpdateSettingsAsync();

            LoadSteamDetailsAsync();
        }

        public async Task<bool> UpdateUsername(string username)
        {
            if (!IsApiKeySet())
            {
                ApplicationConstants.ApiNotSetMessage();
                return false;
            }

            try
            {
                var tempUser = await _steamUser.ResolveVanityUrlAsync(username);
                var tempProfileResponse = await _steamUser.GetPlayerSummaryAsync(tempUser.Data);
                _playerProfile = tempProfileResponse.Data;

                return true;
            }
            catch (VanityUrlNotResolvedException)
            {
                return false;
            }
            
        }

        private void LoadSettings()
        {
            Settings = new ApplicationSettings();
            if (File.Exists(ApplicationConstants.SettingsPath))
            {
                Settings = JsonConvert.DeserializeObject<ApplicationSettings>(
                    File.ReadAllText(ApplicationConstants.SettingsPath));
            }

            LoadSteamDetailsAsync();
        }
        private async void LoadSteamDetailsAsync()
        {
            if (!IsApiKeySet())
            {
                return;
            }

            _steamWeb = new SteamWebInterfaceFactory(Settings.ApiKey);
            _steamUser = _steamWeb.CreateSteamWebInterface<SteamUser>();
            _steamStore = _steamWeb.CreateSteamStoreInterface();

            if (IsUsernameSet())
            {
                await UpdateUsername(Settings.Username);
            }
            
            FetchApps();
        }

        public async Task<StoreAppDetailsDataModel> GetAppInfoAsync(uint appId)
        {
            StoreAppDetailsDataModel appInfo;
            try
            {
                appInfo = await _steamStore.GetStoreAppDetailsAsync(appId);
            }
            catch (NullReferenceException)
            {
                return null;
            }
            return appInfo;
        }

        public bool IsApiKeySet()
        {
            return Settings.ApiKey != null;
        }

        public bool IsUsernameSet()
        {
            return Settings.Username != null;
        }

        public Dictionary<uint, string> SearchForApps(string searchPhrase)
        {
            return _steamApps
                .Where(x => x.Value.IndexOf(searchPhrase, StringComparison.OrdinalIgnoreCase) >= 0)
                .OrderBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);
        }

        private async void FetchApps()
        {
            _steamApps = new Dictionary<uint, string>();
            
            //Load from json - if there's any
            if (File.Exists(ApplicationConstants.AvailableAppsPath))
            {
                _steamApps = JsonConvert.DeserializeObject<Dictionary<uint, string>>(File.ReadAllText(ApplicationConstants.AvailableAppsPath));
            }

            int prevSize = _steamApps.Count;
            
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
                _steamApps = tempSteamApps;
                using (StreamWriter sw = new StreamWriter(ApplicationConstants.AvailableAppsPath))
                {
                    await sw.WriteAsync(JsonConvert.SerializeObject(_steamApps));
                }
            }
        }
    }
}