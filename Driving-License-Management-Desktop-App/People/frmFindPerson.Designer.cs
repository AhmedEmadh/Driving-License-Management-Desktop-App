namespace Driving_License_Management_Desktop_App.People
{
    partial class frmFindPerson
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ctlPersonInformationWithFilter1 = new Driving_License_Management_Desktop_App.ctlPersonInformationWithFilter();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(253, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(235, 46);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Find Person";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(638, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ctlPersonInformationWithFilter1
            // 
            this.ctlPersonInformationWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctlPersonInformationWithFilter1.FilterEnabled = true;
            this.ctlPersonInformationWithFilter1.Location = new System.Drawing.Point(35, 86);
            this.ctlPersonInformationWithFilter1.Name = "ctlPersonInformationWithFilter1";
            this.ctlPersonInformationWithFilter1.PersonID = -1;
            this.ctlPersonInformationWithFilter1.SearchText = "";
            this.ctlPersonInformationWithFilter1.SelectedIndex = 0;
            this.ctlPersonInformationWithFilter1.ShowAddPersonButton = true;
            this.ctlPersonInformationWithFilter1.Size = new System.Drawing.Size(652, 279);
            this.ctlPersonInformationWithFilter1.TabIndex = 2;
            // 
            // frmFindPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ctlPersonInformationWithFilter1);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmFindPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFindPerson";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmFindPerson_FormClosed);
            this.Load += new System.EventHandler(this.frmFindPerson_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private ctlPersonInformationWithFilter ctlPersonInformationWithFilter1;
        private System.Windows.Forms.Button button1;
    }
}