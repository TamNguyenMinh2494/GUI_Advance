namespace Example01
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
            this.studentInformationControl1 = new Example01.StudentInformationControl();
            this.SuspendLayout();
            // 
            // studentInformationControl1
            // 
            this.studentInformationControl1.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentInformationControl1.Location = new System.Drawing.Point(13, 14);
            this.studentInformationControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.studentInformationControl1.Name = "studentInformationControl1";
            this.studentInformationControl1.Size = new System.Drawing.Size(555, 423);
            this.studentInformationControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 450);
            this.Controls.Add(this.studentInformationControl1);
            this.Name = "Form1";
            this.Text = "Student Information";
            this.ResumeLayout(false);

        }

        #endregion

        private StudentInformationControl studentInformationControl1;
    }
}

