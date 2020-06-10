namespace ExersiseEF
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryExit = new System.Windows.Forms.ToolStripMenuItem();
            this.query01 = new System.Windows.Forms.ToolStripMenuItem();
            this.query02 = new System.Windows.Forms.ToolStripMenuItem();
            this.query03 = new System.Windows.Forms.ToolStripMenuItem();
            this.query04 = new System.Windows.Forms.ToolStripMenuItem();
            this.query05 = new System.Windows.Forms.ToolStripMenuItem();
            this.queryInsert = new System.Windows.Forms.ToolStripMenuItem();
            this.queryUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.queryDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.queriesToolStripMenuItem,
            this.changeDataToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 426);
            this.dataGridView1.TabIndex = 1;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.queryExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // queriesToolStripMenuItem
            // 
            this.queriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.query01,
            this.query02,
            this.query03,
            this.query04,
            this.query05});
            this.queriesToolStripMenuItem.Name = "queriesToolStripMenuItem";
            this.queriesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.queriesToolStripMenuItem.Text = "Queries";
            // 
            // changeDataToolStripMenuItem
            // 
            this.changeDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.queryInsert,
            this.queryUpdate,
            this.queryDelete});
            this.changeDataToolStripMenuItem.Name = "changeDataToolStripMenuItem";
            this.changeDataToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.changeDataToolStripMenuItem.Text = "Change Data";
            // 
            // queryExit
            // 
            this.queryExit.Name = "queryExit";
            this.queryExit.Size = new System.Drawing.Size(180, 22);
            this.queryExit.Text = "Exit";
            this.queryExit.Click += new System.EventHandler(this.queryExit_Click);
            // 
            // query01
            // 
            this.query01.Name = "query01";
            this.query01.Size = new System.Drawing.Size(234, 22);
            this.query01.Text = "Column A desc, Column B asc";
            this.query01.Click += new System.EventHandler(this.query01_Click);
            // 
            // query02
            // 
            this.query02.Name = "query02";
            this.query02.Size = new System.Drawing.Size(234, 22);
            this.query02.Text = "Filter by name";
            this.query02.Click += new System.EventHandler(this.query02_Click);
            // 
            // query03
            // 
            this.query03.Name = "query03";
            this.query03.Size = new System.Drawing.Size(234, 22);
            this.query03.Text = "Count";
            this.query03.Click += new System.EventHandler(this.query03_Click);
            // 
            // query04
            // 
            this.query04.Name = "query04";
            this.query04.Size = new System.Drawing.Size(234, 22);
            this.query04.Text = "Max/Min";
            this.query04.Click += new System.EventHandler(this.query04_Click);
            // 
            // query05
            // 
            this.query05.Name = "query05";
            this.query05.Size = new System.Drawing.Size(234, 22);
            this.query05.Text = "Group by Category";
            this.query05.Click += new System.EventHandler(this.query05_Click);
            // 
            // queryInsert
            // 
            this.queryInsert.Name = "queryInsert";
            this.queryInsert.Size = new System.Drawing.Size(180, 22);
            this.queryInsert.Text = "Insert";
            this.queryInsert.Click += new System.EventHandler(this.queryInsert_Click);
            // 
            // queryUpdate
            // 
            this.queryUpdate.Name = "queryUpdate";
            this.queryUpdate.Size = new System.Drawing.Size(180, 22);
            this.queryUpdate.Text = "Update";
            this.queryUpdate.Click += new System.EventHandler(this.queryUpdate_Click);
            // 
            // queryDelete
            // 
            this.queryDelete.Name = "queryDelete";
            this.queryDelete.Size = new System.Drawing.Size(180, 22);
            this.queryDelete.Text = "Delete";
            this.queryDelete.Click += new System.EventHandler(this.queryDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryExit;
        private System.Windows.Forms.ToolStripMenuItem queriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem query01;
        private System.Windows.Forms.ToolStripMenuItem changeDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem query02;
        private System.Windows.Forms.ToolStripMenuItem query03;
        private System.Windows.Forms.ToolStripMenuItem query04;
        private System.Windows.Forms.ToolStripMenuItem query05;
        private System.Windows.Forms.ToolStripMenuItem queryInsert;
        private System.Windows.Forms.ToolStripMenuItem queryUpdate;
        private System.Windows.Forms.ToolStripMenuItem queryDelete;
    }
}

