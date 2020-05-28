using System.Drawing;
using System;
namespace ctlClockLib
{
    partial class ctlAlarmClock
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpSetAlarm = new System.Windows.Forms.DateTimePicker();
            this.btnDisable = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTimer = new System.Windows.Forms.Label();
            this.lbAlarm = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbYourAlarm = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbAlarm);
            this.panel1.Controls.Add(this.lbTimer);
            this.panel1.Controls.Add(this.btnDisable);
            this.panel1.Location = new System.Drawing.Point(85, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 100);
            this.panel1.TabIndex = 0;
            // 
            // dtpSetAlarm
            // 
            this.dtpSetAlarm.Location = new System.Drawing.Point(308, 180);
            this.dtpSetAlarm.Name = "dtpSetAlarm";
            this.dtpSetAlarm.Size = new System.Drawing.Size(200, 20);
            this.dtpSetAlarm.TabIndex = 1;
            // 
            // btnDisable
            // 
            this.btnDisable.Font = new System.Drawing.Font("Google Sans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisable.Location = new System.Drawing.Point(240, 48);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(200, 37);
            this.btnDisable.TabIndex = 0;
            this.btnDisable.Text = "Disable Alarm";
            this.btnDisable.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Google Sans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Set Alarm Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Google Sans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(303, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Alarm time is:";
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.Font = new System.Drawing.Font("Google Sans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimer.Location = new System.Drawing.Point(62, 48);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(81, 25);
            this.lbTimer.TabIndex = 4;
            this.lbTimer.Text = "lbTimer";
            // 
            // lbAlarm
            // 
            this.lbAlarm.AutoSize = true;
            this.lbAlarm.BackColor = System.Drawing.Color.Red;
            this.lbAlarm.Font = new System.Drawing.Font("Google Sans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAlarm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbAlarm.Location = new System.Drawing.Point(163, 0);
            this.lbAlarm.Name = "lbAlarm";
            this.lbAlarm.Size = new System.Drawing.Size(92, 25);
            this.lbAlarm.TabIndex = 5;
            this.lbAlarm.Text = "ALARM!!!";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbYourAlarm
            // 
            this.lbYourAlarm.AutoSize = true;
            this.lbYourAlarm.Font = new System.Drawing.Font("Google Sans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYourAlarm.Location = new System.Drawing.Point(445, 214);
            this.lbYourAlarm.Name = "lbYourAlarm";
            this.lbYourAlarm.Size = new System.Drawing.Size(65, 25);
            this.lbYourAlarm.TabIndex = 4;
            this.lbYourAlarm.Text = "label5";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbYourAlarm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpSetAlarm);
            this.Controls.Add(this.panel1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(608, 270);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbAlarm;
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.Button btnDisable;
        private System.Windows.Forms.DateTimePicker dtpSetAlarm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbYourAlarm;

        private Color colFColor; // color for foreground color
        private Color colBColor; // color for background color
        private DateTime dteAlarmTime;
        private bool blnAlarmSet;
        public Color ClockBackColor
        {
            //get => colBColor;
            get
            {
                return colBColor;
            }

            set
            {
                colBColor = value;
                lbTimer.BackColor = colBColor;
                lbTimer.BackColor = colBColor;
            }
        }
        public Color ClockForceColor
        {
            get
            {
                return colFColor;
            }
            set
            {
                colFColor = value;
                lbTimer.ForeColor = colFColor;
                lbTimer.ForeColor = colFColor;
            }
        }
        public DateTime AlarmTime
        {
            get
            {
                return dteAlarmTime;
            }
            set
            {
                dteAlarmTime = value;
            }
        }
        public bool AlarmSet
        {
            get
            {
                return blnAlarmSet;
            }
            set
            {
                blnAlarmSet = value;
            }
        }
    }
}
