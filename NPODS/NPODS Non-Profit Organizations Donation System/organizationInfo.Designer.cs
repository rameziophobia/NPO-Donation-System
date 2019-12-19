namespace NPODS_Non_Profit_Organizations_Donation_System
{
    partial class organizationInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(organizationInfo));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_donated = new System.Windows.Forms.Label();
            this.lbl_goal = new System.Windows.Forms.Label();
            this.lbl_description = new System.Windows.Forms.Label();
            this.pbr_goal = new System.Windows.Forms.ProgressBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_donate = new System.Windows.Forms.Button();
            this.pic_orgLogo = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_orgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_donated);
            this.panel2.Controls.Add(this.lbl_goal);
            this.panel2.Controls.Add(this.lbl_description);
            this.panel2.Controls.Add(this.pbr_goal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(854, 584);
            this.panel2.TabIndex = 3;
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
            // lbl_goal
            // 
            this.lbl_goal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_goal.AutoSize = true;
            this.lbl_goal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_goal.Location = new System.Drawing.Point(99, 158);
            this.lbl_goal.Name = "lbl_goal";
            this.lbl_goal.Size = new System.Drawing.Size(211, 20);
            this.lbl_goal.TabIndex = 3;
            this.lbl_goal.Text = "pledged of US$ 20,000 goal.";
            // 
            // lbl_description
            // 
            this.lbl_description.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lbl_description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_description.AutoSize = true;
            this.lbl_description.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_description.Location = new System.Drawing.Point(100, 201);
            this.lbl_description.MaximumSize = new System.Drawing.Size(650, 0);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(636, 240);
            this.lbl_description.TabIndex = 2;
            this.lbl_description.Text = resources.GetString("lbl_description.Text");
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
            this.pbr_goal.Size = new System.Drawing.Size(539, 49);
            this.pbr_goal.Step = 1;
            this.pbr_goal.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbr_goal.TabIndex = 1;
            this.pbr_goal.Value = 10481;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_donate);
            this.panel3.Controls.Add(this.pic_orgLogo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(855, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(311, 584);
            this.panel3.TabIndex = 4;
            // 
            // btn_donate
            // 
            this.btn_donate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.btn_donate.FlatAppearance.BorderSize = 0;
            this.btn_donate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_donate.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_donate.Location = new System.Drawing.Point(94, 274);
            this.btn_donate.Name = "btn_donate";
            this.btn_donate.Size = new System.Drawing.Size(139, 52);
            this.btn_donate.TabIndex = 2;
            this.btn_donate.Text = "Donate";
            this.btn_donate.UseVisualStyleBackColor = false;
            // 
            // pic_orgLogo
            // 
            this.pic_orgLogo.Image = ((System.Drawing.Image)(resources.GetObject("pic_orgLogo.Image")));
            this.pic_orgLogo.Location = new System.Drawing.Point(52, 22);
            this.pic_orgLogo.Name = "pic_orgLogo";
            this.pic_orgLogo.Size = new System.Drawing.Size(225, 230);
            this.pic_orgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_orgLogo.TabIndex = 1;
            this.pic_orgLogo.TabStop = false;
            // 
            // organizationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "organizationInfo";
            this.Size = new System.Drawing.Size(1166, 584);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_orgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_donated;
        private System.Windows.Forms.Label lbl_goal;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.ProgressBar pbr_goal;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_donate;
        private System.Windows.Forms.PictureBox pic_orgLogo;
    }
}
