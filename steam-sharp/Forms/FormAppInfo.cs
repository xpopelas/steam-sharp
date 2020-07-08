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
            
        }
    }
}