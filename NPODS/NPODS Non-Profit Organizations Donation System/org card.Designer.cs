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
            this.organization1 = new NPODS_Non_Profit_Organizations_Donation_System.OrganizationCard();
            this.organization2 = new NPODS_Non_Profit_Organizations_Donation_System.OrganizationCard();
            this.organization3 = new NPODS_Non_Profit_Organizations_Donation_System.OrganizationCard();
            this.organization4 = new NPODS_Non_Profit_Organizations_Donation_System.OrganizationCard();
            this.SuspendLayout();
            // 
            // organization1
            // 
            this.organization1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.organization1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.organization1.Location = new System.Drawing.Point(172, 71);
            this.organization1.Name = "organization1";
            this.organization1.Size = new System.Drawing.Size(1275, 349);
            this.organization1.TabIndex = 0;
            this.organization1.Load += new System.EventHandler(this.Organization1_Load);
            // 
            // organization2
            // 
            this.organization2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.organization2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.organization2.Location = new System.Drawing.Point(172, 470);
            this.organization2.Name = "organization2";
            this.organization2.Size = new System.Drawing.Size(1276, 349);
            this.organization2.TabIndex = 1;
            this.organization2.Load += new System.EventHandler(this.Organization2_Load);
            // 
            // organization3
            // 
            this.organization3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.organization3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.organization3.Location = new System.Drawing.Point(172, 867);
            this.organization3.Name = "organization3";
            this.organization3.Size = new System.Drawing.Size(1276, 349);
            this.organization3.TabIndex = 2;
            this.organization3.Load += new System.EventHandler(this.Organization3_Load_1);
            // 
            // organization4
            // 
            this.organization4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.organization4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.organization4.Location = new System.Drawing.Point(172, 1275);
            this.organization4.Name = "organization4";
            this.organization4.Size = new System.Drawing.Size(1276, 349);
            this.organization4.TabIndex = 3;
            this.organization4.Load += new System.EventHandler(this.Organization4_Load_1);
            // 
            // org_card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.organization4);
            this.Controls.Add(this.organization3);
            this.Controls.Add(this.organization2);
            this.Controls.Add(this.organization1);
            this.Name = "org_card";
            this.Size = new System.Drawing.Size(1564, 626);
            this.Load += new System.EventHandler(this.Org_card_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private OrganizationCard organization1;
        private OrganizationCard organization2;
        private OrganizationCard organization3;
        private OrganizationCard organization4;
    }
}
