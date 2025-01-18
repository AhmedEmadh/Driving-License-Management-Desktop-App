namespace Driving_License_Management_Desktop_App
{
    partial class frmManageDrivers
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
            this.ctlManagePersons1 = new Driving_License_Management_Desktop_App.ctlManagePersons();
            this.SuspendLayout();
            // 
            // ctlManagePersons1
            // 
            this.ctlManagePersons1.Location = new System.Drawing.Point(12, 12);
            this.ctlManagePersons1.Name = "ctlManagePersons1";
            this.ctlManagePersons1.SearchText = "";
            this.ctlManagePersons1.Size = new System.Drawing.Size(759, 442);
            this.ctlManagePersons1.TabIndex = 0;
            this.ctlManagePersons1.Value = "People";
            // 
            // frmManageDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ctlManagePersons1);
            this.Name = "frmManageDrivers";
            this.Text = "frmManageDrivers";
            this.Load += new System.EventHandler(this.frmManageDrivers_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctlManagePersons ctlManagePersons1;
    }
}