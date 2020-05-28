using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example02
{
    public delegate int Calculate(int a, int b);
    public partial class Form1 : Form
    {
        public Calculate calculate;
        public Form1()
        {
            InitializeComponent();
            calculate = new Calculate(Add);
            
        }
        public int Add(int a, int b)
        {
            return a + b;
        }
        private void tbNum1_TextChanged(object sender, EventArgs e)
        {
            int x = 0;
            Int32.TryParse(tbNum1.Text, out x);
            int y = 0;
            Int32.TryParse(tbNum2.Text, out y);
            tbResult.Text=calculate?.Invoke(x, y).ToString();
        }

        private void tbNum2_TextChanged(object sender, EventArgs e)
        {
            int x = 0;
            Int32.TryParse(tbNum1.Text, out x);
            int y = 0;
            Int32.TryParse(tbNum2.Text, out y);
            tbResult.Text = calculate?.Invoke(x, y).ToString();
        }
    }
}