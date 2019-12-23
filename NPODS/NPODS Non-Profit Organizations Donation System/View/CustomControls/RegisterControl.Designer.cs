namespace NPODS_Non_Profit_Organizations_Donation_System.View.CustomControls
{
    partial class RegisterControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
        {
            if(disposing && (components != null))
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
        private void InitializeComponent ()
        {
            this.txt_email = new System.Windows.Forms.TextBox();
            this.register_btn = new System.Windows.Forms.Button();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_confirmPassword = new System.Windows.Forms.Label();
            this.txt_confirmPassword = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.cbo_gender = new System.Windows.Forms.ComboBox();
            this.lbl_dayOfBirth = new System.Windows.Forms.Label();
            this.dtp_birthday = new System.Windows.Forms.DateTimePicker();
            this.lbl_accountType = new System.Windows.Forms.Label();
            this.cbo_accountType = new System.Windows.Forms.ComboBox();
            this.lbl_organizationUrl = new System.Windows.Forms.Label();
            this.txt_organizationUrl = new System.Windows.Forms.TextBox();
            this.lbl_errorMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(181, 45);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(338, 27);
            this.txt_email.TabIndex = 10;
            // 
            // register_btn
            // 
            this.register_btn.BackColor = System.Drawing.Color.Transparent;
            this.register_btn.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.register_btn.FlatAppearance.BorderSize = 2;
            this.register_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register_btn.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_btn.ForeColor = System.Drawing.Color.Black;
            this.register_btn.Location = new System.Drawing.Point(181, 330);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(336, 42);
            this.register_btn.TabIndex = 9;
            this.register_btn.Text = "Register";
            this.register_btn.UseVisualStyleBackColor = false;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // lbl_password
            // 
            this.lbl_password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(9, 78);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(94, 26);
            this.lbl_password.TabIndex = 8;
            this.lbl_password.Text = "Password";
            // 
            // lbl_email
            // 
            this.lbl_email.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(9, 44);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(59, 26);
            this.lbl_email.TabIndex = 7;
            this.lbl_email.Text = "Email";
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(181, 78);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(338, 27);
            this.txt_password.TabIndex = 11;
            // 
            // lbl_confirmPassword
            // 
            this.lbl_confirmPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_confirmPassword.AutoSize = true;
            this.lbl_confirmPassword.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirmPassword.Location = new System.Drawing.Point(9, 114);
            this.lbl_confirmPassword.Name = "lbl_confirmPassword";
            this.lbl_confirmPassword.Size = new System.Drawing.Size(168, 26);
            this.lbl_confirmPassword.TabIndex = 14;
            this.lbl_confirmPassword.Text = "Confirm Password";
            // 
            // txt_confirmPassword
            // 
            this.txt_confirmPassword.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_confirmPassword.Location = new System.Drawing.Point(181, 114);
            this.txt_confirmPassword.Name = "txt_confirmPassword";
            this.txt_confirmPassword.PasswordChar = '*';
            this.txt_confirmPassword.Size = new System.Drawing.Size(338, 27);
            this.txt_confirmPassword.TabIndex = 15;
            // 
            // lbl_name
            // 
            this.lbl_name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(9, 150);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(64, 26);
            this.lbl_name.TabIndex = 16;
            this.lbl_name.Text = "Name";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(181, 150);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(338, 27);
            this.txt_name.TabIndex = 17;
            // 
            // lbl_gender
            // 
            this.lbl_gender.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gender.Location = new System.Drawing.Point(9, 224);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(76, 26);
            this.lbl_gender.TabIndex = 18;
            this.lbl_gender.Text = "Gender";
            // 
            // cbo_gender
            // 
            this.cbo_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_gender.Font = new System.Drawing.Font("Gadugi", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_gender.FormattingEnabled = true;
            this.cbo_gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Non-Binary"});
            this.cbo_gender.Location = new System.Drawing.Point(181, 223);
            this.cbo_gender.Margin = new System.Windows.Forms.Padding(1);
            this.cbo_gender.Name = "cbo_gender";
            this.cbo_gender.Size = new System.Drawing.Size(338, 27);
            this.cbo_gender.TabIndex = 19;
            // 
            // lbl_dayOfBirth
            // 
            this.lbl_dayOfBirth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_dayOfBirth.AutoSize = true;
            this.lbl_dayOfBirth.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dayOfBirth.Location = new System.Drawing.Point(9, 259);
            this.lbl_dayOfBirth.Name = "lbl_dayOfBirth";
            this.lbl_dayOfBirth.Size = new System.Drawing.Size(85, 26);
            this.lbl_dayOfBirth.TabIndex = 20;
            this.lbl_dayOfBirth.Text = "Birthday";
            // 
            // dtp_birthday
            // 
            this.dtp_birthday.Font = new System.Drawing.Font("Gadugi", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_birthday.Location = new System.Drawing.Point(181, 259);
            this.dtp_birthday.Margin = new System.Windows.Forms.Padding(1);
            this.dtp_birthday.Name = "dtp_birthday";
            this.dtp_birthday.Size = new System.Drawing.Size(338, 27);
            this.dtp_birthday.TabIndex = 21;
            // 
            // lbl_accountType
            // 
            this.lbl_accountType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_accountType.AutoSize = true;
            this.lbl_accountType.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_accountType.Location = new System.Drawing.Point(9, 185);
            this.lbl_accountType.Name = "lbl_accountType";
            this.lbl_accountType.Size = new System.Drawing.Size(127, 26);
            this.lbl_accountType.TabIndex = 22;
            this.lbl_accountType.Text = "Account type";
            // 
            // cbo_accountType
            // 
            this.cbo_accountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_accountType.Font = new System.Drawing.Font("Gadugi", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_accountType.FormattingEnabled = true;
            this.cbo_accountType.Items.AddRange(new object[] {
            "Donor",
            "Organization"});
            this.cbo_accountType.Location = new System.Drawing.Point(181, 187);
            this.cbo_accountType.Margin = new System.Windows.Forms.Padding(1);
            this.cbo_accountType.Name = "cbo_accountType";
            this.cbo_accountType.Size = new System.Drawing.Size(338, 27);
            this.cbo_accountType.TabIndex = 23;
            this.cbo_accountType.SelectedIndexChanged += new System.EventHandler(this.cbo_accountType_SelectedIndexChanged);
            // 
            // lbl_organizationUrl
            // 
            this.lbl_organizationUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_organizationUrl.AutoSize = true;
            this.lbl_organizationUrl.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_organizationUrl.Location = new System.Drawing.Point(9, 223);
            this.lbl_organizationUrl.Name = "lbl_organizationUrl";
            this.lbl_organizationUrl.Size = new System.Drawing.Size(152, 26);
            this.lbl_organizationUrl.TabIndex = 24;
            this.lbl_organizationUrl.Text = "Organization Url";
            this.lbl_organizationUrl.Visible = false;
            // 
            // txt_organizationUrl
            // 
            this.txt_organizationUrl.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_organizationUrl.Location = new System.Drawing.Point(181, 223);
            this.txt_organizationUrl.Name = "txt_organizationUrl";
            this.txt_organizationUrl.Size = new System.Drawing.Size(338, 27);
            this.txt_organizationUrl.TabIndex = 25;
            this.txt_organizationUrl.Visible = false;
            // 
            // lbl_errorMessage
            // 
            this.lbl_errorMessage.AutoSize = true;
            this.lbl_errorMessage.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_errorMessage.ForeColor = System.Drawing.Color.Red;
            this.lbl_errorMessage.Location = new System.Drawing.Point(181, 291);
            this.lbl_errorMessage.Name = "lbl_errorMessage";
            this.lbl_errorMessage.Size = new System.Drawing.Size(0, 19);
            this.lbl_errorMessage.TabIndex = 26;
            // 
            // RegisterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lbl_errorMessage);
            this.Controls.Add(this.lbl_organizationUrl);
            this.Controls.Add(this.txt_organizationUrl);
            this.Controls.Add(this.cbo_accountType);
            this.Controls.Add(this.lbl_accountType);
            this.Controls.Add(this.dtp_birthday);
            this.Controls.Add(this.lbl_dayOfBirth);
            this.Controls.Add(this.cbo_gender);
            this.Controls.Add(this.lbl_gender);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_confirmPassword);
            this.Controls.Add(this.txt_confirmPassword);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.txt_password);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "RegisterControl";
            this.Size = new System.Drawing.Size(548, 380);
            this.Load += new System.EventHandler(this.RegisterControl_Load);
            this.VisibleChanged += new System.EventHandler(this.RegisterControl_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_confirmPassword;
        private System.Windows.Forms.TextBox txt_confirmPassword;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.ComboBox cbo_gender;
        private System.Windows.Forms.Label lbl_dayOfBirth;
        private System.Windows.Forms.DateTimePicker dtp_birthday;
        private System.Windows.Forms.Label lbl_accountType;
        private System.Windows.Forms.ComboBox cbo_accountType;
        private System.Windows.Forms.Label lbl_organizationUrl;
        private System.Windows.Forms.TextBox txt_organizationUrl;
        private System.Windows.Forms.Label lbl_errorMessage;
    }
}
