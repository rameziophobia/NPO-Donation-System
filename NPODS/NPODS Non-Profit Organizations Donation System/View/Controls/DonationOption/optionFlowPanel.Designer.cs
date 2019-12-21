namespace NPODS_Non_Profit_Organizations_Donation_System
{
    partial class optionFlowPanel
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
            this.pnl_donateOptions = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_removeOption = new System.Windows.Forms.Label();
            this.cbo_donationOption0 = new System.Windows.Forms.ComboBox();
            this.txt_value0 = new System.Windows.Forms.TextBox();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.pnl_donateOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_donateOptions
            // 
            this.pnl_donateOptions.Controls.Add(this.lbl_removeOption);
            this.pnl_donateOptions.Controls.Add(this.cbo_donationOption0);
            this.pnl_donateOptions.Controls.Add(this.txt_value0);
            this.pnl_donateOptions.Controls.Add(this.txt_description);
            this.pnl_donateOptions.ForeColor = System.Drawing.SystemColors.Control;
            this.pnl_donateOptions.Location = new System.Drawing.Point(2, 1);
            this.pnl_donateOptions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_donateOptions.Name = "pnl_donateOptions";
            this.pnl_donateOptions.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_donateOptions.Size = new System.Drawing.Size(1104, 53);
            this.pnl_donateOptions.TabIndex = 3;
            // 
            // lbl_removeOption
            // 
            this.lbl_removeOption.AutoSize = true;
            this.lbl_removeOption.BackColor = System.Drawing.Color.DarkRed;
            this.lbl_removeOption.Location = new System.Drawing.Point(8, 17);
            this.lbl_removeOption.Margin = new System.Windows.Forms.Padding(5, 13, 5, 5);
            this.lbl_removeOption.Name = "lbl_removeOption";
            this.lbl_removeOption.Size = new System.Drawing.Size(14, 13);
            this.lbl_removeOption.TabIndex = 4;
            this.lbl_removeOption.Text = "X";
            // 
            // cbo_donationOption0
            // 
            this.cbo_donationOption0.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbo_donationOption0.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_donationOption0.FormattingEnabled = true;
            this.cbo_donationOption0.Items.AddRange(new object[] {
            "Subscription",
            "Single Payment",
            "Miscellaneous"});
            this.cbo_donationOption0.Location = new System.Drawing.Point(32, 9);
            this.cbo_donationOption0.Margin = new System.Windows.Forms.Padding(5);
            this.cbo_donationOption0.Name = "cbo_donationOption0";
            this.cbo_donationOption0.Size = new System.Drawing.Size(210, 32);
            this.cbo_donationOption0.TabIndex = 0;
            // 
            // txt_value0
            // 
            this.txt_value0.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_value0.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_value0.Location = new System.Drawing.Point(252, 9);
            this.txt_value0.Margin = new System.Windows.Forms.Padding(5);
            this.txt_value0.Name = "txt_value0";
            this.txt_value0.Size = new System.Drawing.Size(114, 33);
            this.txt_value0.TabIndex = 1;
            this.txt_value0.Text = "Value";
            // 
            // txt_description
            // 
            this.txt_description.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_description.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_description.Location = new System.Drawing.Point(376, 9);
            this.txt_description.Margin = new System.Windows.Forms.Padding(5);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(718, 32);
            this.txt_description.TabIndex = 5;
            this.txt_description.Text = "Description";
            // 
            // optionFlowPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.pnl_donateOptions);
            this.Name = "optionFlowPanel";
            this.Size = new System.Drawing.Size(1109, 58);
            this.pnl_donateOptions.ResumeLayout(false);
            this.pnl_donateOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnl_donateOptions;
        private System.Windows.Forms.Label lbl_removeOption;
        private System.Windows.Forms.ComboBox cbo_donationOption0;
        private System.Windows.Forms.TextBox txt_value0;
        private System.Windows.Forms.TextBox txt_description;
    }
}
