using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ctlLoginLib
{
    public partial class ctlLogin: UserControl
    {
        public ctlLogin()
        {
            InitializeComponent();
        }

        public virtual void BtnLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Login button is cliked!");
        }
    }
}
