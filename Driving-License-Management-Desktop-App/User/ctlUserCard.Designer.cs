namespace Driving_License_Management_Desktop_App.User
{
    partial class ctlUserCard
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
            this.ctlloginInfo1 = new Driving_License_Management_Desktop_App.User.ctlloginInfo();
            this.ctlPersonInformation1 = new Driving_License_Management_Desktop_App.ctlPersonInformation();
            this.SuspendLayout();
            // 
            // ctlloginInfo1
            // 
            this.ctlloginInfo1.Location = new System.Drawing.Point(3, 213);
            this.ctlloginInfo1.Name = "ctlloginInfo1";
            this.ctlloginInfo1.Size = new System.Drawing.Size(632, 93);
            this.ctlloginInfo1.TabIndex = 0;
            // 
            // ctlPersonInformation1
            // 
            this.ctlPersonInformation1.Location = new System.Drawing.Point(3, 0);
            this.ctlPersonInformation1.Name = "ctlPersonInformation1";
            this.ctlPersonInformation1.Size = new System.Drawing.Size(632, 215);
            this.ctlPersonInformation1.TabIndex = 1;
            // 
            // ctlUserCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctlPersonInformation1);
            this.Controls.Add(this.ctlloginInfo1);
            this.Name = "ctlUserCard";
            this.Size = new System.Drawing.Size(643, 309);
            this.ResumeLayout(false);

        }

        #endregion

        private ctlloginInfo ctlloginInfo1;
        private ctlPersonInformation ctlPersonInformation1;
    }
}
