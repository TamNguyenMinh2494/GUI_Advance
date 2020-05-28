namespace Example03
{
    partial class TestCalculation
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
            this.calculatorControl1 = new Example03.CalculatorControl();
            this.SuspendLayout();
            // 
            // calculatorControl1
            // 
            this.calculatorControl1.Font = new System.Drawing.Font("Google Sans", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatorControl1.Location = new System.Drawing.Point(97, 34);
            this.calculatorControl1.Margin = new System.Windows.Forms.Padding(5);
            this.calculatorControl1.Name = "calculatorControl1";
            this.calculatorControl1.Size = new System.Drawing.Size(610, 386);
            this.calculatorControl1.TabIndex = 0;
            // 
            // TestCalculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calculatorControl1);
            this.Name = "TestCalculation";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private CalculatorControl calculatorControl1;
    }
}

