namespace NPODS_Non_Profit_Organizations_Donation_System
{
    partial class OrganizationCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrganizationCard));
            this.OrgDesc = new System.Windows.Forms.Label();
            this.OrgName = new System.Windows.Forms.Label();
            this.OrgPic = new System.Windows.Forms.PictureBox();
            this.OrgLogo = new NPODS_Non_Profit_Organizations_Donation_System.CircularPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.OrgPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // OrgDesc
            // 
            this.OrgDesc.AutoSize = true;
            this.OrgDesc.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrgDesc.Location = new System.Drawing.Point(-1, 247);
            this.OrgDesc.Name = "OrgDesc";
            this.OrgDesc.Size = new System.Drawing.Size(748, 88);
            this.OrgDesc.TabIndex = 0;
            this.OrgDesc.Text = resources.GetString("OrgDesc.Text");
            this.OrgDesc.Click += new System.EventHandler(this.OrgDesc_Click);
            // 
            // OrgName
            // 
            this.OrgName.AutoSize = true;
            this.OrgName.Font = new System.Drawing.Font("Century Schoolbook", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrgName.Location = new System.Drawing.Point(176, 167);
            this.OrgName.Name = "OrgName";
            this.OrgName.Size = new System.Drawing.Size(205, 45);
            this.OrgName.TabIndex = 2;
            this.OrgName.Text = "org name";
            this.OrgName.Click += new System.EventHandler(this.OrgName_Click);
            // 
            // OrgPic
            // 
            this.OrgPic.Dock = System.Windows.Forms.DockStyle.Top;
            this.OrgPic.Image = global::NPODS_Non_Profit_Organizations_Donation_System.Properties.Resources.images2;
            this.OrgPic.Location = new System.Drawing.Point(0, 0);
            this.OrgPic.Name = "OrgPic";
            this.OrgPic.Size = new System.Drawing.Size(1276, 153);
            this.OrgPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OrgPic.TabIndex = 3;
            this.OrgPic.TabStop = false;
            this.OrgPic.Click += new System.EventHandler(this.OrgPic_Click);
            // 
            // OrgLogo
            // 
            this.OrgLogo.Image = global::NPODS_Non_Profit_Organizations_Donation_System.Properties.Resources.images;
            this.OrgLogo.Location = new System.Drawing.Point(25, 85);
            this.OrgLogo.Name = "OrgLogo";
            this.OrgLogo.Size = new System.Drawing.Size(117, 117);
            this.OrgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OrgLogo.TabIndex = 4;
            this.OrgLogo.TabStop = false;
            this.OrgLogo.Click += new System.EventHandler(this.OrgLogo_Click);
            // 
            // Organization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.OrgLogo);
            this.Controls.Add(this.OrgPic);
            this.Controls.Add(this.OrgName);
            this.Controls.Add(this.OrgDesc);
            this.Name = "Organization";
            this.Size = new System.Drawing.Size(1276, 349);
            this.Load += new System.EventHandler(this.Organization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrgPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label OrgDesc;
        private System.Windows.Forms.Label OrgName;
        private System.Windows.Forms.PictureBox OrgPic;
        private CircularPictureBox OrgLogo;
    }
}
