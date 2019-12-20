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
            this.editDonationOptions1 = new NPODS_Non_Profit_Organizations_Donation_System.editDonationOptions();
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
            // editDonationOptions1
            // 
            this.editDonationOptions1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editDonationOptions1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editDonationOptions1.Location = new System.Drawing.Point(0, 65);
            this.editDonationOptions1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editDonationOptions1.Name = "editDonationOptions1";
            this.editDonationOptions1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.editDonationOptions1.Size = new System.Drawing.Size(1136, 559);
            this.editDonationOptions1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 624);
            this.Controls.Add(this.editDonationOptions1);
            this.Controls.Add(this.headerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NPODS";
            this.ResumeLayout(false);

        }

        #endregion

        private HeaderControl headerControl1;
        private editDonationOptions editDonationOptions1;
    }
}

