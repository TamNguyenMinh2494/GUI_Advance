using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example03
{
    public delegate int Calculation(int a, int b);
    public partial class CalculatorControl : UserControl
    {
        public Calculation calculate;

        public CalculatorControl()
        {
            InitializeComponent();
            btCalculator.Click += BtCalculator_Click;
            //calculator = Add;
        }
        public string CalculateName
        {
            set { btCalculator.Name = value; }
        }
        private void BtCalculator_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            int.TryParse(tbNum1.Text, out num1);
            int.TryParse(tbNum2.Text, out num2);
            tbResult.Text = calculate?.Invoke(num1, num2).ToString();
        }
        //public int Add(int a, int b)
        //{
        //    return a + b;
        //}
    }
}
