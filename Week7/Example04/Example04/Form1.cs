using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loginControl1.Login += LoginControl1_Login;
        }

        private void LoginControl1_Login(object sender, string username, string password)
        {
            if (username.Equals(password))
            {
                MessageBox.Show("Login Succeeded!");
            }
            else
            {
                MessageBox.Show("Login Failed!");
            }
        }
    }
}
