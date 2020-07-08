﻿using System.ComponentModel;

namespace steam_sharp
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.storeAppsPerm = new System.Windows.Forms.CheckBox();
            this.storeIndivAppsPerm = new System.Windows.Forms.CheckBox();
            this.textBoxApi = new System.Windows.Forms.TextBox();
            this.labelApi = new System.Windows.Forms.Label();
            this.buttonUpdateApi = new System.Windows.Forms.Button();
            this.checkBoxSaveAPI = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // storeAppsPerm
            // 
            this.storeAppsPerm.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.storeAppsPerm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.storeAppsPerm.Location = new System.Drawing.Point(24, 139);
            this.storeAppsPerm.Name = "storeAppsPerm";
            this.storeAppsPerm.Size = new System.Drawing.Size(280, 46);
            this.storeAppsPerm.TabIndex = 0;
            this.storeAppsPerm.Text = "Use local storage for apps";
            this.storeAppsPerm.UseVisualStyleBackColor = true;
            this.storeAppsPerm.CheckedChanged += new System.EventHandler(this.storeAppsPerm_CheckedChanged);
            // 
            // storeIndivAppsPerm
            // 
            this.storeIndivAppsPerm.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.storeIndivAppsPerm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.storeIndivAppsPerm.Location = new System.Drawing.Point(24, 191);
            this.storeIndivAppsPerm.Name = "storeIndivAppsPerm";
            this.storeIndivAppsPerm.Size = new System.Drawing.Size(280, 46);
            this.storeIndivAppsPerm.TabIndex = 1;
            this.storeIndivAppsPerm.Text = "Store all individual app data";
            this.storeIndivAppsPerm.UseVisualStyleBackColor = true;
            this.storeIndivAppsPerm.CheckedChanged += new System.EventHandler(this.storeIndivAppsPerm_CheckedChanged);
            // 
            // textBoxApi
            // 
            this.textBoxApi.Location = new System.Drawing.Point(12, 31);
            this.textBoxApi.Name = "textBoxApi";
            this.textBoxApi.Size = new System.Drawing.Size(310, 22);
            this.textBoxApi.TabIndex = 2;
            // 
            // labelApi
            // 
            this.labelApi.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.labelApi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelApi.Location = new System.Drawing.Point(13, 3);
            this.labelApi.Name = "labelApi";
            this.labelApi.Size = new System.Drawing.Size(291, 23);
            this.labelApi.TabIndex = 3;
            this.labelApi.Text = "API Key";
            // 
            // buttonUpdateApi
            // 
            this.buttonUpdateApi.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (23)))), ((int) (((byte) (26)))), ((int) (((byte) (33)))));
            this.buttonUpdateApi.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonUpdateApi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUpdateApi.Location = new System.Drawing.Point(40, 86);
            this.buttonUpdateApi.Name = "buttonUpdateApi";
            this.buttonUpdateApi.Size = new System.Drawing.Size(264, 38);
            this.buttonUpdateApi.TabIndex = 4;
            this.buttonUpdateApi.Text = "Update API Key";
            this.buttonUpdateApi.UseVisualStyleBackColor = false;
            this.buttonUpdateApi.Click += new System.EventHandler(this.buttonUpdateApi_Click);
            // 
            // checkBoxSaveAPI
            // 
            this.checkBoxSaveAPI.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.checkBoxSaveAPI.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxSaveAPI.Location = new System.Drawing.Point(14, 56);
            this.checkBoxSaveAPI.Name = "checkBoxSaveAPI";
            this.checkBoxSaveAPI.Size = new System.Drawing.Size(290, 24);
            this.checkBoxSaveAPI.TabIndex = 5;
            this.checkBoxSaveAPI.Text = "Save API Key for later use";
            this.checkBoxSaveAPI.UseVisualStyleBackColor = true;
            this.checkBoxSaveAPI.CheckedChanged += new System.EventHandler(this.checkBoxSaveAPI_CheckedChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (27)))), ((int) (((byte) (40)))), ((int) (((byte) (56)))));
            this.ClientSize = new System.Drawing.Size(331, 249);
            this.Controls.Add(this.checkBoxSaveAPI);
            this.Controls.Add(this.buttonUpdateApi);
            this.Controls.Add(this.labelApi);
            this.Controls.Add(this.textBoxApi);
            this.Controls.Add(this.storeIndivAppsPerm);
            this.Controls.Add(this.storeAppsPerm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.Text = "Steam-Sharp: Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button buttonUpdateApi;
        private System.Windows.Forms.CheckBox checkBoxSaveAPI;
        private System.Windows.Forms.Label labelApi;
        private System.Windows.Forms.CheckBox storeAppsPerm;
        private System.Windows.Forms.CheckBox storeIndivAppsPerm;
        private System.Windows.Forms.TextBox textBoxApi;

        #endregion
    }
}