using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Paint : Form
    {
        public Paint()
        {
            InitializeComponent();
        }
        private void BtnColor_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Dialog Form");
            ColorDialog colorDialog = new ColorDialog();
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                ctrlSketch.DrawWithColor(colorDialog.Color);
            }
        }
        //private Point pointA;
        //Graphics graphics;

        //private void Paint_MouseDown(object sender, MouseEventArgs e)
        //{
        //    MessageBox.Show("Mouse Down Paint runned");
        //    pointA = e.Location;
        //}
    }
}
