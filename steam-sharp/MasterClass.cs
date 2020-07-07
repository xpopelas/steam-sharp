using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SteamWebAPI2.Interfaces;
using SteamWebAPI2.Utilities;

namespace steam_sharp
{
    public class MasterClass
    {
        private SteamWebInterfaceFactory _steamWeb;
        private const string AppFileName = "steam_apps.json";
        public Dictionary<uint, string> SteamApps { get; private set; } = new Dictionary<uint, string>();

        public MasterClass(string APIkey)
        {
            _steamWeb = new SteamWebInterfaceFactory(APIkey);
            GetApps();
        }

        public async void GetFriends()
        {
            var steamUserInterface = _steamWeb.CreateSteamWebInterface<SteamUser>();
            var playerSummaryResponse = await steamUserInterface.GetPlayerSummaryAsync(76561198045869684);
            var playerSummaryData = playerSummaryResponse.Data;
        }

        public bool DoesAppExist(uint appid)
        {
            return SteamApps.ContainsKey(appid);
        }

        public Dictionary<uint, string> SearchForApps(string searchPhrase, bool caseInsensitive = true)
        {
            return SteamApps
                .Where(x => x.Value.IndexOf(searchPhrase, StringComparison.OrdinalIgnoreCase) >= 0)
                .OrderBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);
        }

        private async void GetApps()
        {
            //Load from json - if there's any
            if (File.Exists(AppFileName))
            {
                SteamApps = JsonConvert.DeserializeObject<Dictionary<uint, string>>(File.ReadAllText(AppFileName));
            }

            int prevSize = SteamApps.Count;
            
            // Load from web/steam async
            var steamWebInterface = _steamWeb.CreateSteamWebInterface<SteamApps>();
            var appList = await steamWebInterface.GetAppListAsync();
            var tempSteamApps = appList.Data.ToDictionary(x => x.AppId, x => x.Name);

            if (tempSteamApps.Count > prevSize)
            {
                //Update steam apps cached collection
                SteamApps = tempSteamApps;
                File.WriteAllText(AppFileName, JsonConvert.SerializeObject(SteamApps));
            }
        }
    }
}