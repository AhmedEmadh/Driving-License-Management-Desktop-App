namespace Driving_License_Management_Desktop_App
{
    partial class frmShowLicenseHistory
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showLicenseInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.ctlPersonInformationWithFilter1 = new Driving_License_Management_Desktop_App.ctlPersonInformationWithFilter();
            this.ctlDriverLicenses1 = new Driving_License_Management_Desktop_App.Licenses.Controls.ctlDriverLicenses();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLicenseInfoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(217, 32);
            // 
            // showLicenseInfoToolStripMenuItem
            // 
            this.showLicenseInfoToolStripMenuItem.Name = "showLicenseInfoToolStripMenuItem";
            this.showLicenseInfoToolStripMenuItem.Size = new System.Drawing.Size(216, 28);
            this.showLicenseInfoToolStripMenuItem.Text = "Show License Info";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(576, 634);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(543, 663);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(89, 40);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctlPersonInformationWithFilter1
            // 
            this.ctlPersonInformationWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctlPersonInformationWithFilter1.FilterEnabled = true;
            this.ctlPersonInformationWithFilter1.Location = new System.Drawing.Point(12, 12);
            this.ctlPersonInformationWithFilter1.Name = "ctlPersonInformationWithFilter1";
            this.ctlPersonInformationWithFilter1.PersonID = -1;
            this.ctlPersonInformationWithFilter1.SearchText = "";
            this.ctlPersonInformationWithFilter1.SelectedIndex = 0;
            this.ctlPersonInformationWithFilter1.ShowAddPersonButton = true;
            this.ctlPersonInformationWithFilter1.Size = new System.Drawing.Size(652, 279);
            this.ctlPersonInformationWithFilter1.TabIndex = 5;
            // 
            // ctlDriverLicenses1
            // 
            this.ctlDriverLicenses1.BackColor = System.Drawing.Color.White;
            this.ctlDriverLicenses1.DriverID = 0;
            this.ctlDriverLicenses1.Location = new System.Drawing.Point(12, 339);
            this.ctlDriverLicenses1.Name = "ctlDriverLicenses1";
            this.ctlDriverLicenses1.Size = new System.Drawing.Size(638, 321);
            this.ctlDriverLicenses1.TabIndex = 4;
            // 
            // frmShowLicenseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(654, 719);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctlPersonInformationWithFilter1);
            this.Controls.Add(this.ctlDriverLicenses1);
            this.Controls.Add(this.button3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShowLicenseHistory";
            this.Text = "frmShowLicenseHistory";
            this.Load += new System.EventHandler(this.frmShowLicenseHistory_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showLicenseInfoToolStripMenuItem;
        private Licenses.Controls.ctlDriverLicenses ctlDriverLicenses1;
        private ctlPersonInformationWithFilter ctlPersonInformationWithFilter1;
        private System.Windows.Forms.Button btnClose;
    }
}