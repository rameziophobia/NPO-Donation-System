namespace NPODS_Non_Profit_Organizations_Donation_System
{
    partial class Form2
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
            this.organization3 = new NPODS_Non_Profit_Organizations_Donation_System.Organization();
            this.organization2 = new NPODS_Non_Profit_Organizations_Donation_System.Organization();
            this.organization1 = new NPODS_Non_Profit_Organizations_Donation_System.Organization();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // organization3
            // 
            this.organization3.AutoSize = true;
            this.organization3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.organization3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.organization3.Location = new System.Drawing.Point(494, 855);
            this.organization3.Name = "organization3";
            this.organization3.Size = new System.Drawing.Size(754, 345);
            this.organization3.TabIndex = 3;
            // 
            // organization2
            // 
            this.organization2.AutoSize = true;
            this.organization2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.organization2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.organization2.Location = new System.Drawing.Point(494, 458);
            this.organization2.Name = "organization2";
            this.organization2.Size = new System.Drawing.Size(754, 345);
            this.organization2.TabIndex = 2;
            // 
            // organization1
            // 
            this.organization1.AutoSize = true;
            this.organization1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.organization1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.organization1.Location = new System.Drawing.Point(494, 91);
            this.organization1.Name = "organization1";
            this.organization1.Size = new System.Drawing.Size(754, 345);
            this.organization1.TabIndex = 1;
            this.organization1.Load += new System.EventHandler(this.Organization1_Load);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1742, 70);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1761, 724);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.organization3);
            this.Controls.Add(this.organization2);
            this.Controls.Add(this.organization1);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Organizatuons";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Organization organization1;
        private Organization organization2;
        private Organization organization3;
        private System.Windows.Forms.Panel panel1;
    }
}