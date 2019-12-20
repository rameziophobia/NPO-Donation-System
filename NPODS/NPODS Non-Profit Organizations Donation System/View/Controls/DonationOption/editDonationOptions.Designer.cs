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
            this.pnl_options = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.chk_undefinedSinglePayment = new System.Windows.Forms.CheckBox();
            this.chk_undefinedSubcription = new System.Windows.Forms.CheckBox();
            this.btn_addOption = new System.Windows.Forms.Button();
            this.pnl_buttons = new System.Windows.Forms.Panel();
            this.pnl_buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_options
            // 
            this.pnl_options.AutoScroll = true;
            this.pnl_options.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_options.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnl_options.Location = new System.Drawing.Point(0, 0);
            this.pnl_options.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_options.Name = "pnl_options";
            this.pnl_options.Padding = new System.Windows.Forms.Padding(15, 15, 15, 60);
            this.pnl_options.Size = new System.Drawing.Size(1179, 648);
            this.pnl_options.TabIndex = 7;
            this.pnl_options.WrapContents = false;
            // 
            // btn_confirm
            // 
            this.btn_confirm.AllowDrop = true;
            this.btn_confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(214)))), ((int)(((byte)(223)))));
            this.btn_confirm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_confirm.FlatAppearance.BorderSize = 0;
            this.btn_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirm.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.Location = new System.Drawing.Point(1017, 0);
            this.btn_confirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(162, 111);
            this.btn_confirm.TabIndex = 8;
            this.btn_confirm.Text = "Confirm Changes";
            this.btn_confirm.UseVisualStyleBackColor = false;
            // 
            // chk_undefinedSinglePayment
            // 
            this.chk_undefinedSinglePayment.AutoSize = true;
            this.chk_undefinedSinglePayment.Location = new System.Drawing.Point(228, 19);
            this.chk_undefinedSinglePayment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chk_undefinedSinglePayment.Name = "chk_undefinedSinglePayment";
            this.chk_undefinedSinglePayment.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.chk_undefinedSinglePayment.Size = new System.Drawing.Size(252, 40);
            this.chk_undefinedSinglePayment.TabIndex = 2;
            this.chk_undefinedSinglePayment.Text = "Allow undefined single payment amounts.";
            this.chk_undefinedSinglePayment.UseVisualStyleBackColor = true;
            // 
            // chk_undefinedSubcription
            // 
            this.chk_undefinedSubcription.AutoSize = true;
            this.chk_undefinedSubcription.Location = new System.Drawing.Point(507, 19);
            this.chk_undefinedSubcription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chk_undefinedSubcription.Name = "chk_undefinedSubcription";
            this.chk_undefinedSubcription.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.chk_undefinedSubcription.Size = new System.Drawing.Size(233, 40);
            this.chk_undefinedSubcription.TabIndex = 3;
            this.chk_undefinedSubcription.Text = "Allow undefined subscription amounts.";
            this.chk_undefinedSubcription.UseVisualStyleBackColor = true;
            // 
            // btn_addOption
            // 
            this.btn_addOption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(214)))), ((int)(((byte)(223)))));
            this.btn_addOption.FlatAppearance.BorderSize = 0;
            this.btn_addOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addOption.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addOption.Location = new System.Drawing.Point(46, 19);
            this.btn_addOption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_addOption.Name = "btn_addOption";
            this.btn_addOption.Size = new System.Drawing.Size(162, 64);
            this.btn_addOption.TabIndex = 6;
            this.btn_addOption.Text = "Add Option";
            this.btn_addOption.UseVisualStyleBackColor = false;
            this.btn_addOption.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_addOption_MouseClick);
            // 
            // pnl_buttons
            // 
            this.pnl_buttons.Controls.Add(this.btn_addOption);
            this.pnl_buttons.Controls.Add(this.chk_undefinedSinglePayment);
            this.pnl_buttons.Controls.Add(this.chk_undefinedSubcription);
            this.pnl_buttons.Controls.Add(this.btn_confirm);
            this.pnl_buttons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_buttons.Location = new System.Drawing.Point(0, 537);
            this.pnl_buttons.Name = "pnl_buttons";
            this.pnl_buttons.Size = new System.Drawing.Size(1179, 111);
            this.pnl_buttons.TabIndex = 8;
            // 
            // editDonationOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_buttons);
            this.Controls.Add(this.pnl_options);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "editDonationOptions";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(1179, 648);
            this.pnl_buttons.ResumeLayout(false);
            this.pnl_buttons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel pnl_options;
        private List<DonationFlowPanel> donationGroupBoxes = new List<DonationFlowPanel>();
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.CheckBox chk_undefinedSinglePayment;
        private System.Windows.Forms.CheckBox chk_undefinedSubcription;
        private System.Windows.Forms.Button btn_addOption;
        private System.Windows.Forms.Panel pnl_buttons;
    }
}
