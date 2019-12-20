using System.Collections.Generic;

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
            this.chk_undefinedSinglePayment = new System.Windows.Forms.CheckBox();
            this.chk_undefinedSubcription = new System.Windows.Forms.CheckBox();
            this.btn_addOption = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.donationGroupBox0 = new System.Windows.Forms.GroupBox();
            this.cbo_donationOption0 = new System.Windows.Forms.ComboBox();
            this.txt_value0 = new System.Windows.Forms.TextBox();
            this.pnl_options = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.donationGroupBox0.SuspendLayout();
            this.pnl_options.SuspendLayout();
            this.SuspendLayout();
            // 
            // chk_undefinedSinglePayment
            // 
            this.chk_undefinedSinglePayment.AutoSize = true;
            this.chk_undefinedSinglePayment.Location = new System.Drawing.Point(446, 464);
            this.chk_undefinedSinglePayment.Name = "chk_undefinedSinglePayment";
            this.chk_undefinedSinglePayment.Size = new System.Drawing.Size(220, 17);
            this.chk_undefinedSinglePayment.TabIndex = 2;
            this.chk_undefinedSinglePayment.Text = "Allow undefined single payment amounts.";
            this.chk_undefinedSinglePayment.UseVisualStyleBackColor = true;
            // 
            // chk_undefinedSubcription
            // 
            this.chk_undefinedSubcription.AutoSize = true;
            this.chk_undefinedSubcription.Location = new System.Drawing.Point(234, 464);
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
            this.btn_addOption.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_addOption_MouseClick);
            // 
            // donationGroupBox0
            // 
            this.donationGroupBox0.Controls.Add(this.cbo_donationOption0);
            this.donationGroupBox0.Controls.Add(this.txt_value0);
            this.donationGroupBox0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.donationGroupBox0.ForeColor = System.Drawing.SystemColors.Control;
            this.donationGroupBox0.Location = new System.Drawing.Point(3, 3);
            this.donationGroupBox0.Name = "donationGroupBox0";
            this.donationGroupBox0.Size = new System.Drawing.Size(389, 55);
            this.donationGroupBox0.TabIndex = 2;
            this.donationGroupBox0.TabStop = false;
            // 
            // cbo_donationOption0
            // 
            this.cbo_donationOption0.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbo_donationOption0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_donationOption0.FormattingEnabled = true;
            this.cbo_donationOption0.Items.AddRange(new object[] {
            "Subscription",
            "Single Payment",
            "Miscellaneous"});
            this.cbo_donationOption0.Location = new System.Drawing.Point(18, 13);
            this.cbo_donationOption0.Margin = new System.Windows.Forms.Padding(15);
            this.cbo_donationOption0.Name = "cbo_donationOption0";
            this.cbo_donationOption0.Size = new System.Drawing.Size(225, 32);
            this.cbo_donationOption0.TabIndex = 0;
            // 
            // txt_value0
            // 
            this.txt_value0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_value0.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_value0.Location = new System.Drawing.Point(273, 12);
            this.txt_value0.Margin = new System.Windows.Forms.Padding(15);
            this.txt_value0.Name = "txt_value0";
            this.txt_value0.Size = new System.Drawing.Size(98, 31);
            this.txt_value0.TabIndex = 1;
            this.txt_value0.Text = "Value";
            this.txt_value0.Click += new System.EventHandler(this.textBox1_Click);
            this.txt_value0.TextChanged += new System.EventHandler(this.txt_value_TextChanged);
            // 
            // pnl_options
            // 
            this.pnl_options.Controls.Add(this.donationGroupBox0);
            this.pnl_options.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnl_options.Location = new System.Drawing.Point(66, 47);
            this.pnl_options.Name = "pnl_options";
            this.pnl_options.Size = new System.Drawing.Size(816, 377);
            this.pnl_options.TabIndex = 7;
            // 
            // btn_confirm
            // 
            this.btn_confirm.AllowDrop = true;
            this.btn_confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.btn_confirm.FlatAppearance.BorderSize = 0;
            this.btn_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirm.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.Location = new System.Drawing.Point(733, 443);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(139, 52);
            this.btn_confirm.TabIndex = 8;
            this.btn_confirm.Text = "Confirm Changes";
            this.btn_confirm.UseVisualStyleBackColor = false;
            // 
            // editDonationOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.pnl_options);
            this.Controls.Add(this.btn_addOption);
            this.Controls.Add(this.chk_undefinedSubcription);
            this.Controls.Add(this.chk_undefinedSinglePayment);
            this.Name = "editDonationOptions";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(1166, 565);
            this.donationGroupBox0.ResumeLayout(false);
            this.donationGroupBox0.PerformLayout();
            this.pnl_options.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chk_undefinedSinglePayment;
        private System.Windows.Forms.CheckBox chk_undefinedSubcription;
        private System.Windows.Forms.Button btn_addOption;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox donationGroupBox0;
        private System.Windows.Forms.ComboBox cbo_donationOption0;
        private System.Windows.Forms.TextBox txt_value0;
        private System.Windows.Forms.FlowLayoutPanel pnl_options;
        private List<DonationGroupBox> donationGroupBoxes = new List<DonationGroupBox>();
        private System.Windows.Forms.Button btn_confirm;
    }
}
