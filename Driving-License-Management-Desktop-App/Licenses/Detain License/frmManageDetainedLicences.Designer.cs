namespace Driving_License_Management_Desktop_App
{
    partial class frmManageDetainedLicences
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
            this.ctlFormTitle1 = new Driving_License_Management_Desktop_App.ctlFormTitle();
            this.ctlShowDataWithFilter1 = new Driving_License_Management_Desktop_App.ctlShowDataWithFilter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.releaseDetainedLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctlFormTitle1
            // 
            this.ctlFormTitle1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ctlFormTitle1.BackColor = System.Drawing.Color.White;
            this.ctlFormTitle1.Location = new System.Drawing.Point(28, 12);
            this.ctlFormTitle1.Name = "ctlFormTitle1";
            this.ctlFormTitle1.picture = null;
            this.ctlFormTitle1.Size = new System.Drawing.Size(760, 123);
            this.ctlFormTitle1.TabIndex = 0;
            this.ctlFormTitle1.titleName = "Manage Detained Licenses";
            // 
            // ctlShowDataWithFilter1
            // 
            this.ctlShowDataWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctlShowDataWithFilter1.contextMenuStrip = null;
            this.ctlShowDataWithFilter1.Location = new System.Drawing.Point(28, 138);
            this.ctlShowDataWithFilter1.Name = "ctlShowDataWithFilter1";
            this.ctlShowDataWithFilter1.Size = new System.Drawing.Size(759, 350);
            this.ctlShowDataWithFilter1.TabIndex = 1;
            this.ctlShowDataWithFilter1.OnClose += new System.Action<object>(this.ctlShowDataWithFilter1_OnClose);
            this.ctlShowDataWithFilter1.Load += new System.EventHandler(this.ctlShowDataWithFilter1_Load);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonDetailsToolStripMenuItem,
            this.showLicenseDetailsToolStripMenuItem,
            this.showPersonLicenseHistoryToolStripMenuItem,
            this.toolStripMenuItem1,
            this.releaseDetainedLicenseToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(296, 122);
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            this.showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            this.showPersonDetailsToolStripMenuItem.Size = new System.Drawing.Size(295, 28);
            this.showPersonDetailsToolStripMenuItem.Text = "Show Person Details";
            // 
            // showLicenseDetailsToolStripMenuItem
            // 
            this.showLicenseDetailsToolStripMenuItem.Name = "showLicenseDetailsToolStripMenuItem";
            this.showLicenseDetailsToolStripMenuItem.Size = new System.Drawing.Size(295, 28);
            this.showLicenseDetailsToolStripMenuItem.Text = "Show License Details";
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(295, 28);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(292, 6);
            // 
            // releaseDetainedLicenseToolStripMenuItem
            // 
            this.releaseDetainedLicenseToolStripMenuItem.Name = "releaseDetainedLicenseToolStripMenuItem";
            this.releaseDetainedLicenseToolStripMenuItem.Size = new System.Drawing.Size(295, 28);
            this.releaseDetainedLicenseToolStripMenuItem.Text = "Release Detained License";
            // 
            // frmManageDetainedLicences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.ctlShowDataWithFilter1);
            this.Controls.Add(this.ctlFormTitle1);
            this.Name = "frmManageDetainedLicences";
            this.Text = "frmManageDetainedLicences";
            this.Load += new System.EventHandler(this.frmManageDetainedLicences_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ctlFormTitle ctlFormTitle1;
        private ctlShowDataWithFilter ctlShowDataWithFilter1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem releaseDetainedLicenseToolStripMenuItem;
    }
}