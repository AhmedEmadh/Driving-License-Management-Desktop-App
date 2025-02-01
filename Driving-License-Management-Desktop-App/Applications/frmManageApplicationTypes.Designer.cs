namespace Driving_License_Management_Desktop_App
{
    partial class frmManageApplicationTypes
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
            this.ctlShowData1 = new Driving_License_Management_Desktop_App.ctlShowData();
            this.SuspendLayout();
            // 
            // ctlShowData1
            // 
            this.ctlShowData1.Location = new System.Drawing.Point(23, -3);
            this.ctlShowData1.Name = "ctlShowData1";
            this.ctlShowData1.Size = new System.Drawing.Size(748, 441);
            this.ctlShowData1.TabIndex = 0;
            this.ctlShowData1.OnClose += new System.Action<object>(this.ctlShowData1_OnClose);
            // 
            // frmManageApplicationTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ctlShowData1);
            this.Name = "frmManageApplicationTypes";
            this.Text = "frmManageApplicationTypes";
            this.Load += new System.EventHandler(this.frmManageApplicationTypes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctlShowData ctlShowData1;
    }
}