using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoDelegate
{
    public delegate void LoginHandler(LoginControl sender, string user, string password);
    public partial class LoginControl : UserControl
    {
        public LoginControl()
        {
            InitializeComponent();
        }
        public event LoginHandler LoginClick;
        protected virtual void OnLoginClick(string user, string password)
        {
            LoginClick?.Invoke(this, user, password);
        }
        public void BtnLogin_Click(Object sender, EventArgs e)
        {
            OnLoginClick(tbUsername.Text, tbPassword.Text);
        }
    }
}
