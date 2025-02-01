namespace Driving_License_Management_Desktop_App
{
    partial class frmPersonDetails
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
            this.ctlPersonInformation1 = new Driving_License_Management_Desktop_App.ctlPersonInformation();
            this.SuspendLayout();
            // 
            // ctlPersonInformation1
            // 
            this.ctlPersonInformation1.Location = new System.Drawing.Point(12, 12);
            this.ctlPersonInformation1.Name = "ctlPersonInformation1";
            this.ctlPersonInformation1.Size = new System.Drawing.Size(660, 215);
            this.ctlPersonInformation1.TabIndex = 0;
            // 
            // frmPersonDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(668, 223);
            this.Controls.Add(this.ctlPersonInformation1);
            this.Name = "frmPersonDetails";
            this.Text = "frmPersonDetails";
            this.ResumeLayout(false);

        }

        #endregion

        private ctlPersonInformation ctlPersonInformation1;
    }
}