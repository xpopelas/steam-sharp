using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Steam.Models.SteamCommunity;

namespace steam_sharp.Forms
{
    public partial class FormProfileOverview : Form
    {
        private ApplicationDataClass _applicationData;
        private ApplicationPlayerDetails _currentPlayerProfile;
        public FormProfileOverview(ApplicationDataClass applicationData)
        {
            _applicationData = applicationData;
            _currentPlayerProfile = applicationData.PlayerDetails;

            InitializeComponent();
        }

        private FormProfileOverview(ApplicationDataClass applicationData, ApplicationPlayerDetails currentPlayer)
        {
            _applicationData = applicationData;
            _currentPlayerProfile = currentPlayer;

            InitializeComponent();
        }

        private void FormProfileOverview_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void SetStatusRelatedDetails()
        {
            // For some reason, steamAPI SOMETIMES doesn't set correct user status when in game
            // So I have to do it manually ... *sigh*
            if (_currentPlayerProfile.PlayerProfile.PlayingGameName != null)
            {
                _currentPlayerProfile.PlayerProfile.UserStatus = UserStatus.InGame;
            }
            
            switch (_currentPlayerProfile.PlayerProfile.UserStatus)
            {
                case UserStatus.InGame:
                {
                    labelStatus.ForeColor = ApplicationConstants.ColorStatusInGame;
                    labelNickname.ForeColor = ApplicationConstants.ColorNicknameInGame;
                    labelStatus.Text = $@"(in-game - {_currentPlayerProfile.PlayerProfile.PlayingGameName})";
                    break;
                }
                case UserStatus.Away:
                {
                    labelStatus.ForeColor = ApplicationConstants.ColorStatusAway;
                    labelNickname.ForeColor = ApplicationConstants.ColorNicknameAway;
                    labelStatus.Text = @"(away)";
                    break;
                }
                case UserStatus.Online:
                {
                    labelStatus.ForeColor = ApplicationConstants.ColorStatusOnline;
                    labelNickname.ForeColor = ApplicationConstants.ColorNicknameOnline;
                    labelStatus.Text = @"(online)";
                    break;
                }
                case UserStatus.Offline:
                {
                    labelStatus.ForeColor = ApplicationConstants.ColorStatusOffline;
                    labelNickname.ForeColor = ApplicationConstants.ColorNicknameOffline;
                    labelStatus.Text = $@"(offline - last logged in {_currentPlayerProfile.PlayerProfile.LastLoggedOffDate})";
                    break;
                }
                case UserStatus.Busy:
                {
                    labelStatus.ForeColor = ApplicationConstants.ColorStatusOnline;
                    labelNickname.ForeColor = ApplicationConstants.ColorNicknameOnline;
                    labelStatus.Text = @"(busy)";
                    break;
                }
                case UserStatus.Snooze:
                {
                    labelStatus.ForeColor = ApplicationConstants.ColorStatusOnline;
                    labelNickname.ForeColor = ApplicationConstants.ColorNicknameOnline;
                    labelStatus.Text = @"(snooze)";
                    break;
                }
                default:
                {
                    labelStatus.ForeColor = ApplicationConstants.ColorStatusOffline;
                    labelNickname.ForeColor = ApplicationConstants.ColorNicknameOffline;
                    labelStatus.Text = @"(unknown status)";
                    break;
                }

            }
        }

        private async void ShowProfileDetails()
        {
            pictureBox1.ImageLocation = _currentPlayerProfile.PlayerProfile.AvatarFullUrl;
            labelNickname.Text = _currentPlayerProfile.PlayerProfile.Nickname;
            labelRealName.Text = _currentPlayerProfile.PlayerProfile.RealName;
            labelSteamID.Text = $@"Steam ID: {_currentPlayerProfile.PlayerProfile.SteamId}";
            labelGamesOwned.Text = $@"Total of {_currentPlayerProfile.OwnedGames.GameCount} games owned";
            labelFriendsCount.Text = _currentPlayerProfile.SteamId == _applicationData.PlayerDetails.SteamId ? @"You have " : @"This person has ";
            labelFriendsCount.Text += $@"{_currentPlayerProfile.Friends.Count} friend";
            if (_currentPlayerProfile.Friends.Count != 1)
            {
                labelFriendsCount.Text += @"s";
            }
            
            SetStatusRelatedDetails();

            dataGridView1.Rows.Clear();
            foreach (ulong friendId in _currentPlayerProfile.Friends)
            {
                object[] toDisplay = {friendId.ToString(), await _applicationData.GetUserNickByIdAsync(friendId)};
                dataGridView1.Rows.Add(toDisplay);
            }

        }

        private void FormProfileOverview_Shown(object sender, EventArgs e)
        {
            ShowProfileDetails();
        }

        private async void buttonRefresh_Click(object sender, EventArgs e)
        {
            await _applicationData.GetUserByIdAsync(_currentPlayerProfile.SteamId, _currentPlayerProfile);
            ShowProfileDetails();
        }

        private void buttonSteamWebProfile_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(_currentPlayerProfile.PlayerProfile.ProfileUrl);
        }

        private async void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            ulong friendsId = _currentPlayerProfile.Friends[dataGridView1.CurrentCell.RowIndex];
            ApplicationPlayerDetails friendDetails = new ApplicationPlayerDetails();

            if (!await _applicationData.GetUserByIdAsync(friendsId, friendDetails))
            {
                ApplicationConstants.MessageUserNotFound();
                return;
            }
            
            var friendsProfile = new FormProfileOverview(_applicationData, friendDetails);
            friendsProfile.Show();
        }
    }
}