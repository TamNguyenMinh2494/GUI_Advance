using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ctlLoginLib
{
    public partial class DBLogin : ctlLoginLib.ctlLogin
    {
        public DBLogin()
        {
            InitializeComponent();
        }

        public override void BtnLogin_Click(object sender, EventArgs e)
        {
            //base.BtnLogin_Click(sender, e);
            if (tbUsername.Text.Trim().Equals(tbPassword.Text.Trim()))
            {
                MessageBox.Show("login success!");
            }
        }
    }
}
