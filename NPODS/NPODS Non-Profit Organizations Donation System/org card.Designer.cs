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
            this.organization1 = new NPODS_Non_Profit_Organizations_Donation_System.Organization();
            this.organization2 = new NPODS_Non_Profit_Organizations_Donation_System.Organization();
            this.organization3 = new NPODS_Non_Profit_Organizations_Donation_System.Organization();
            this.organization4 = new NPODS_Non_Profit_Organizations_Donation_System.Organization();
            this.SuspendLayout();
            // 
            // organization1
            // 
            this.organization1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.organization1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.organization1.Location = new System.Drawing.Point(462, 96);
            this.organization1.Name = "organization1";
            this.organization1.Size = new System.Drawing.Size(745, 349);
            this.organization1.TabIndex = 0;
            // 
            // organization2
            // 
            this.organization2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.organization2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.organization2.Location = new System.Drawing.Point(462, 482);
            this.organization2.Name = "organization2";
            this.organization2.Size = new System.Drawing.Size(745, 349);
            this.organization2.TabIndex = 1;
            // 
            // organization3
            // 
            this.organization3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.organization3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.organization3.Location = new System.Drawing.Point(462, 868);
            this.organization3.Name = "organization3";
            this.organization3.Size = new System.Drawing.Size(745, 349);
            this.organization3.TabIndex = 2;
            this.organization3.Load += new System.EventHandler(this.Organization3_Load);
            // 
            // organization4
            // 
            this.organization4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.organization4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.organization4.Location = new System.Drawing.Point(462, 1250);
            this.organization4.Name = "organization4";
            this.organization4.Size = new System.Drawing.Size(745, 349);
            this.organization4.TabIndex = 3;
            this.organization4.Load += new System.EventHandler(this.Organization4_Load);
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
            this.Size = new System.Drawing.Size(1648, 626);
            this.Load += new System.EventHandler(this.Org_card_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Organization organization1;
        private Organization organization2;
        private Organization organization3;
        private Organization organization4;
    }
}
