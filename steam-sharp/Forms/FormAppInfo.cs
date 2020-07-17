using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Steam.Models.SteamStore;

namespace steam_sharp.Forms
{
    public partial class FormAppInfo : Form
    {
        private ApplicationDataClass _applicationData;
        private static uint _appId;
        private StoreAppDetailsDataModel _appStoreInfo;
        
        public FormAppInfo(ApplicationDataClass appData, uint appId)
        {
            InitializeComponent();
            
            _applicationData = appData;
            _appId = appId;
            
            LoadApp();
        }

        private async void LoadApp()
        {
            _appStoreInfo = await _applicationData.GetAppInfoAsync(_appId);
            
            if (_appStoreInfo == null)
            {
                ApplicationConstants.MessageAppNotAvailable();
                return;
            }
            
            LoadTextAppData();
            
            Show();
        }

        private void LoadTextAppData()
        {
            this.Text += _appStoreInfo.Name;
            pictureBox1.ImageLocation = _appStoreInfo.HeaderImage;
            labelAppTitle.Text = _appStoreInfo.Name;
            if (_appStoreInfo.IsFree)
            {
                label1.Text = @"Free";
                label1.ForeColor = Color.FromArgb(0, 204, 0);
            }
            else
            {
                label1.Text = _appStoreInfo.PriceOverview.FinalFormatted;
                if (_appStoreInfo.PriceOverview.DiscountPercent > 0)
                {
                    label1.Text += $@" ({_appStoreInfo.PriceOverview.DiscountPercent}% off - was {_appStoreInfo.PriceOverview.InitialFormatted})";
                }
            }

            label2.Text += _appStoreInfo.ReleaseDate.Date;
            
            label3.Text = @"Metacritic score ";
            if (_appStoreInfo.Metacritic == null)
            {
                label3.Text += @"not available";
            }
            else
            {
                label3.Text += $@"{_appStoreInfo.Metacritic.Score}/100";
            }

            if (_applicationData.IsUsernameSet())
            {
                if (_applicationData.PlayerDetails.OwnsGame(_appId))
                {
                    labelOwnedGame.Text = @"You already own this game";
                    labelOwnedGame.ForeColor = Color.Green;
                }
                else
                {
                    labelOwnedGame.Text = @"You don't own this game";
                    labelOwnedGame.ForeColor = Color.DarkRed;
                }
            }
            else
            {
                labelOwnedGame.Text = @"You are currently not logged in";
                labelOwnedGame.ForeColor = Color.Gray;
            }

            
        }

        private void storeButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(ApplicationConstants.SteamStoreAppPrefix + _appId);
        }

        private void FormAppInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}