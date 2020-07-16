using System;
using System.IO;
using System.Windows.Forms;

namespace steam_sharp.Forms
{
    public partial class Form1 : Form
    {
        private ApplicationDataClass _applicationData;

        // Forms
        private FormAppFetcher _formAppFetcher;
        private FormSettingsForm _formSettingsForm;

        public Form1()
        {
            InitializeComponent();

            // Application Data
            _applicationData = new ApplicationDataClass();

            // Settings
            _formSettingsForm = new FormSettingsForm(_applicationData);

            // AppFetcher
            _formAppFetcher = new FormAppFetcher(_applicationData);
        }

        private void appFetcherButton_Click(object sender, EventArgs e)
        {
            if (!_applicationData.IsApiKeySet())
            {
                ApplicationConstants.MessageApiNotSet();
                return;
            }

            _formAppFetcher.Show();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            _formSettingsForm.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _applicationData.Settings.UpdateSettingsAsync();
            
            e.Cancel = false;
            Application.Exit();
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            if (!_applicationData.IsUsernameSet())
            {
                ApplicationConstants.MessageUsernameNotSet();
            }
            
            var profileView = new FormProfileOverview(_applicationData);
            profileView.Show();
        }
    }
}