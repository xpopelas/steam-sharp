using System.ComponentModel;
using System.Windows.Forms.DataVisualization.Charting;

namespace steam_sharp.Forms
{
    partial class FormAppInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAppInfo));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelAppTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.storeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(592, 277);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelAppTitle
            // 
            this.labelAppTitle.Font = new System.Drawing.Font("Montserrat", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.labelAppTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelAppTitle.Location = new System.Drawing.Point(0, 286);
            this.labelAppTitle.Name = "labelAppTitle";
            this.labelAppTitle.Size = new System.Drawing.Size(592, 37);
            this.labelAppTitle.TabIndex = 1;
            this.labelAppTitle.Text = "app Title: continuation on line";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Price";
            // 
            // storeButton
            // 
            this.storeButton.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (23)))), ((int) (((byte) (26)))), ((int) (((byte) (33)))));
            this.storeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.storeButton.FlatAppearance.BorderSize = 0;
            this.storeButton.Font = new System.Drawing.Font("Montserrat ExtraBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.storeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.storeButton.Location = new System.Drawing.Point(457, 323);
            this.storeButton.Margin = new System.Windows.Forms.Padding(0);
            this.storeButton.Name = "storeButton";
            this.storeButton.Size = new System.Drawing.Size(129, 41);
            this.storeButton.TabIndex = 4;
            this.storeButton.Text = "Go to store";
            this.storeButton.UseVisualStyleBackColor = false;
            this.storeButton.Click += new System.EventHandler(this.storeButton_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(0, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(474, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "Release date: ";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(0, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(474, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "Release date: ";
            // 
            // FormAppInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (27)))), ((int) (((byte) (40)))), ((int) (((byte) (56)))));
            this.ClientSize = new System.Drawing.Size(595, 634);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.storeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelAppTitle);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "FormAppInfo";
            this.Text = "Steam-Sharp: ";
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelAppTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button storeButton;

        #endregion
    }
}