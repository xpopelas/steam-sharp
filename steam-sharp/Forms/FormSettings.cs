using System;
using System.Windows.Forms;

namespace steam_sharp
{
    public partial class SettingsForm : Form
    {
        private ApplicationDataClass _applicationData;
        
        public SettingsForm(ApplicationDataClass applicationData)
        {
            _applicationData = applicationData;
            InitializeComponent();

            storeAppsPerm.Checked = _applicationData.Settings.SaveLoadApps;
            storeIndivAppsPerm.Checked = _applicationData.Settings.SaveIndividualApps;
            checkBoxSaveAPI.Checked = _applicationData.Settings.SaveAPIKey;
            
            if (_applicationData.IsApiKeySet())
            {
                labelApi.Text = @"API Key already set";
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
            _applicationData.UpdateApiKeyAsync(textBoxApi.Text);
            labelApi.Text = @"API Key successfully set";
        }

        private void checkBoxSaveAPI_CheckedChanged(object sender, EventArgs e)
        {
            _applicationData.Settings.SaveAPIKey = checkBoxSaveAPI.Checked;
            _applicationData.Settings.UpdateSettingsAsync();
        }
    }
}