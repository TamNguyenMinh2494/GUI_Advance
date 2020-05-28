using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoDelegate
{
    public partial class TestLogin : Form
    {
        public TestLogin()
        {
            InitializeComponent();
            loginControl1.LoginClick += new LoginHandler(CheckLogin);
            loginControl1.LoginClick += CheckLogin;
        }

        public void CheckLogin(LoginControl sender, string user, string password)
        {
            if (!user.Equals(password))
            {
                //MessageBox.Show((!user.Equals(password)).ToString());
                MessageBox.Show("Login Failed");
            }
            else
            {
                MessageBox.Show("Login Succeeded!");
            }
        }
    }
}
