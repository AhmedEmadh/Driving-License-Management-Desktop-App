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
            this.btnHiddenClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctlPersonInformation1
            // 
            this.ctlPersonInformation1.BackColor = System.Drawing.Color.White;
            this.ctlPersonInformation1.Location = new System.Drawing.Point(12, 12);
            this.ctlPersonInformation1.Name = "ctlPersonInformation1";
            this.ctlPersonInformation1.PersonID = -1;
            this.ctlPersonInformation1.PersonNationalNo = "";
            this.ctlPersonInformation1.Size = new System.Drawing.Size(640, 210);
            this.ctlPersonInformation1.TabIndex = 0;
            // 
            // btnHiddenClose
            // 
            this.btnHiddenClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHiddenClose.Location = new System.Drawing.Point(558, 258);
            this.btnHiddenClose.Name = "btnHiddenClose";
            this.btnHiddenClose.Size = new System.Drawing.Size(75, 23);
            this.btnHiddenClose.TabIndex = 1;
            this.btnHiddenClose.Text = "close";
            this.btnHiddenClose.UseVisualStyleBackColor = true;
            this.btnHiddenClose.Click += new System.EventHandler(this.btnHiddenClose_Click);
            // 
            // frmPersonDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnHiddenClose;
            this.ClientSize = new System.Drawing.Size(650, 218);
            this.Controls.Add(this.btnHiddenClose);
            this.Controls.Add(this.ctlPersonInformation1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPersonDetails";
            this.Text = "frmPersonDetails";
            this.Load += new System.EventHandler(this.frmPersonDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctlPersonInformation ctlPersonInformation1;
        private System.Windows.Forms.Button btnHiddenClose;
    }
}