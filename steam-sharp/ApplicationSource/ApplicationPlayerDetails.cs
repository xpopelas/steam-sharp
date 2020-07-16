using System.Collections.Generic;
using System.Linq;
using Steam.Models.SteamCommunity;

namespace steam_sharp
{
    public class ApplicationPlayerDetails
    {
        public ulong SteamId;
        public PlayerSummaryModel PlayerProfile;
        public List<ulong> Friends;
        public OwnedGamesResultModel OwnedGames;
    
        public bool OwnsGame(uint appId)
        {
            return OwnedGames.OwnedGames.Select(x => x.AppId).Contains(appId);
        }
    
    }
}