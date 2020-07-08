using System;
using System.IO;
using System.Windows.Forms;

namespace steam_sharp.Forms
{
    public partial class Form1 : Form
    {
        private ApplicationDataClass _applicationData;

        // Forms
        private AppFetcher _appFetcher;
        private SettingsForm _settingsForm;

        public Form1()
        {
            InitializeComponent();

            // Application Data
            SetupAppData();

            // Settings
            _settingsForm = new SettingsForm(_applicationData);

            // AppFetcher
            _appFetcher = new AppFetcher(_applicationData);
            _appFetcher.Owner = this;
        }

        private void SetupAppData()
        {
            _applicationData = new ApplicationDataClass();
            if (File.Exists(ApplicationConstants.ApiKeyFolder))
            {
                _applicationData = new ApplicationDataClass(File.ReadAllText(ApplicationConstants.ApiKeyFolder));
            }
        }

        private void appFetcherButton_Click(object sender, EventArgs e)
        {
            if (!_applicationData.IsApiKeySet())
            {
                ApplicationConstants.ApiNotSetMessage();
                return;
            }

            _appFetcher.Show();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            _settingsForm.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _applicationData.Settings.UpdateSettingsAsync();
            
            e.Cancel = false;
            Application.Exit();
        }

        private void friendFinder_Click(object sender, EventArgs e)
        {
            _applicationData.GetFriends();
        }
    }
}