using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example03
{
    public partial class TestCalculation : Form
    {
        public TestCalculation()
        {
            InitializeComponent();
            calculatorControl1.calculate = Add;
            calculatorControl1.CalculateName = calculatorControl1.calculate.GetMethodInfo().Name;
        }
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
