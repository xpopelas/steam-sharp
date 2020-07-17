using System.ComponentModel;

namespace steam_sharp.Forms
{
    partial class FormAppFetcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAppFetcher));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.appIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchInfoLabel1 = new System.Windows.Forms.Label();
            this.gridSelectionDown = new System.Windows.Forms.Button();
            this.gridSelectionUp = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelAppId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.textBox1.Location = new System.Drawing.Point(10, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(835, 27);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (23)))), ((int) (((byte) (26)))), ((int) (((byte) (33)))));
            this.button1.Font = new System.Drawing.Font("Montserrat Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(9, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(836, 53);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search For All Apps";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int) (((byte) (27)))), ((int) (((byte) (40)))), ((int) (((byte) (56)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.appIdCol, this.appNameCol});
            this.dataGridView1.Location = new System.Drawing.Point(9, 124);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(836, 442);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // appIdCol
            // 
            this.appIdCol.HeaderText = "App ID";
            this.appIdCol.Name = "appIdCol";
            this.appIdCol.ReadOnly = true;
            this.appIdCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // appNameCol
            // 
            this.appNameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.appNameCol.HeaderText = "Application Name";
            this.appNameCol.Name = "appNameCol";
            this.appNameCol.ReadOnly = true;
            this.appNameCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // searchInfoLabel1
            // 
            this.searchInfoLabel1.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.searchInfoLabel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.searchInfoLabel1.Location = new System.Drawing.Point(10, 91);
            this.searchInfoLabel1.Name = "searchInfoLabel1";
            this.searchInfoLabel1.Size = new System.Drawing.Size(864, 30);
            this.searchInfoLabel1.TabIndex = 5;
            // 
            // gridSelectionDown
            // 
            this.gridSelectionDown.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (23)))), ((int) (((byte) (26)))), ((int) (((byte) (33)))));
            this.gridSelectionDown.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.gridSelectionDown.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridSelectionDown.Location = new System.Drawing.Point(10, 570);
            this.gridSelectionDown.Name = "gridSelectionDown";
            this.gridSelectionDown.Size = new System.Drawing.Size(65, 33);
            this.gridSelectionDown.TabIndex = 6;
            this.gridSelectionDown.Text = "<";
            this.gridSelectionDown.UseVisualStyleBackColor = false;
            this.gridSelectionDown.Click += new System.EventHandler(this.gridSelectionDown_Click);
            // 
            // gridSelectionUp
            // 
            this.gridSelectionUp.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (23)))), ((int) (((byte) (26)))), ((int) (((byte) (33)))));
            this.gridSelectionUp.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.gridSelectionUp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridSelectionUp.Location = new System.Drawing.Point(81, 570);
            this.gridSelectionUp.Name = "gridSelectionUp";
            this.gridSelectionUp.Size = new System.Drawing.Size(66, 33);
            this.gridSelectionUp.TabIndex = 7;
            this.gridSelectionUp.Text = ">";
            this.gridSelectionUp.UseVisualStyleBackColor = false;
            this.gridSelectionUp.Click += new System.EventHandler(this.gridSelectionUp_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (23)))), ((int) (((byte) (26)))), ((int) (((byte) (33)))));
            this.button2.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(534, 570);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(311, 33);
            this.button2.TabIndex = 8;
            this.button2.Text = "Go To App";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelAppId
            // 
            this.labelAppId.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.labelAppId.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelAppId.Location = new System.Drawing.Point(169, 569);
            this.labelAppId.Name = "labelAppId";
            this.labelAppId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelAppId.Size = new System.Drawing.Size(359, 33);
            this.labelAppId.TabIndex = 9;
            // 
            // FormAppFetcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (27)))), ((int) (((byte) (40)))), ((int) (((byte) (56)))));
            this.ClientSize = new System.Drawing.Size(847, 606);
            this.Controls.Add(this.labelAppId);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.gridSelectionUp);
            this.Controls.Add(this.gridSelectionDown);
            this.Controls.Add(this.searchInfoLabel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "FormAppFetcher";
            this.Text = "Steam-Sharp: App Fetcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AppFetcher_FormClosing);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridViewTextBoxColumn appIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn appNameCol;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button gridSelectionDown;
        private System.Windows.Forms.Button gridSelectionUp;
        private System.Windows.Forms.Label labelAppId;
        private System.Windows.Forms.Label searchInfoLabel1;
        private System.Windows.Forms.TextBox textBox1;

        #endregion
    }
}