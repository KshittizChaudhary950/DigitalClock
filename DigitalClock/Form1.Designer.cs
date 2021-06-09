
namespace DigitalClock
{
    partial class Form1
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
            this.lblTime = new System.Windows.Forms.Label();
            this.lblsecond = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labampm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.DimGray;
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTime.Font = new System.Drawing.Font("MV Boli", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Lime;
            this.lblTime.Location = new System.Drawing.Point(5, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(347, 127);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "22:22";
            // 
            // lblsecond
            // 
            this.lblsecond.AutoSize = true;
            this.lblsecond.BackColor = System.Drawing.Color.DimGray;
            this.lblsecond.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblsecond.Font = new System.Drawing.Font("Matura MT Script Capitals", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsecond.ForeColor = System.Drawing.Color.Lime;
            this.lblsecond.Location = new System.Drawing.Point(358, 84);
            this.lblsecond.Name = "lblsecond";
            this.lblsecond.Size = new System.Drawing.Size(58, 52);
            this.lblsecond.TabIndex = 0;
            this.lblsecond.Text = "22";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.DimGray;
            this.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDate.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Lime;
            this.lblDate.Location = new System.Drawing.Point(70, 148);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(346, 65);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "9 June 2021";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.BackColor = System.Drawing.Color.DimGray;
            this.lblDay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDay.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.ForeColor = System.Drawing.Color.Lime;
            this.lblDay.Location = new System.Drawing.Point(205, 225);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(216, 51);
            this.lblDay.TabIndex = 0;
            this.lblDay.Text = "Wednesday";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labampm
            // 
            this.labampm.AutoSize = true;
            this.labampm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labampm.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labampm.ForeColor = System.Drawing.Color.Lime;
            this.labampm.Location = new System.Drawing.Point(358, 34);
            this.labampm.Name = "labampm";
            this.labampm.Size = new System.Drawing.Size(63, 36);
            this.labampm.TabIndex = 1;
            this.labampm.Text = "AM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(436, 303);
            this.Controls.Add(this.labampm);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblsecond);
            this.Controls.Add(this.lblTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblsecond;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labampm;
    }
}

