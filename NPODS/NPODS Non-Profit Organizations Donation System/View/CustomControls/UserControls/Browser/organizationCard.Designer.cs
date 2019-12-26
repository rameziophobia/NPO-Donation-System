using NPODS_Non_Profit_Organizations_Donation_System.View.CustomControls.Components.Browser;

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
            this.txt_orgDescription = new System.Windows.Forms.Label();
            this.txt_orgName = new System.Windows.Forms.Label();
            this.pic_orgBanner = new System.Windows.Forms.PictureBox();
            this.pic_orgLogo = new NPODS_Non_Profit_Organizations_Donation_System.View.CustomControls.Components.Browser.CircularPictureBox();
            this.btn_moreInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_orgBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_orgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_orgDescription
            // 
            this.txt_orgDescription.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_orgDescription.Location = new System.Drawing.Point(20, 142);
            this.txt_orgDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_orgDescription.Name = "txt_orgDescription";
            this.txt_orgDescription.Size = new System.Drawing.Size(722, 68);
            this.txt_orgDescription.TabIndex = 0;
            this.txt_orgDescription.Text = resources.GetString("txt_orgDescription.Text");
            // 
            // txt_orgName
            // 
            this.txt_orgName.AutoSize = true;
            this.txt_orgName.Font = new System.Drawing.Font("Century Gothic", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_orgName.Location = new System.Drawing.Point(131, 102);
            this.txt_orgName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_orgName.Name = "txt_orgName";
            this.txt_orgName.Size = new System.Drawing.Size(164, 37);
            this.txt_orgName.TabIndex = 2;
            this.txt_orgName.Text = "org name";
            // 
            // pic_orgBanner
            // 
            this.pic_orgBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.pic_orgBanner.Image = global::NPODS_Non_Profit_Organizations_Donation_System.Properties.Resources.images2;
            this.pic_orgBanner.Location = new System.Drawing.Point(0, 0);
            this.pic_orgBanner.Margin = new System.Windows.Forms.Padding(2);
            this.pic_orgBanner.Name = "pic_orgBanner";
            this.pic_orgBanner.Size = new System.Drawing.Size(959, 99);
            this.pic_orgBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_orgBanner.TabIndex = 4;
            this.pic_orgBanner.TabStop = false;
            // 
            // pic_orgLogo
            // 
            this.pic_orgLogo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pic_orgLogo.Image = global::NPODS_Non_Profit_Organizations_Donation_System.Properties.Resources._212;
            this.pic_orgLogo.Location = new System.Drawing.Point(24, 51);
            this.pic_orgLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pic_orgLogo.Name = "pic_orgLogo";
            this.pic_orgLogo.Size = new System.Drawing.Size(88, 85);
            this.pic_orgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_orgLogo.TabIndex = 3;
            this.pic_orgLogo.TabStop = false;
            // 
            // btn_moreInfo
            // 
            this.btn_moreInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(214)))), ((int)(((byte)(223)))));
            this.btn_moreInfo.FlatAppearance.BorderSize = 0;
            this.btn_moreInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_moreInfo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_moreInfo.Location = new System.Drawing.Point(774, 132);
            this.btn_moreInfo.Name = "btn_moreInfo";
            this.btn_moreInfo.Size = new System.Drawing.Size(165, 68);
            this.btn_moreInfo.TabIndex = 5;
            this.btn_moreInfo.Text = "More Information";
            this.btn_moreInfo.UseVisualStyleBackColor = false;
            // 
            // OrganizationCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btn_moreInfo);
            this.Controls.Add(this.pic_orgLogo);
            this.Controls.Add(this.pic_orgBanner);
            this.Controls.Add(this.txt_orgName);
            this.Controls.Add(this.txt_orgDescription);
            this.Margin = new System.Windows.Forms.Padding(35, 20, 20, 20);
            this.Name = "OrganizationCard";
            this.Size = new System.Drawing.Size(959, 221);
            ((System.ComponentModel.ISupportInitialize)(this.pic_orgBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_orgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txt_orgDescription;
        private System.Windows.Forms.Label txt_orgName;
        private CircularPictureBox pic_orgLogo;
        private System.Windows.Forms.PictureBox pic_orgBanner;
        private System.Windows.Forms.Button btn_moreInfo;   
    }
}
