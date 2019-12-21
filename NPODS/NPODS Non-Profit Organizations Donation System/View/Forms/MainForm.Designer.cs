namespace NPODS_Non_Profit_Organizations_Donation_System
{
    partial class MainForm
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
            this.headerControl1 = new NPODS_Non_Profit_Organizations_Donation_System.HeaderControl();
            this.chooseDonationOption1 = new NPODS_Non_Profit_Organizations_Donation_System.chooseDonationOption();
            this.SuspendLayout();
            // 
            // headerControl1
            // 
            this.headerControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(214)))), ((int)(((byte)(223)))));
            this.headerControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerControl1.Location = new System.Drawing.Point(0, 0);
            this.headerControl1.Name = "headerControl1";
            this.headerControl1.Size = new System.Drawing.Size(1136, 65);
            this.headerControl1.TabIndex = 0;
            // 
            // chooseDonationOption1
            // 
            this.chooseDonationOption1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chooseDonationOption1.Location = new System.Drawing.Point(0, 65);
            this.chooseDonationOption1.Name = "chooseDonationOption1";
            this.chooseDonationOption1.Size = new System.Drawing.Size(1136, 559);
            this.chooseDonationOption1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 624);
            this.Controls.Add(this.chooseDonationOption1);
            this.Controls.Add(this.headerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NPODS";
            this.ResumeLayout(false);

        }

        #endregion

        private HeaderControl headerControl1;
        private chooseDonationOption chooseDonationOption1;
    }
}

