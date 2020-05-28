using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example04
{
    public delegate void LoginHandler(Object sender, string username, string password);

    public partial class LoginControl : UserControl
    {
        public event LoginHandler Login;
        public LoginControl()
        {
            InitializeComponent();
        }
        public virtual void OnButtonLoginClick(string username, string password)
        {
            Login?.Invoke(this, username, password);
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            OnButtonLoginClick(tbUsername.Text, tbPassword.Text);
        }
    }
}
