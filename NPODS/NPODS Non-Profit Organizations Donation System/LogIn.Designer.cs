namespace NPODS_Non_Profit_Organizations_Donation_System
{
    partial class LogIn
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
            this.button1 = new System.Windows.Forms.Button();
            this.registerControl1 = new NPODS_Non_Profit_Organizations_Donation_System.RegisterControl();
            this.header1 = new NPODS_Non_Profit_Organizations_Donation_System.HeaderControl();
            this.loginScreen1 = new NPODS_Non_Profit_Organizations_Donation_System.LoginControl();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.YellowGreen;
            this.button1.Location = new System.Drawing.Point(12, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "< Back";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // registerControl1
            // 
            this.registerControl1.BackColor = System.Drawing.Color.Transparent;
            this.registerControl1.Location = new System.Drawing.Point(258, 163);
            this.registerControl1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.registerControl1.Name = "registerControl1";
            this.registerControl1.Size = new System.Drawing.Size(548, 342);
            this.registerControl1.TabIndex = 3;
            // 
            // header1
            // 
            this.header1.BackColor = System.Drawing.Color.YellowGreen;
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(1040, 65);
            this.header1.TabIndex = 1;
            // 
            // loginScreen1
            // 
            this.loginScreen1.BackColor = System.Drawing.Color.Transparent;
            this.loginScreen1.Location = new System.Drawing.Point(0, 64);
            this.loginScreen1.Name = "loginScreen1";
            this.loginScreen1.Size = new System.Drawing.Size(1040, 519);
            this.loginScreen1.TabIndex = 0;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 585);
            this.Controls.Add(this.registerControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.header1);
            this.Controls.Add(this.loginScreen1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NPODS";
            this.ResumeLayout(false);

        }

        #endregion
        private LoginControl loginScreen1;
        private HeaderControl header1;
        private System.Windows.Forms.Button button1;
        private RegisterControl registerControl1;
    }
}

