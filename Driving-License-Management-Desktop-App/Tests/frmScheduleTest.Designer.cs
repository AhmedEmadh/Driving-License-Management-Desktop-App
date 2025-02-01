namespace Driving_License_Management_Desktop_App
{
    partial class frmScheduleTest
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
            this.button2 = new System.Windows.Forms.Button();
            this.ctlScheduleTest1 = new Driving_License_Management_Desktop_App.Tests.Controls.ctlScheduleTest();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(248, 468);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 45);
            this.button2.TabIndex = 8;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ctlScheduleTest1
            // 
            this.ctlScheduleTest1.Location = new System.Drawing.Point(13, 13);
            this.ctlScheduleTest1.Name = "ctlScheduleTest1";
            this.ctlScheduleTest1.Size = new System.Drawing.Size(348, 449);
            this.ctlScheduleTest1.TabIndex = 9;
            // 
            // frmScheduleTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(366, 525);
            this.Controls.Add(this.ctlScheduleTest1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "frmScheduleTest";
            this.Text = "frmScheduleTest";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Tests.Controls.ctlScheduleTest ctlScheduleTest1;
    }
}