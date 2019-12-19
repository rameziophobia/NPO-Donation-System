namespace NPODS_Non_Profit_Organizations_Donation_System
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(423, 100);
            this.txt_email.Margin = new System.Windows.Forms.Padding(7);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(784, 52);
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
            this.register_btn.Location = new System.Drawing.Point(423, 622);
            this.register_btn.Margin = new System.Windows.Forms.Padding(7);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(784, 94);
            this.register_btn.TabIndex = 9;
            this.register_btn.Text = "Register";
            this.register_btn.UseVisualStyleBackColor = false;
            // 
            // lbl_password
            // 
            this.lbl_password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(22, 173);
            this.lbl_password.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(216, 59);
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
            this.lbl_email.Location = new System.Drawing.Point(22, 99);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(135, 59);
            this.lbl_email.TabIndex = 7;
            this.lbl_email.Text = "Email";
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(423, 173);
            this.txt_password.Margin = new System.Windows.Forms.Padding(7);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(784, 52);
            this.txt_password.TabIndex = 11;
            // 
            // lbl_confirmPassword
            // 
            this.lbl_confirmPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_confirmPassword.AutoSize = true;
            this.lbl_confirmPassword.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirmPassword.Location = new System.Drawing.Point(22, 255);
            this.lbl_confirmPassword.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbl_confirmPassword.Name = "lbl_confirmPassword";
            this.lbl_confirmPassword.Size = new System.Drawing.Size(387, 59);
            this.lbl_confirmPassword.TabIndex = 14;
            this.lbl_confirmPassword.Text = "Confirm Password";
            // 
            // txt_confirmPassword
            // 
            this.txt_confirmPassword.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_confirmPassword.Location = new System.Drawing.Point(423, 255);
            this.txt_confirmPassword.Margin = new System.Windows.Forms.Padding(7);
            this.txt_confirmPassword.Name = "txt_confirmPassword";
            this.txt_confirmPassword.PasswordChar = '*';
            this.txt_confirmPassword.Size = new System.Drawing.Size(784, 52);
            this.txt_confirmPassword.TabIndex = 15;
            // 
            // lbl_name
            // 
            this.lbl_name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(22, 334);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(144, 59);
            this.lbl_name.TabIndex = 16;
            this.lbl_name.Text = "Name";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(423, 334);
            this.txt_name.Margin = new System.Windows.Forms.Padding(7);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(784, 52);
            this.txt_name.TabIndex = 17;
            // 
            // lbl_gender
            // 
            this.lbl_gender.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gender.Location = new System.Drawing.Point(22, 415);
            this.lbl_gender.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(173, 59);
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
            this.cbo_gender.Location = new System.Drawing.Point(423, 424);
            this.cbo_gender.Name = "cbo_gender";
            this.cbo_gender.Size = new System.Drawing.Size(784, 49);
            this.cbo_gender.TabIndex = 19;
            // 
            // lbl_dayOfBirth
            // 
            this.lbl_dayOfBirth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_dayOfBirth.AutoSize = true;
            this.lbl_dayOfBirth.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dayOfBirth.Location = new System.Drawing.Point(22, 494);
            this.lbl_dayOfBirth.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbl_dayOfBirth.Name = "lbl_dayOfBirth";
            this.lbl_dayOfBirth.Size = new System.Drawing.Size(196, 59);
            this.lbl_dayOfBirth.TabIndex = 20;
            this.lbl_dayOfBirth.Text = "Birthday";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Gadugi", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(423, 494);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(784, 51);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // RegisterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.dateTimePicker1);
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
            this.Name = "RegisterControl";
            this.Size = new System.Drawing.Size(1279, 763);
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
