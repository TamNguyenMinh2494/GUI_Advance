namespace Example06
{
    partial class RegistrationForm
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
            this.profile1 = new Example06.Profile();
            this.SuspendLayout();
            // 
            // profile1
            // 
            this.profile1.Font = new System.Drawing.Font("Google Sans", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile1.Location = new System.Drawing.Point(14, 14);
            this.profile1.Margin = new System.Windows.Forms.Padding(5);
            this.profile1.Name = "profile1";
            this.profile1.Size = new System.Drawing.Size(538, 573);
            this.profile1.TabIndex = 0;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 601);
            this.Controls.Add(this.profile1);
            this.Name = "RegistrationForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Profile profile1;
    }
}

