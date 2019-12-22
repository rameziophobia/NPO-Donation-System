namespace NPODS_Non_Profit_Organizations_Donation_System
{
    partial class org_card
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.organization4 = new NPODS_Non_Profit_Organizations_Donation_System.Organization();
            this.organization3 = new NPODS_Non_Profit_Organizations_Donation_System.Organization();
            this.organization2 = new NPODS_Non_Profit_Organizations_Donation_System.Organization();
            this.organization1 = new NPODS_Non_Profit_Organizations_Donation_System.Organization();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1731, 48);
            this.panel1.TabIndex = 5;
            // 
            // organization4
            // 
            this.organization4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.organization4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.organization4.Location = new System.Drawing.Point(71, 1289);
            this.organization4.Name = "organization4";
            this.organization4.Size = new System.Drawing.Size(1604, 349);
            this.organization4.TabIndex = 3;
            this.organization4.Load += new System.EventHandler(this.Organization4_Load);
            // 
            // organization3
            // 
            this.organization3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.organization3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.organization3.Location = new System.Drawing.Point(71, 895);
            this.organization3.Name = "organization3";
            this.organization3.Size = new System.Drawing.Size(1604, 349);
            this.organization3.TabIndex = 2;
            this.organization3.Load += new System.EventHandler(this.Organization3_Load);
            // 
            // organization2
            // 
            this.organization2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.organization2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.organization2.Location = new System.Drawing.Point(71, 495);
            this.organization2.Name = "organization2";
            this.organization2.Size = new System.Drawing.Size(1604, 349);
            this.organization2.TabIndex = 1;
            this.organization2.Load += new System.EventHandler(this.Organization2_Load);
            // 
            // organization1
            // 
            this.organization1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.organization1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.organization1.Location = new System.Drawing.Point(71, 96);
            this.organization1.Name = "organization1";
            this.organization1.Size = new System.Drawing.Size(1604, 349);
            this.organization1.TabIndex = 0;
            this.organization1.Load += new System.EventHandler(this.Organization1_Load);
            // 
            // org_card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.organization4);
            this.Controls.Add(this.organization3);
            this.Controls.Add(this.organization2);
            this.Controls.Add(this.organization1);
            this.Name = "org_card";
            this.Size = new System.Drawing.Size(1731, 718);
            this.Load += new System.EventHandler(this.Org_card_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Organization organization1;
        private Organization organization2;
        private Organization organization3;
        private Organization organization4;
        private System.Windows.Forms.Panel panel1;
    }
}
