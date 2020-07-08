using System.IO;
using Newtonsoft.Json;

namespace steam_sharp
{
    public class ApplicationSettings
    {
        public bool SaveLoadApps;
        public bool SaveIndividualApps;
        public bool SaveAPIKey;

        public ApplicationSettings()
        {
            DefaultSettings();
        }

        public void DefaultSettings()
        {
            SaveLoadApps = true;
            SaveIndividualApps = true;
            SaveAPIKey = true;
        }
        
        public async void UpdateSettingsAsync()
        {
            using (StreamWriter sw = new StreamWriter(ApplicationConstants.SettingsPath))
            {
                await sw.WriteAsync(JsonConvert.SerializeObject(this));
            }
        }
    }
}