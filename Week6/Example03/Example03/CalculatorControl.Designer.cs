namespace Example03
{
    partial class CalculatorControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbNum1 = new System.Windows.Forms.TextBox();
            this.btCalculator = new System.Windows.Forms.Button();
            this.tbNum2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number 1";
            // 
            // tbNum1
            // 
            this.tbNum1.Location = new System.Drawing.Point(226, 56);
            this.tbNum1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbNum1.Name = "tbNum1";
            this.tbNum1.Size = new System.Drawing.Size(276, 29);
            this.tbNum1.TabIndex = 1;
            // 
            // btCalculator
            // 
            this.btCalculator.Location = new System.Drawing.Point(226, 300);
            this.btCalculator.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btCalculator.Name = "btCalculator";
            this.btCalculator.Size = new System.Drawing.Size(125, 37);
            this.btCalculator.TabIndex = 2;
            this.btCalculator.Text = "Calculate";
            this.btCalculator.UseVisualStyleBackColor = true;
            // 
            // tbNum2
            // 
            this.tbNum2.Location = new System.Drawing.Point(226, 132);
            this.tbNum2.Margin = new System.Windows.Forms.Padding(5);
            this.tbNum2.Name = "tbNum2";
            this.tbNum2.Size = new System.Drawing.Size(276, 29);
            this.tbNum2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number 2";
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(226, 211);
            this.tbResult.Margin = new System.Windows.Forms.Padding(5);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(276, 29);
            this.tbResult.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 219);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Result";
            // 
            // CalculatorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNum2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btCalculator);
            this.Controls.Add(this.tbNum1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Google Sans", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "CalculatorControl";
            this.Size = new System.Drawing.Size(610, 386);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNum1;
        private System.Windows.Forms.Button btCalculator;
        private System.Windows.Forms.TextBox tbNum2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Label label3;
    }
}
