namespace NPODS_Non_Profit_Organizations_Donation_System
{
    partial class org_card
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
            this.organization1 = new NPODS_Non_Profit_Organizations_Donation_System.Organization();
            this.SuspendLayout();
            // 
            // organization1
            // 
            this.organization1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.organization1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.organization1.Location = new System.Drawing.Point(197, 72);
            this.organization1.Name = "organization1";
            this.organization1.Size = new System.Drawing.Size(1275, 349);
            this.organization1.TabIndex = 0;
            // 
            // org_card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.organization1);
            this.Name = "org_card";
            this.Size = new System.Drawing.Size(1627, 626);
            this.Load += new System.EventHandler(this.Org_card_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Organization organization1;
    }
}
