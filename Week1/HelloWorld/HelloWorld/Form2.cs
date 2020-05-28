using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace HelloWorld
{
    public partial class Form2 : Form
    {
        private Label label;
        public Form2()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            
            
        }

        public Form2(String info)
        {
            //this.Text = "Form 2";
            label = new Label();
            label.ForeColor = Color.Black;
            label.Text = info;
            
            Controls.Add(label);
        }
    }
}
