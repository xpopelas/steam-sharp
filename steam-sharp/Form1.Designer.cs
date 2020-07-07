using System.Drawing;

namespace steam_sharp
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
      this.button1 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.button1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (23)))), ((int) (((byte) (26)))), ((int) (((byte) (33)))));
      this.button1.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
      this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      this.button1.Location = new System.Drawing.Point(15, 0);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(300, 60);
      this.button1.TabIndex = 0;
      this.button1.Text = "App Fetcher";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (27)))), ((int) (((byte) (40)))), ((int) (((byte) (56)))));
      this.ClientSize = new System.Drawing.Size(330, 600);
      this.Controls.Add(this.button1);
      this.Name = "Form1";
      this.Text = "Steam-Sharp";
      this.ResumeLayout(false);
    }

    private System.Windows.Forms.Button button1;

    #endregion
  }
}

