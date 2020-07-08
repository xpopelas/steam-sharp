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
                ApplicationConstants.AppNotAvailable();
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
        }

        private void storeButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(ApplicationConstants.SteamStoreAppPrefix + _appId);
        }
    }
}