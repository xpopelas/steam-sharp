namespace steam_sharp.Forms
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.appFetcherButton = new System.Windows.Forms.Button();
      this.settingsButton = new System.Windows.Forms.Button();
      this.buttonProfile = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // appFetcherButton
      // 
      this.appFetcherButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.appFetcherButton.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (23)))), ((int) (((byte) (26)))), ((int) (((byte) (33)))));
      this.appFetcherButton.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
      this.appFetcherButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      this.appFetcherButton.Location = new System.Drawing.Point(15, 0);
      this.appFetcherButton.Name = "appFetcherButton";
      this.appFetcherButton.Size = new System.Drawing.Size(300, 60);
      this.appFetcherButton.TabIndex = 0;
      this.appFetcherButton.Text = "App Fetcher";
      this.appFetcherButton.UseVisualStyleBackColor = false;
      this.appFetcherButton.Click += new System.EventHandler(this.appFetcherButton_Click);
      // 
      // settingsButton
      // 
      this.settingsButton.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (23)))), ((int) (((byte) (26)))), ((int) (((byte) (33)))));
      this.settingsButton.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
      this.settingsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      this.settingsButton.Location = new System.Drawing.Point(15, 237);
      this.settingsButton.Name = "settingsButton";
      this.settingsButton.Size = new System.Drawing.Size(297, 61);
      this.settingsButton.TabIndex = 1;
      this.settingsButton.Text = "Settings";
      this.settingsButton.UseVisualStyleBackColor = false;
      this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
      // 
      // buttonProfile
      // 
      this.buttonProfile.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.buttonProfile.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (23)))), ((int) (((byte) (26)))), ((int) (((byte) (33)))));
      this.buttonProfile.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
      this.buttonProfile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      this.buttonProfile.Location = new System.Drawing.Point(15, 66);
      this.buttonProfile.Name = "buttonProfile";
      this.buttonProfile.Size = new System.Drawing.Size(300, 60);
      this.buttonProfile.TabIndex = 2;
      this.buttonProfile.Text = "Profile";
      this.buttonProfile.UseVisualStyleBackColor = false;
      this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (27)))), ((int) (((byte) (40)))), ((int) (((byte) (56)))));
      this.ClientSize = new System.Drawing.Size(330, 307);
      this.Controls.Add(this.buttonProfile);
      this.Controls.Add(this.settingsButton);
      this.Controls.Add(this.appFetcherButton);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
      this.Location = new System.Drawing.Point(19, 19);
      this.Name = "Form1";
      this.Text = "Steam-Sharp";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.ResumeLayout(false);
    }

    private System.Windows.Forms.Button appFetcherButton;
    private System.Windows.Forms.Button buttonProfile;
    private System.Windows.Forms.Button settingsButton;

    #endregion
  }
}

