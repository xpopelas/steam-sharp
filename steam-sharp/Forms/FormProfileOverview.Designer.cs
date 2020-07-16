using System.ComponentModel;

namespace steam_sharp.Forms
{
    partial class FormProfileOverview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProfileOverview));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelNickname = new System.Windows.Forms.Label();
            this.labelRealName = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelSteamID = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.labelGamesOwned = new System.Windows.Forms.Label();
            this.labelFriendsCount = new System.Windows.Forms.Label();
            this.buttonSteamWebProfile = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.steamIdFriend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.friendName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(5, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelNickname
            // 
            this.labelNickname.BackColor = System.Drawing.Color.Transparent;
            this.labelNickname.Font = new System.Drawing.Font("Montserrat SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.labelNickname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNickname.Location = new System.Drawing.Point(139, 3);
            this.labelNickname.Name = "labelNickname";
            this.labelNickname.Size = new System.Drawing.Size(220, 35);
            this.labelNickname.TabIndex = 1;
            this.labelNickname.Text = "Username";
            // 
            // labelRealName
            // 
            this.labelRealName.BackColor = System.Drawing.Color.Transparent;
            this.labelRealName.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.labelRealName.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelRealName.Location = new System.Drawing.Point(139, 38);
            this.labelRealName.Name = "labelRealName";
            this.labelRealName.Size = new System.Drawing.Size(220, 35);
            this.labelRealName.TabIndex = 2;
            this.labelRealName.Text = "Real Name";
            // 
            // labelStatus
            // 
            this.labelStatus.BackColor = System.Drawing.Color.Transparent;
            this.labelStatus.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.labelStatus.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelStatus.Location = new System.Drawing.Point(139, 73);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(268, 61);
            this.labelStatus.TabIndex = 3;
            this.labelStatus.Text = "Status";
            // 
            // labelSteamID
            // 
            this.labelSteamID.BackColor = System.Drawing.Color.Transparent;
            this.labelSteamID.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.labelSteamID.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelSteamID.Location = new System.Drawing.Point(5, 172);
            this.labelSteamID.Name = "labelSteamID";
            this.labelSteamID.Size = new System.Drawing.Size(402, 35);
            this.labelSteamID.TabIndex = 4;
            this.labelSteamID.Text = "Steam ID: 1234";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(5, 137);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(128, 32);
            this.buttonRefresh.TabIndex = 6;
            this.buttonRefresh.Text = "Refresh Data";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // labelGamesOwned
            // 
            this.labelGamesOwned.BackColor = System.Drawing.Color.Transparent;
            this.labelGamesOwned.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.labelGamesOwned.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelGamesOwned.Location = new System.Drawing.Point(5, 207);
            this.labelGamesOwned.Name = "labelGamesOwned";
            this.labelGamesOwned.Size = new System.Drawing.Size(402, 35);
            this.labelGamesOwned.TabIndex = 7;
            this.labelGamesOwned.Text = "Games owned";
            // 
            // labelFriendsCount
            // 
            this.labelFriendsCount.BackColor = System.Drawing.Color.Transparent;
            this.labelFriendsCount.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.labelFriendsCount.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelFriendsCount.Location = new System.Drawing.Point(5, 242);
            this.labelFriendsCount.Name = "labelFriendsCount";
            this.labelFriendsCount.Size = new System.Drawing.Size(402, 35);
            this.labelFriendsCount.TabIndex = 8;
            this.labelFriendsCount.Text = "Number of friends";
            // 
            // buttonSteamWebProfile
            // 
            this.buttonSteamWebProfile.Location = new System.Drawing.Point(139, 137);
            this.buttonSteamWebProfile.Name = "buttonSteamWebProfile";
            this.buttonSteamWebProfile.Size = new System.Drawing.Size(166, 32);
            this.buttonSteamWebProfile.TabIndex = 9;
            this.buttonSteamWebProfile.Text = "Go To Steam Profile";
            this.buttonSteamWebProfile.UseVisualStyleBackColor = true;
            this.buttonSteamWebProfile.Click += new System.EventHandler(this.buttonSteamWebProfile_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.steamIdFriend, this.friendName});
            this.dataGridView1.Location = new System.Drawing.Point(4, 273);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(411, 395);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // steamIdFriend
            // 
            this.steamIdFriend.HeaderText = "Steam ID";
            this.steamIdFriend.Name = "steamIdFriend";
            this.steamIdFriend.ReadOnly = true;
            this.steamIdFriend.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // friendName
            // 
            this.friendName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.friendName.HeaderText = "Name";
            this.friendName.Name = "friendName";
            this.friendName.ReadOnly = true;
            this.friendName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // FormProfileOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (27)))), ((int) (((byte) (40)))), ((int) (((byte) (56)))));
            this.ClientSize = new System.Drawing.Size(416, 673);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonSteamWebProfile);
            this.Controls.Add(this.labelFriendsCount);
            this.Controls.Add(this.labelGamesOwned);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.labelSteamID);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelRealName);
            this.Controls.Add(this.labelNickname);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "FormProfileOverview";
            this.Text = "Steam-Sharp: Profile";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormProfileOverview_FormClosing);
            this.Shown += new System.EventHandler(this.FormProfileOverview_Shown);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonSteamWebProfile;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn friendName;
        private System.Windows.Forms.Label labelFriendsCount;
        private System.Windows.Forms.Label labelGamesOwned;
        private System.Windows.Forms.Label labelNickname;
        private System.Windows.Forms.Label labelRealName;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelSteamID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn steamIdFriend;

        #endregion
    }
}