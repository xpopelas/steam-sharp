using System.IO;
using Newtonsoft.Json;

namespace steam_sharp
{
    public class ApplicationSettings
    {
        public bool SaveLoadApps;
        public bool SaveIndividualApps;
        public bool SaveAPIKey;
        public bool SaveUsername;
        public string Username;
        public string ApiKey;

        public ApplicationSettings()
        {
            DefaultSettings();
        }

        public ApplicationSettings(ApplicationSettings other)
        {
            SaveLoadApps = other.SaveLoadApps;
            SaveIndividualApps = other.SaveIndividualApps;
            SaveAPIKey = other.SaveIndividualApps;
            SaveUsername = other.SaveUsername;
            Username = other.Username;
            ApiKey = other.ApiKey;
        }

        public void DefaultSettings()
        {
            SaveLoadApps = true;
            SaveIndividualApps = true;
            SaveAPIKey = true;
            SaveUsername = true;
            Username = null;
            ApiKey = null;
        }
        
        public async void UpdateSettingsAsync()
        {
            ApplicationSettings copy = new ApplicationSettings(this);
            if (!SaveAPIKey)
            {
                copy.ApiKey = null;
            }

            if (!SaveUsername)
            {
                copy.Username = null;
            }
            
            using (StreamWriter sw = new StreamWriter(ApplicationConstants.SettingsPath))
            {
                await sw.WriteAsync(JsonConvert.SerializeObject(copy));
            }
        }
    }
}