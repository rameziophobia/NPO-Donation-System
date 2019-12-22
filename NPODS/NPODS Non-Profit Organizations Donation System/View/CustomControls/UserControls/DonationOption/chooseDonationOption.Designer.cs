using NPODS_Non_Profit_Organizations_Donation_System.Accounts;
using NPODS_Non_Profit_Organizations_Donation_System.Accounts.Donations;
using NPODS_Non_Profit_Organizations_Donation_System.OrganizationUtil;
using NPODS_Non_Profit_Organizations_Donation_System.View.CustomControls.UserControls.DonationOption;

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
            this.pnl_donationType = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_singlePayment = new System.Windows.Forms.Button();
            this.btn_subscription = new System.Windows.Forms.Button();
            this.btn_miscellaneous = new System.Windows.Forms.Button();
            this.pnl_back = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_back = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnl_displayOptions = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_noOptions = new System.Windows.Forms.Label();
            this.pnl_chooseDisplayOption = new System.Windows.Forms.Panel();
            this.pnl_customDonation = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.lbl_custom = new System.Windows.Forms.Label();
            this.paymentOption2 = new NPODS_Non_Profit_Organizations_Donation_System.View.CustomControls.UserControls.DonationOption.PaymentOptions.PaymentOption();
            this.txt_customValue = new NPODS_Non_Profit_Organizations_Donation_System.DonationTextBox();
            this.pnl_donationType.SuspendLayout();
            this.pnl_back.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnl_displayOptions.SuspendLayout();
            this.pnl_chooseDisplayOption.SuspendLayout();
            this.pnl_customDonation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_donationType
            // 
            this.pnl_donationType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(214)))), ((int)(((byte)(223)))));
            this.pnl_donationType.Controls.Add(this.btn_singlePayment);
            this.pnl_donationType.Controls.Add(this.btn_subscription);
            this.pnl_donationType.Controls.Add(this.btn_miscellaneous);
            this.pnl_donationType.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_donationType.Location = new System.Drawing.Point(0, 0);
            this.pnl_donationType.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_donationType.Name = "pnl_donationType";
            this.pnl_donationType.Size = new System.Drawing.Size(614, 69);
            this.pnl_donationType.TabIndex = 0;
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
            this.btn_singlePayment.Visible = false;
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
            this.btn_subscription.Size = new System.Drawing.Size(185, 69);
            this.btn_subscription.TabIndex = 1;
            this.btn_subscription.Text = "Subscription";
            this.btn_subscription.UseVisualStyleBackColor = false;
            this.btn_subscription.Visible = false;
            this.btn_subscription.Click += new System.EventHandler(this.btn_subscription_Click);
            // 
            // btn_miscellaneous
            // 
            this.btn_miscellaneous.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(216)))), ((int)(((byte)(238)))));
            this.btn_miscellaneous.FlatAppearance.BorderSize = 0;
            this.btn_miscellaneous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_miscellaneous.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_miscellaneous.Location = new System.Drawing.Point(370, 0);
            this.btn_miscellaneous.Margin = new System.Windows.Forms.Padding(0);
            this.btn_miscellaneous.Name = "btn_miscellaneous";
            this.btn_miscellaneous.Size = new System.Drawing.Size(185, 69);
            this.btn_miscellaneous.TabIndex = 2;
            this.btn_miscellaneous.Text = "Miscellaneous";
            this.btn_miscellaneous.UseVisualStyleBackColor = false;
            this.btn_miscellaneous.Visible = false;
            this.btn_miscellaneous.Click += new System.EventHandler(this.btn_miscellaneous_Click);
            // 
            // pnl_back
            // 
            this.pnl_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(214)))), ((int)(((byte)(223)))));
            this.pnl_back.Controls.Add(this.btn_back);
            this.pnl_back.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_back.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnl_back.Location = new System.Drawing.Point(645, 0);
            this.pnl_back.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_back.Name = "pnl_back";
            this.pnl_back.Size = new System.Drawing.Size(376, 69);
            this.pnl_back.TabIndex = 1;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(216)))), ((int)(((byte)(238)))));
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(194, 0);
            this.btn_back.Margin = new System.Windows.Forms.Padding(0);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(182, 69);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(214)))), ((int)(((byte)(223)))));
            this.panel2.Controls.Add(this.pnl_donationType);
            this.panel2.Controls.Add(this.pnl_back);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1021, 69);
            this.panel2.TabIndex = 10;
            // 
            // pnl_displayOptions
            // 
            this.pnl_displayOptions.Controls.Add(this.lbl_noOptions);
            this.pnl_displayOptions.Location = new System.Drawing.Point(3, 72);
            this.pnl_displayOptions.Name = "pnl_displayOptions";
            this.pnl_displayOptions.Size = new System.Drawing.Size(1021, 391);
            this.pnl_displayOptions.TabIndex = 11;
            // 
            // lbl_noOptions
            // 
            this.lbl_noOptions.AutoSize = true;
            this.lbl_noOptions.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_noOptions.Location = new System.Drawing.Point(50, 50);
            this.lbl_noOptions.Margin = new System.Windows.Forms.Padding(50);
            this.lbl_noOptions.Name = "lbl_noOptions";
            this.lbl_noOptions.Size = new System.Drawing.Size(739, 39);
            this.lbl_noOptions.TabIndex = 0;
            this.lbl_noOptions.Text = "Sorry, no donation options availabe right now.";
            this.lbl_noOptions.Visible = false;
            // 
            // pnl_chooseDisplayOption
            // 
            this.pnl_chooseDisplayOption.Controls.Add(this.pnl_customDonation);
            this.pnl_chooseDisplayOption.Controls.Add(this.panel2);
            this.pnl_chooseDisplayOption.Controls.Add(this.pnl_displayOptions);
            this.pnl_chooseDisplayOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_chooseDisplayOption.Location = new System.Drawing.Point(0, 0);
            this.pnl_chooseDisplayOption.Name = "pnl_chooseDisplayOption";
            this.pnl_chooseDisplayOption.Size = new System.Drawing.Size(1021, 565);
            this.pnl_chooseDisplayOption.TabIndex = 13;
            // 
            // pnl_customDonation
            // 
            this.pnl_customDonation.Controls.Add(this.txt_customValue);
            this.pnl_customDonation.Controls.Add(this.btn_save);
            this.pnl_customDonation.Controls.Add(this.lbl_custom);
            this.pnl_customDonation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_customDonation.Location = new System.Drawing.Point(0, 458);
            this.pnl_customDonation.Name = "pnl_customDonation";
            this.pnl_customDonation.Size = new System.Drawing.Size(1021, 107);
            this.pnl_customDonation.TabIndex = 12;
            this.pnl_customDonation.Visible = false;
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
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
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
            // paymentOption2
            // 
            this.paymentOption2.Location = new System.Drawing.Point(4, -125);
            this.paymentOption2.Name = "paymentOption2";
            this.paymentOption2.OnBackPress = null;
            this.paymentOption2.Organization = null;
            this.paymentOption2.Size = new System.Drawing.Size(1017, 560);
            this.paymentOption2.TabIndex = 12;
            this.paymentOption2.Visible = false;
            // 
            // txt_customValue
            // 
            this.txt_customValue.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customValue.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_customValue.Location = new System.Drawing.Point(313, 20);
            this.txt_customValue.Margin = new System.Windows.Forms.Padding(5);
            this.txt_customValue.Name = "txt_customValue";
            this.txt_customValue.Size = new System.Drawing.Size(193, 33);
            this.txt_customValue.TabIndex = 1;
            this.txt_customValue.Text = "Value";
            // 
            // chooseDonationOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.paymentOption2);
            this.Controls.Add(this.pnl_chooseDisplayOption);
            this.Name = "chooseDonationOption";
            this.Size = new System.Drawing.Size(1021, 565);
            this.pnl_donationType.ResumeLayout(false);
            this.pnl_back.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnl_displayOptions.ResumeLayout(false);
            this.pnl_displayOptions.PerformLayout();
            this.pnl_chooseDisplayOption.ResumeLayout(false);
            this.pnl_customDonation.ResumeLayout(false);
            this.pnl_customDonation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnl_donationType;
        private System.Windows.Forms.Button btn_singlePayment;
        private System.Windows.Forms.Button btn_subscription;
        private System.Windows.Forms.Button btn_miscellaneous;
        private System.Windows.Forms.FlowLayoutPanel pnl_back;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel pnl_displayOptions;
        private System.Windows.Forms.Label lbl_noOptions;
        private View.CustomControls.UserControls.DonationOption.PaymentOptions.PaymentOption paymentOption2;
        private System.Windows.Forms.Panel pnl_chooseDisplayOption;
        private System.Windows.Forms.Panel pnl_customDonation;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lbl_custom;
        private DonationTextBox txt_customValue;
    }
}
