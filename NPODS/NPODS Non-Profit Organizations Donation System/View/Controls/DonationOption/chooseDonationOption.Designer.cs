using NPODS_Non_Profit_Organizations_Donation_System.Accounts;
using NPODS_Non_Profit_Organizations_Donation_System.Accounts.Donations;
using NPODS_Non_Profit_Organizations_Donation_System.OrganizationUtil;
using NPODS_Non_Profit_Organizations_Donation_System.View.Controls.DonationOption;

namespace NPODS_Non_Profit_Organizations_Donation_System
{
    partial class chooseDonationOption
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_singlePayment = new System.Windows.Forms.Button();
            this.btn_subscription = new System.Windows.Forms.Button();
            this.btn_miscellaneous = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.donationTextBox1 = new NPODS_Non_Profit_Organizations_Donation_System.DonationTextBox();
            this.lbl_custom = new System.Windows.Forms.Label();
            this.pnl_displayOptions = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(214)))), ((int)(((byte)(223)))));
            this.flowLayoutPanel1.Controls.Add(this.btn_singlePayment);
            this.flowLayoutPanel1.Controls.Add(this.btn_subscription);
            this.flowLayoutPanel1.Controls.Add(this.btn_miscellaneous);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1021, 69);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btn_singlePayment
            // 
            this.btn_singlePayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.btn_singlePayment.FlatAppearance.BorderSize = 0;
            this.btn_singlePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_singlePayment.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_singlePayment.Location = new System.Drawing.Point(0, 0);
            this.btn_singlePayment.Margin = new System.Windows.Forms.Padding(0);
            this.btn_singlePayment.Name = "btn_singlePayment";
            this.btn_singlePayment.Size = new System.Drawing.Size(185, 69);
            this.btn_singlePayment.TabIndex = 0;
            this.btn_singlePayment.Text = "Single Payment";
            this.btn_singlePayment.UseVisualStyleBackColor = false;
            this.btn_singlePayment.Click += new System.EventHandler(this.btn_singlePayment_Click);
            // 
            // btn_subscription
            // 
            this.btn_subscription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(216)))), ((int)(((byte)(238)))));
            this.btn_subscription.FlatAppearance.BorderSize = 0;
            this.btn_subscription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_subscription.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_subscription.Location = new System.Drawing.Point(185, 0);
            this.btn_subscription.Margin = new System.Windows.Forms.Padding(0);
            this.btn_subscription.Name = "btn_subscription";
            this.btn_subscription.Size = new System.Drawing.Size(182, 69);
            this.btn_subscription.TabIndex = 1;
            this.btn_subscription.Text = "Subscription";
            this.btn_subscription.UseVisualStyleBackColor = false;
            this.btn_subscription.Click += new System.EventHandler(this.btn_subscription_Click);
            // 
            // btn_miscellaneous
            // 
            this.btn_miscellaneous.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(216)))), ((int)(((byte)(238)))));
            this.btn_miscellaneous.FlatAppearance.BorderSize = 0;
            this.btn_miscellaneous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_miscellaneous.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_miscellaneous.Location = new System.Drawing.Point(367, 0);
            this.btn_miscellaneous.Margin = new System.Windows.Forms.Padding(0);
            this.btn_miscellaneous.Name = "btn_miscellaneous";
            this.btn_miscellaneous.Size = new System.Drawing.Size(182, 69);
            this.btn_miscellaneous.TabIndex = 2;
            this.btn_miscellaneous.Text = "Miscellaneous";
            this.btn_miscellaneous.UseVisualStyleBackColor = false;
            this.btn_miscellaneous.Click += new System.EventHandler(this.btn_miscellaneous_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.donationTextBox1);
            this.panel1.Controls.Add(this.lbl_custom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 452);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 113);
            this.panel1.TabIndex = 8;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(214)))), ((int)(((byte)(223)))));
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(834, 11);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(158, 59);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Confirm Donation";
            this.btn_save.UseVisualStyleBackColor = false;
            // 
            // donationTextBox1
            // 
            this.donationTextBox1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donationTextBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.donationTextBox1.Location = new System.Drawing.Point(323, 14);
            this.donationTextBox1.Margin = new System.Windows.Forms.Padding(15);
            this.donationTextBox1.Name = "donationTextBox1";
            this.donationTextBox1.Size = new System.Drawing.Size(184, 47);
            this.donationTextBox1.TabIndex = 1;
            this.donationTextBox1.Text = "Value";
            // 
            // lbl_custom
            // 
            this.lbl_custom.AutoSize = true;
            this.lbl_custom.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_custom.Location = new System.Drawing.Point(29, 14);
            this.lbl_custom.Name = "lbl_custom";
            this.lbl_custom.Size = new System.Drawing.Size(276, 39);
            this.lbl_custom.TabIndex = 0;
            this.lbl_custom.Text = "Custom Amount:";
            // 
            // pnl_displayOptions
            // 
            this.pnl_displayOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_displayOptions.Location = new System.Drawing.Point(0, 69);
            this.pnl_displayOptions.Name = "pnl_displayOptions";
            this.pnl_displayOptions.Size = new System.Drawing.Size(1021, 383);
            this.pnl_displayOptions.TabIndex = 9;
            // 
            // chooseDonationOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_displayOptions);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "chooseDonationOption";
            this.Size = new System.Drawing.Size(1021, 565);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_singlePayment;
        private System.Windows.Forms.Button btn_subscription;
        private System.Windows.Forms.Button btn_miscellaneous;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_custom;
        private DonationTextBox donationTextBox1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.FlowLayoutPanel pnl_displayOptions;
    }
}
