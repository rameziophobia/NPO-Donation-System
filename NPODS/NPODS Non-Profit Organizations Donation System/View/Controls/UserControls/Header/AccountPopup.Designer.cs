namespace NPODS_Non_Profit_Organizations_Donation_System.View.Controls.UserControls.Header
{
    partial class AccountPopup
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
            this.btn_viewDashboard = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_editAccount = new System.Windows.Forms.Button();
            this.btn_logOut = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_viewDashboard
            // 
            this.btn_viewDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_viewDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btn_viewDashboard.FlatAppearance.BorderSize = 0;
            this.btn_viewDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewDashboard.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(214)))), ((int)(((byte)(223)))));
            this.btn_viewDashboard.Location = new System.Drawing.Point(3, 3);
            this.btn_viewDashboard.Name = "btn_viewDashboard";
            this.btn_viewDashboard.Size = new System.Drawing.Size(239, 30);
            this.btn_viewDashboard.TabIndex = 0;
            this.btn_viewDashboard.Text = "View Dashboard";
            this.btn_viewDashboard.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.btn_viewDashboard);
            this.flowLayoutPanel1.Controls.Add(this.btn_editAccount);
            this.flowLayoutPanel1.Controls.Add(this.btn_logOut);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(244, 114);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.MouseLeave += new System.EventHandler(this.flowLayoutPanel1_MouseLeave);
            // 
            // btn_editAccount
            // 
            this.btn_editAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_editAccount.BackColor = System.Drawing.Color.Transparent;
            this.btn_editAccount.FlatAppearance.BorderSize = 0;
            this.btn_editAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editAccount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(214)))), ((int)(((byte)(223)))));
            this.btn_editAccount.Location = new System.Drawing.Point(3, 39);
            this.btn_editAccount.Name = "btn_editAccount";
            this.btn_editAccount.Size = new System.Drawing.Size(239, 30);
            this.btn_editAccount.TabIndex = 1;
            this.btn_editAccount.Text = "Edit Account";
            this.btn_editAccount.UseVisualStyleBackColor = false;
            // 
            // btn_logOut
            // 
            this.btn_logOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_logOut.BackColor = System.Drawing.Color.Transparent;
            this.btn_logOut.FlatAppearance.BorderSize = 0;
            this.btn_logOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logOut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(214)))), ((int)(((byte)(223)))));
            this.btn_logOut.Location = new System.Drawing.Point(3, 75);
            this.btn_logOut.Name = "btn_logOut";
            this.btn_logOut.Size = new System.Drawing.Size(239, 30);
            this.btn_logOut.TabIndex = 2;
            this.btn_logOut.Text = "Log Out";
            this.btn_logOut.UseVisualStyleBackColor = false;
            this.btn_logOut.Click += new System.EventHandler(this.btn_logOut_Click);
            // 
            // AccountPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "AccountPopup";
            this.Size = new System.Drawing.Size(244, 114);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_viewDashboard;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_editAccount;
        private System.Windows.Forms.Button btn_logOut;
    }
}
