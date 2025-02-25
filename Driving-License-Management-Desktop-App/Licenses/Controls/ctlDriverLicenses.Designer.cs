namespace Driving_License_Management_Desktop_App.Licenses.Controls
{
    partial class ctlDriverLicenses
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
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblRecordCountLocal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvLocalLicenseHistory = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblCountInternational = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvInternationalLicenseHistory = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.cmsLocalLicenses = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showLicenseInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsInternationalLicenses = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showLicenseInfoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicenseHistory)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenseHistory)).BeginInit();
            this.cmsLocalLicenses.SuspendLayout();
            this.cmsInternationalLicenses.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(618, 307);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Driver Licenses";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(10, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(602, 257);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblRecordCountLocal);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dgvLocalLicenseHistory);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(594, 228);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Local";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblRecordCountLocal
            // 
            this.lblRecordCountLocal.AutoSize = true;
            this.lblRecordCountLocal.Location = new System.Drawing.Point(79, 196);
            this.lblRecordCountLocal.Name = "lblRecordCountLocal";
            this.lblRecordCountLocal.Size = new System.Drawing.Size(21, 16);
            this.lblRecordCountLocal.TabIndex = 6;
            this.lblRecordCountLocal.Text = "??";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "# Records:";
            // 
            // dgvLocalLicenseHistory
            // 
            this.dgvLocalLicenseHistory.AllowUserToAddRows = false;
            this.dgvLocalLicenseHistory.AllowUserToDeleteRows = false;
            this.dgvLocalLicenseHistory.AllowUserToResizeRows = false;
            this.dgvLocalLicenseHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalLicenseHistory.ContextMenuStrip = this.cmsLocalLicenses;
            this.dgvLocalLicenseHistory.Location = new System.Drawing.Point(9, 32);
            this.dgvLocalLicenseHistory.Name = "dgvLocalLicenseHistory";
            this.dgvLocalLicenseHistory.RowHeadersWidth = 51;
            this.dgvLocalLicenseHistory.RowTemplate.Height = 24;
            this.dgvLocalLicenseHistory.Size = new System.Drawing.Size(579, 157);
            this.dgvLocalLicenseHistory.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Local Licenses History:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblCountInternational);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.dgvInternationalLicenseHistory);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(594, 228);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "International";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblCountInternational
            // 
            this.lblCountInternational.AutoSize = true;
            this.lblCountInternational.Location = new System.Drawing.Point(79, 199);
            this.lblCountInternational.Name = "lblCountInternational";
            this.lblCountInternational.Size = new System.Drawing.Size(21, 16);
            this.lblCountInternational.TabIndex = 10;
            this.lblCountInternational.Text = "??";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "# Records:";
            // 
            // dgvInternationalLicenseHistory
            // 
            this.dgvInternationalLicenseHistory.AllowUserToAddRows = false;
            this.dgvInternationalLicenseHistory.AllowUserToDeleteRows = false;
            this.dgvInternationalLicenseHistory.AllowUserToResizeRows = false;
            this.dgvInternationalLicenseHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInternationalLicenseHistory.ContextMenuStrip = this.cmsInternationalLicenses;
            this.dgvInternationalLicenseHistory.Location = new System.Drawing.Point(9, 35);
            this.dgvInternationalLicenseHistory.Name = "dgvInternationalLicenseHistory";
            this.dgvInternationalLicenseHistory.RowHeadersWidth = 51;
            this.dgvInternationalLicenseHistory.RowTemplate.Height = 24;
            this.dgvInternationalLicenseHistory.Size = new System.Drawing.Size(579, 157);
            this.dgvInternationalLicenseHistory.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "International Licenses History:";
            // 
            // cmsLocalLicenses
            // 
            this.cmsLocalLicenses.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsLocalLicenses.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLicenseInfoToolStripMenuItem});
            this.cmsLocalLicenses.Name = "cmsLocalLicenses";
            this.cmsLocalLicenses.Size = new System.Drawing.Size(217, 32);
            // 
            // showLicenseInfoToolStripMenuItem
            // 
            this.showLicenseInfoToolStripMenuItem.Name = "showLicenseInfoToolStripMenuItem";
            this.showLicenseInfoToolStripMenuItem.Size = new System.Drawing.Size(216, 28);
            this.showLicenseInfoToolStripMenuItem.Text = "Show License Info";
            this.showLicenseInfoToolStripMenuItem.Click += new System.EventHandler(this.showLicenseInfoToolStripMenuItem_Click);
            // 
            // cmsInternationalLicenses
            // 
            this.cmsInternationalLicenses.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsInternationalLicenses.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLicenseInfoToolStripMenuItem1});
            this.cmsInternationalLicenses.Name = "cmsInternationalLicenses";
            this.cmsInternationalLicenses.Size = new System.Drawing.Size(217, 32);
            // 
            // showLicenseInfoToolStripMenuItem1
            // 
            this.showLicenseInfoToolStripMenuItem1.Name = "showLicenseInfoToolStripMenuItem1";
            this.showLicenseInfoToolStripMenuItem1.Size = new System.Drawing.Size(216, 28);
            this.showLicenseInfoToolStripMenuItem1.Text = "Show License Info";
            // 
            // ctlDriverLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox2);
            this.Name = "ctlDriverLicenses";
            this.Size = new System.Drawing.Size(638, 321);
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicenseHistory)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenseHistory)).EndInit();
            this.cmsLocalLicenses.ResumeLayout(false);
            this.cmsInternationalLicenses.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblRecordCountLocal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvLocalLicenseHistory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblCountInternational;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvInternationalLicenseHistory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ContextMenuStrip cmsLocalLicenses;
        private System.Windows.Forms.ToolStripMenuItem showLicenseInfoToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsInternationalLicenses;
        private System.Windows.Forms.ToolStripMenuItem showLicenseInfoToolStripMenuItem1;
    }
}
