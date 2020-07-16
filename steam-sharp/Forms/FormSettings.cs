using System;
using System.Windows.Forms;
using steam_sharp.Properties;

namespace steam_sharp
{
    public partial class FormSettingsForm : Form
    {
        private ApplicationDataClass _applicationData;
        
        public FormSettingsForm(ApplicationDataClass applicationData)
        {
            _applicationData = applicationData;
            InitializeComponent();

            storeAppsPerm.Checked = _applicationData.Settings.SaveLoadApps;
            storeIndivAppsPerm.Checked = _applicationData.Settings.SaveIndividualApps;
            checkBoxSaveAPI.Checked = _applicationData.Settings.SaveAPIKey;
            checkBoxSaveUsername.Checked = _applicationData.Settings.SaveUsername;
            
            if (_applicationData.IsApiKeySet())
            {
                labelApi.Text = @"API Key already set";
            }

            if (_applicationData.IsUsernameSet())
            {
                textBoxUsername.Text = _applicationData.Settings.Username;
            }
        }

        private void storeAppsPerm_CheckedChanged(object sender, EventArgs e)
        {
            _applicationData.Settings.SaveLoadApps = storeAppsPerm.Checked;
            _applicationData.Settings.UpdateSettingsAsync();
        }

        private void storeIndivAppsPerm_CheckedChanged(object sender, EventArgs e)
        {
            _applicationData.Settings.SaveIndividualApps = storeIndivAppsPerm.Checked;
            _applicationData.Settings.UpdateSettingsAsync();
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void buttonUpdateApi_Click(object sender, EventArgs e)
        {
            _applicationData.UpdateApiKey(textBoxApi.Text);
            labelApi.Text = @"API Key successfully set";
            textBoxApi.Text = "";
        }

        private void checkBoxSaveAPI_CheckedChanged(object sender, EventArgs e)
        {
            _applicationData.Settings.SaveAPIKey = checkBoxSaveAPI.Checked;
            _applicationData.Settings.UpdateSettingsAsync();
        }

        private void checkBoxSaveUsername_CheckedChanged(object sender, EventArgs e)
        {
            _applicationData.Settings.SaveUsername = checkBoxSaveUsername.Checked;
            _applicationData.Settings.UpdateSettingsAsync();
        }

        private async void buttonSubmitUsername_Click(object sender, EventArgs e)
        {
            if (!await _applicationData.UpdateUsername(textBoxUsername.Text))
            {
                ApplicationConstants.MessageAppNotAvailable();
                return;
            }
            
            _applicationData.Settings.Username = textBoxUsername.Text;
            _applicationData.Settings.UpdateSettingsAsync();
        }

        private void buttonApiInfo_Click(object sender, EventArgs e)
        {
            ApplicationConstants.MessageApiLinkLocation();
        }

        private void buttonVanityUrlInfo_Click(object sender, EventArgs e)
        {
            ApplicationConstants.MessageUsernameIsVanityUrl();
        }
    }
}