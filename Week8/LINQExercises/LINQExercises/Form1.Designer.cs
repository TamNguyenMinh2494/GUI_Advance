namespace LINQExercises
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
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.searchQUICK = new System.Windows.Forms.Button();
            this.btnOrderWithID = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrders
            // 
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvOrders.Location = new System.Drawing.Point(0, 0);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.Size = new System.Drawing.Size(800, 370);
            this.dgvOrders.TabIndex = 0;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(178, 390);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(100, 20);
            this.tbSearch.TabIndex = 1;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // searchQUICK
            // 
            this.searchQUICK.Location = new System.Drawing.Point(308, 387);
            this.searchQUICK.Name = "searchQUICK";
            this.searchQUICK.Size = new System.Drawing.Size(75, 23);
            this.searchQUICK.TabIndex = 2;
            this.searchQUICK.Text = "QUICK";
            this.searchQUICK.UseVisualStyleBackColor = true;
            this.searchQUICK.Click += new System.EventHandler(this.searchQUICK_Click);
            // 
            // btnOrderWithID
            // 
            this.btnOrderWithID.Location = new System.Drawing.Point(402, 387);
            this.btnOrderWithID.Name = "btnOrderWithID";
            this.btnOrderWithID.Size = new System.Drawing.Size(96, 23);
            this.btnOrderWithID.TabIndex = 3;
            this.btnOrderWithID.Text = "Order with ID";
            this.btnOrderWithID.UseVisualStyleBackColor = true;
            this.btnOrderWithID.Click += new System.EventHandler(this.btnOrderWithID_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(522, 387);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(113, 23);
            this.btnTotal.TabIndex = 4;
            this.btnTotal.Text = "Total of OrderID";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnOrderWithID);
            this.Controls.Add(this.searchQUICK);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.dgvOrders);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button searchQUICK;
        private System.Windows.Forms.Button btnOrderWithID;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Label label1;
    }
}

