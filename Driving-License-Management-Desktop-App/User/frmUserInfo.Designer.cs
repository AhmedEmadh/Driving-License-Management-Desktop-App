namespace Driving_License_Management_Desktop_App.User
{
    partial class frmUserInfo
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
            this.button1 = new System.Windows.Forms.Button();
            this.ctlUserCard1 = new Driving_License_Management_Desktop_App.User.ctlUserCard();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(560, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ctlUserCard1
            // 
            this.ctlUserCard1.Location = new System.Drawing.Point(13, 13);
            this.ctlUserCard1.Name = "ctlUserCard1";
            this.ctlUserCard1.Size = new System.Drawing.Size(643, 309);
            this.ctlUserCard1.TabIndex = 3;
            // 
            // frmUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(664, 385);
            this.Controls.Add(this.ctlUserCard1);
            this.Controls.Add(this.button1);
            this.Name = "frmUserInfo";
            this.Text = "frmUserInfo";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private ctlUserCard ctlUserCard1;
    }
}