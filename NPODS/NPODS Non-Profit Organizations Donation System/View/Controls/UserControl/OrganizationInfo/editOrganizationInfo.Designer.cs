namespace NPODS_Non_Profit_Organizations_Donation_System
{
    partial class editOrganizationInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editOrganizationInfo));
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_goalAmount = new System.Windows.Forms.TextBox();
            this.lbl_goalTxt2 = new System.Windows.Forms.Label();
            this.rtb_orgDescription = new System.Windows.Forms.RichTextBox();
            this.lbl_donated = new System.Windows.Forms.Label();
            this.lbl_goalTxt = new System.Windows.Forms.Label();
            this.pbr_goal = new System.Windows.Forms.ProgressBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.pnl_changePhoto = new System.Windows.Forms.Panel();
            this.btn_rmvPhoto = new System.Windows.Forms.Button();
            this.btn_uploadPhoto = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_changeDonateOpt = new System.Windows.Forms.Button();
            this.pic_orgLogo = new System.Windows.Forms.PictureBox();
            this.file_chooseImage = new System.Windows.Forms.OpenFileDialog();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnl_changePhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_orgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_goalAmount);
            this.panel2.Controls.Add(this.lbl_goalTxt2);
            this.panel2.Controls.Add(this.rtb_orgDescription);
            this.panel2.Controls.Add(this.lbl_donated);
            this.panel2.Controls.Add(this.lbl_goalTxt);
            this.panel2.Controls.Add(this.pbr_goal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(854, 565);
            this.panel2.TabIndex = 4;
            // 
            // txt_goalAmount
            // 
            this.txt_goalAmount.Location = new System.Drawing.Point(219, 160);
            this.txt_goalAmount.Name = "txt_goalAmount";
            this.txt_goalAmount.Size = new System.Drawing.Size(56, 20);
            this.txt_goalAmount.TabIndex = 8;
            // 
            // lbl_goalTxt2
            // 
            this.lbl_goalTxt2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_goalTxt2.AutoSize = true;
            this.lbl_goalTxt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_goalTxt2.Location = new System.Drawing.Point(275, 158);
            this.lbl_goalTxt2.Name = "lbl_goalTxt2";
            this.lbl_goalTxt2.Size = new System.Drawing.Size(47, 20);
            this.lbl_goalTxt2.TabIndex = 7;
            this.lbl_goalTxt2.Text = " goal.";
            // 
            // rtb_orgDescription
            // 
            this.rtb_orgDescription.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_orgDescription.Location = new System.Drawing.Point(103, 199);
            this.rtb_orgDescription.MaximumSize = new System.Drawing.Size(650, 240);
            this.rtb_orgDescription.Name = "rtb_orgDescription";
            this.rtb_orgDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtb_orgDescription.Size = new System.Drawing.Size(650, 240);
            this.rtb_orgDescription.TabIndex = 6;
            this.rtb_orgDescription.Text = resources.GetString("rtb_orgDescription.Text");
            // 
            // lbl_donated
            // 
            this.lbl_donated.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_donated.AutoSize = true;
            this.lbl_donated.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_donated.ForeColor = System.Drawing.Color.Coral;
            this.lbl_donated.Location = new System.Drawing.Point(96, 117);
            this.lbl_donated.Name = "lbl_donated";
            this.lbl_donated.Size = new System.Drawing.Size(209, 44);
            this.lbl_donated.TabIndex = 4;
            this.lbl_donated.Text = "US$ 10,481";
            // 
            // lbl_goalTxt
            // 
            this.lbl_goalTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_goalTxt.AutoSize = true;
            this.lbl_goalTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_goalTxt.Location = new System.Drawing.Point(99, 158);
            this.lbl_goalTxt.Name = "lbl_goalTxt";
            this.lbl_goalTxt.Size = new System.Drawing.Size(124, 20);
            this.lbl_goalTxt.TabIndex = 3;
            this.lbl_goalTxt.Text = "pledged of US$ ";
            // 
            // pbr_goal
            // 
            this.pbr_goal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbr_goal.BackColor = System.Drawing.SystemColors.Control;
            this.pbr_goal.Enabled = false;
            this.pbr_goal.Location = new System.Drawing.Point(103, 40);
            this.pbr_goal.Margin = new System.Windows.Forms.Padding(0);
            this.pbr_goal.MarqueeAnimationSpeed = 0;
            this.pbr_goal.Maximum = 20000;
            this.pbr_goal.Name = "pbr_goal";
            this.pbr_goal.Size = new System.Drawing.Size(539, 41);
            this.pbr_goal.Step = 1;
            this.pbr_goal.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbr_goal.TabIndex = 1;
            this.pbr_goal.Value = 10481;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_save);
            this.panel3.Controls.Add(this.pnl_changePhoto);
            this.panel3.Controls.Add(this.btn_edit);
            this.panel3.Controls.Add(this.btn_changeDonateOpt);
            this.panel3.Controls.Add(this.pic_orgLogo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(855, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(311, 565);
            this.panel3.TabIndex = 5;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(214)))), ((int)(((byte)(223)))));
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(94, 478);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(139, 52);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            // 
            // pnl_changePhoto
            // 
            this.pnl_changePhoto.BackColor = System.Drawing.Color.White;
            this.pnl_changePhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_changePhoto.Controls.Add(this.btn_rmvPhoto);
            this.pnl_changePhoto.Controls.Add(this.btn_uploadPhoto);
            this.pnl_changePhoto.Location = new System.Drawing.Point(52, 249);
            this.pnl_changePhoto.Name = "pnl_changePhoto";
            this.pnl_changePhoto.Size = new System.Drawing.Size(200, 51);
            this.pnl_changePhoto.TabIndex = 4;
            this.pnl_changePhoto.Visible = false;
            // 
            // btn_rmvPhoto
            // 
            this.btn_rmvPhoto.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_rmvPhoto.FlatAppearance.BorderSize = 0;
            this.btn_rmvPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rmvPhoto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rmvPhoto.Location = new System.Drawing.Point(0, 26);
            this.btn_rmvPhoto.Name = "btn_rmvPhoto";
            this.btn_rmvPhoto.Size = new System.Drawing.Size(198, 23);
            this.btn_rmvPhoto.TabIndex = 1;
            this.btn_rmvPhoto.Text = "Remove photo";
            this.btn_rmvPhoto.UseVisualStyleBackColor = true;
            this.btn_rmvPhoto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_rmvPhoto_Click);
            // 
            // btn_uploadPhoto
            // 
            this.btn_uploadPhoto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_uploadPhoto.FlatAppearance.BorderSize = 0;
            this.btn_uploadPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_uploadPhoto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_uploadPhoto.Location = new System.Drawing.Point(0, 0);
            this.btn_uploadPhoto.Name = "btn_uploadPhoto";
            this.btn_uploadPhoto.Size = new System.Drawing.Size(198, 23);
            this.btn_uploadPhoto.TabIndex = 0;
            this.btn_uploadPhoto.Text = "Upload a photo...";
            this.btn_uploadPhoto.UseVisualStyleBackColor = true;
            this.btn_uploadPhoto.Click += new System.EventHandler(this.btn_uploadPhoto_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edit.Location = new System.Drawing.Point(61, 220);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 3;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_edit_MouseClick);
            // 
            // btn_changeDonateOpt
            // 
            this.btn_changeDonateOpt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(214)))), ((int)(((byte)(223)))));
            this.btn_changeDonateOpt.FlatAppearance.BorderSize = 0;
            this.btn_changeDonateOpt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_changeDonateOpt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_changeDonateOpt.Location = new System.Drawing.Point(94, 274);
            this.btn_changeDonateOpt.Name = "btn_changeDonateOpt";
            this.btn_changeDonateOpt.Size = new System.Drawing.Size(139, 52);
            this.btn_changeDonateOpt.TabIndex = 2;
            this.btn_changeDonateOpt.Text = "Edit donate Options";
            this.btn_changeDonateOpt.UseVisualStyleBackColor = false;
            // 
            // pic_orgLogo
            // 
            this.pic_orgLogo.Image = ((System.Drawing.Image)(resources.GetObject("pic_orgLogo.Image")));
            this.pic_orgLogo.Location = new System.Drawing.Point(52, 22);
            this.pic_orgLogo.MaximumSize = new System.Drawing.Size(225, 230);
            this.pic_orgLogo.MinimumSize = new System.Drawing.Size(225, 230);
            this.pic_orgLogo.Name = "pic_orgLogo";
            this.pic_orgLogo.Size = new System.Drawing.Size(225, 230);
            this.pic_orgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_orgLogo.TabIndex = 1;
            this.pic_orgLogo.TabStop = false;
            // 
            // file_chooseImage
            // 
            this.file_chooseImage.RestoreDirectory = true;
            this.file_chooseImage.Title = "Choose Image";
            // 
            // editOrganizationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "editOrganizationInfo";
            this.Size = new System.Drawing.Size(1166, 565);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.pnl_changePhoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_orgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_donated;
        private System.Windows.Forms.Label lbl_goalTxt;
        private System.Windows.Forms.ProgressBar pbr_goal;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_changeDonateOpt;
        private System.Windows.Forms.PictureBox pic_orgLogo;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.RichTextBox rtb_orgDescription;
        private System.Windows.Forms.Panel pnl_changePhoto;
        private System.Windows.Forms.TextBox txt_goalAmount;
        private System.Windows.Forms.Label lbl_goalTxt2;
        private System.Windows.Forms.Button btn_uploadPhoto;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.OpenFileDialog file_chooseImage;
        private System.Windows.Forms.Button btn_rmvPhoto;
    }
}
