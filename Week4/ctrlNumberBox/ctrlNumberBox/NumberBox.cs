using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ctrlNumberBox
{
    public partial class NumberBox: TextBox
    {
        //private TextBox tbNumBox;
        public NumberBox()
        {
            InitializeComponent();
            //tbNumBox = new TextBox();
            //tbNumBox.Text = "";
            //tbNumBox.Size = new Size(50, 50);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            //base.OnKeyPress(e);
            if(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || (e.KeyChar == '.' && !this.Text.Contains('.')))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
