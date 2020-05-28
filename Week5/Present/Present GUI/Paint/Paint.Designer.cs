namespace Paint
{
    partial class Paint
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
            this.ctrlSketch = new ctrlSketch.SketchControl();
            this.btnColor = new System.Windows.Forms.Button();
            this.ctrlSketch.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlSketch
            // 
            this.ctrlSketch.Controls.Add(this.btnColor);
            this.ctrlSketch.Location = new System.Drawing.Point(3, 4);
            this.ctrlSketch.Name = "ctrlSketch";
            this.ctrlSketch.Size = new System.Drawing.Size(687, 350);
            this.ctrlSketch.TabIndex = 0;
            // 
            // btnColor
            // 
            this.btnColor.Font = new System.Drawing.Font("Google Sans", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColor.Location = new System.Drawing.Point(3, 3);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(62, 29);
            this.btnColor.TabIndex = 1;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 353);
            this.Controls.Add(this.ctrlSketch);
            this.Name = "Paint";
            this.Text = "My Paint";
            this.ctrlSketch.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlSketch.SketchControl ctrlSketch;
        private System.Windows.Forms.Button btnColor;
    }
}

