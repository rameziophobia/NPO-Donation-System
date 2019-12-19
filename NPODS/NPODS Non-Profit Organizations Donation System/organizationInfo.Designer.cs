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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(organizationInfo));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dontatedLbl = new System.Windows.Forms.Label();
            this.goalLbl = new System.Windows.Forms.Label();
            this.descriptionLbl = new System.Windows.Forms.Label();
            this.goalBar = new System.Windows.Forms.ProgressBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.donateBtn = new System.Windows.Forms.Button();
            this.orgPic = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orgPic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dontatedLbl);
            this.panel2.Controls.Add(this.goalLbl);
            this.panel2.Controls.Add(this.descriptionLbl);
            this.panel2.Controls.Add(this.goalBar);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(854, 586);
            this.panel2.TabIndex = 2;
            // 
            // dontatedLbl
            // 
            this.dontatedLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dontatedLbl.AutoSize = true;
            this.dontatedLbl.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dontatedLbl.ForeColor = System.Drawing.Color.Coral;
            this.dontatedLbl.Location = new System.Drawing.Point(96, 117);
            this.dontatedLbl.Name = "dontatedLbl";
            this.dontatedLbl.Size = new System.Drawing.Size(209, 44);
            this.dontatedLbl.TabIndex = 4;
            this.dontatedLbl.Text = "US$ 10,481";
            // 
            // goalLbl
            // 
            this.goalLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.goalLbl.AutoSize = true;
            this.goalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goalLbl.Location = new System.Drawing.Point(99, 158);
            this.goalLbl.Name = "goalLbl";
            this.goalLbl.Size = new System.Drawing.Size(211, 20);
            this.goalLbl.TabIndex = 3;
            this.goalLbl.Text = "pledged of US$ 20,000 goal.";
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.descriptionLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionLbl.AutoSize = true;
            this.descriptionLbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLbl.Location = new System.Drawing.Point(100, 203);
            this.descriptionLbl.MaximumSize = new System.Drawing.Size(650, 0);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(636, 240);
            this.descriptionLbl.TabIndex = 2;
            this.descriptionLbl.Text = resources.GetString("descriptionLbl.Text");
            // 
            // goalBar
            // 
            this.goalBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.goalBar.BackColor = System.Drawing.SystemColors.Control;
            this.goalBar.Enabled = false;
            this.goalBar.Location = new System.Drawing.Point(103, 40);
            this.goalBar.Margin = new System.Windows.Forms.Padding(0);
            this.goalBar.MarqueeAnimationSpeed = 0;
            this.goalBar.Maximum = 20000;
            this.goalBar.Name = "goalBar";
            this.goalBar.Size = new System.Drawing.Size(539, 51);
            this.goalBar.Step = 1;
            this.goalBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.goalBar.TabIndex = 1;
            this.goalBar.Value = 10481;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.donateBtn);
            this.panel3.Controls.Add(this.orgPic);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(860, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(313, 586);
            this.panel3.TabIndex = 3;
            // 
            // donateBtn
            // 
            this.donateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.donateBtn.FlatAppearance.BorderSize = 0;
            this.donateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.donateBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donateBtn.Location = new System.Drawing.Point(94, 274);
            this.donateBtn.Name = "donateBtn";
            this.donateBtn.Size = new System.Drawing.Size(139, 52);
            this.donateBtn.TabIndex = 2;
            this.donateBtn.Text = "Donate";
            this.donateBtn.UseVisualStyleBackColor = false;
            // 
            // orgPic
            // 
            this.orgPic.Image = ((System.Drawing.Image)(resources.GetObject("orgPic.Image")));
            this.orgPic.Location = new System.Drawing.Point(52, 22);
            this.orgPic.Name = "orgPic";
            this.orgPic.Size = new System.Drawing.Size(225, 230);
            this.orgPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.orgPic.TabIndex = 1;
            this.orgPic.TabStop = false;
            // 
            // organizationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "organizationInfo";
            this.Size = new System.Drawing.Size(1173, 586);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orgPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox orgPic;
        private System.Windows.Forms.Button donateBtn;
        private System.Windows.Forms.Label dontatedLbl;
        private System.Windows.Forms.Label goalLbl;
        private System.Windows.Forms.Label descriptionLbl;
        private System.Windows.Forms.ProgressBar goalBar;
    }
}