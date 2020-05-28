using System.Drawing;

namespace ctlClock
{
    partial class UserControl1
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
            this.lbTimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.Font = new System.Drawing.Font("Google Sans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimer.Location = new System.Drawing.Point(18, 25);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(81, 25);
            this.lbTimer.TabIndex = 0;
            this.lbTimer.Text = "lbTimer";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbTimer);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(301, 138);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.Timer timer1;

        private Color colFColor; 
        private Color colBColor;

        public Color TextBackColor
        {
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
        public Color TextForceColor
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
    }
}
