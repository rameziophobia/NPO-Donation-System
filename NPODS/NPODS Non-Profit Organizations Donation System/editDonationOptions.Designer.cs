namespace NPODS_Non_Profit_Organizations_Donation_System
{
    partial class editDonationOptions
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
            this.cbo_donationOption = new System.Windows.Forms.ComboBox();
            this.txt_value = new System.Windows.Forms.TextBox();
            this.chk_undefinedSinglePayment = new System.Windows.Forms.CheckBox();
            this.chk_undefinedSubcription = new System.Windows.Forms.CheckBox();
            this.btn_addOption = new System.Windows.Forms.Button();
            this.pnl_options = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_options.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbo_donationOption
            // 
            this.cbo_donationOption.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbo_donationOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_donationOption.FormattingEnabled = true;
            this.cbo_donationOption.Items.AddRange(new object[] {
            "Subscription",
            "Single Payment",
            "Miscellaneous"});
            this.cbo_donationOption.Location = new System.Drawing.Point(15, 15);
            this.cbo_donationOption.Margin = new System.Windows.Forms.Padding(15);
            this.cbo_donationOption.Name = "cbo_donationOption";
            this.cbo_donationOption.Size = new System.Drawing.Size(200, 32);
            this.cbo_donationOption.TabIndex = 0;
            // 
            // txt_value
            // 
            this.txt_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_value.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_value.Location = new System.Drawing.Point(245, 15);
            this.txt_value.Margin = new System.Windows.Forms.Padding(15);
            this.txt_value.Name = "txt_value";
            this.txt_value.Size = new System.Drawing.Size(100, 31);
            this.txt_value.TabIndex = 1;
            this.txt_value.Text = "Value";
            this.txt_value.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // chk_undefinedSinglePayment
            // 
            this.chk_undefinedSinglePayment.AutoSize = true;
            this.chk_undefinedSinglePayment.Location = new System.Drawing.Point(238, 443);
            this.chk_undefinedSinglePayment.Name = "chk_undefinedSinglePayment";
            this.chk_undefinedSinglePayment.Size = new System.Drawing.Size(220, 17);
            this.chk_undefinedSinglePayment.TabIndex = 2;
            this.chk_undefinedSinglePayment.Text = "Allow undefined single payment amounts.";
            this.chk_undefinedSinglePayment.UseVisualStyleBackColor = true;
            // 
            // chk_undefinedSubcription
            // 
            this.chk_undefinedSubcription.AutoSize = true;
            this.chk_undefinedSubcription.Location = new System.Drawing.Point(238, 467);
            this.chk_undefinedSubcription.Name = "chk_undefinedSubcription";
            this.chk_undefinedSubcription.Size = new System.Drawing.Size(206, 17);
            this.chk_undefinedSubcription.TabIndex = 3;
            this.chk_undefinedSubcription.Text = "Allow undefined subscription amounts.";
            this.chk_undefinedSubcription.UseVisualStyleBackColor = true;
            // 
            // btn_addOption
            // 
            this.btn_addOption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.btn_addOption.FlatAppearance.BorderSize = 0;
            this.btn_addOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addOption.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addOption.Location = new System.Drawing.Point(84, 443);
            this.btn_addOption.Name = "btn_addOption";
            this.btn_addOption.Size = new System.Drawing.Size(139, 52);
            this.btn_addOption.TabIndex = 6;
            this.btn_addOption.Text = "Add Option";
            this.btn_addOption.UseVisualStyleBackColor = false;
            // 
            // pnl_options
            // 
            this.pnl_options.Controls.Add(this.cbo_donationOption);
            this.pnl_options.Controls.Add(this.txt_value);
            this.pnl_options.Location = new System.Drawing.Point(66, 47);
            this.pnl_options.Name = "pnl_options";
            this.pnl_options.Size = new System.Drawing.Size(816, 377);
            this.pnl_options.TabIndex = 7;
            // 
            // editDonationOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_options);
            this.Controls.Add(this.btn_addOption);
            this.Controls.Add(this.chk_undefinedSubcription);
            this.Controls.Add(this.chk_undefinedSinglePayment);
            this.Name = "editDonationOptions";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(1166, 565);
            this.pnl_options.ResumeLayout(false);
            this.pnl_options.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_donationOption;
        private System.Windows.Forms.TextBox txt_value;
        private System.Windows.Forms.CheckBox chk_undefinedSinglePayment;
        private System.Windows.Forms.CheckBox chk_undefinedSubcription;
        private System.Windows.Forms.Button btn_addOption;
        private System.Windows.Forms.FlowLayoutPanel pnl_options;
    }
}
