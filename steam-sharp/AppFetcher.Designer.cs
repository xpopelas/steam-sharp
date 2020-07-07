using System.ComponentModel;

namespace steam_sharp
{
    partial class AppFetcher
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.appIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchInfoLabel1 = new System.Windows.Forms.Label();
            this.gridSelectionDown = new System.Windows.Forms.Button();
            this.gridSelectionUp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.textBox1.Location = new System.Drawing.Point(5, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(870, 27);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(337, 53);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search For All Apps";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.appIdCol, this.appNameCol});
            this.dataGridView1.Location = new System.Drawing.Point(6, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(869, 479);
            this.dataGridView1.TabIndex = 4;
            // 
            // appIdCol
            // 
            this.appIdCol.HeaderText = "App ID";
            this.appIdCol.Name = "appIdCol";
            this.appIdCol.ReadOnly = true;
            // 
            // appNameCol
            // 
            this.appNameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.appNameCol.HeaderText = "Application Name";
            this.appNameCol.Name = "appNameCol";
            this.appNameCol.ReadOnly = true;
            // 
            // searchInfoLabel1
            // 
            this.searchInfoLabel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.searchInfoLabel1.Location = new System.Drawing.Point(10, 91);
            this.searchInfoLabel1.Name = "searchInfoLabel1";
            this.searchInfoLabel1.Size = new System.Drawing.Size(864, 30);
            this.searchInfoLabel1.TabIndex = 5;
            // 
            // gridSelectionDown
            // 
            this.gridSelectionDown.Location = new System.Drawing.Point(9, 609);
            this.gridSelectionDown.Name = "gridSelectionDown";
            this.gridSelectionDown.Size = new System.Drawing.Size(65, 33);
            this.gridSelectionDown.TabIndex = 6;
            this.gridSelectionDown.Text = "<";
            this.gridSelectionDown.UseVisualStyleBackColor = true;
            this.gridSelectionDown.Click += new System.EventHandler(this.gridSelectionDown_Click);
            // 
            // gridSelectionUp
            // 
            this.gridSelectionUp.Location = new System.Drawing.Point(80, 609);
            this.gridSelectionUp.Name = "gridSelectionUp";
            this.gridSelectionUp.Size = new System.Drawing.Size(66, 33);
            this.gridSelectionUp.TabIndex = 7;
            this.gridSelectionUp.Text = ">";
            this.gridSelectionUp.UseVisualStyleBackColor = true;
            this.gridSelectionUp.Click += new System.EventHandler(this.gridSelectionUp_Click);
            // 
            // AppFetcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (27)))), ((int) (((byte) (40)))), ((int) (((byte) (56)))));
            this.ClientSize = new System.Drawing.Size(879, 651);
            this.Controls.Add(this.gridSelectionUp);
            this.Controls.Add(this.gridSelectionDown);
            this.Controls.Add(this.searchInfoLabel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "AppFetcher";
            this.Text = "Steam-Sharp: App Fetcher";
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridViewTextBoxColumn appIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn appNameCol;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button gridSelectionDown;
        private System.Windows.Forms.Button gridSelectionUp;
        private System.Windows.Forms.Label searchInfoLabel1;
        private System.Windows.Forms.TextBox textBox1;

        #endregion
    }
}