using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace Form1
{
    class NguyenMinhTam : Form
    {
        private Label lbUsername;
        private Label lbPassword;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Button btnLogin;
        public NguyenMinhTam()
        {
            //created label username
            lbUsername = new Label();
            lbUsername.Text = "User Name: ";
            lbUsername.Location = new Point(50, 20);
            lbUsername.AutoSize = true;
            Controls.Add(lbUsername);

            //created label password
            lbPassword = new Label();
            lbPassword.Text = "Passwod: ";
            lbPassword.Location = new Point(50, 70);
            lbPassword.AutoSize = true;
            Controls.Add(lbPassword);

            //created textbox username
            tbUsername = new TextBox();
            tbUsername.Location = new Point(150, 20);
            tbUsername.AutoSize = true;
            Controls.Add(tbUsername);

            //created textbox password
            tbPassword = new TextBox();
            tbPassword.Location = new Point(150, 70);
            tbPassword.AutoSize = true;
            Controls.Add(tbPassword);

            //created button login
            btnLogin = new Button();
            btnLogin.Location = new Point(90, 100);
            btnLogin.Text = "Login";
            btnLogin.ForeColor = Color.Blue;
            btnLogin.AutoSize = true;
            btnLogin.Click += BtnLogin_Click;
            Controls.Add(btnLogin);

            this.Text = "Form 1";
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            // open Form 2
            Form2 form2 = new Form2(tbUsername.Text, tbPassword.Text);
            form2.Show(); 
        }

        static void Main()
        {
            Application.Run(new NguyenMinhTam());
        }
    }

    class Form2: Form
    {
        private Label lbUsr;
        private Label lbPass;
        private Label lbResult;
        private Button btnClose;
        public Form2()
        {
            this.Text = "Form 2";
        }
        public Form2(String usr, String pass) : this()
        {
            lbUsr = new Label();
            lbUsr.ForeColor = Color.Black;
            lbUsr.Text = usr;
            lbUsr.Location = new Point(50, 20);
            Controls.Add(lbUsr);

            lbPass = new Label();
            lbPass.ForeColor = Color.Black;
            lbPass.Text = pass;
            lbPass.Location = new Point(50, 70);
            Controls.Add(lbPass);

            lbResult = new Label();
            lbResult.ForeColor = Color.Red;
            lbResult.Text = usr;
            lbResult.Location = new Point(90, 100);
            Controls.Add(lbResult);
            if (usr == pass)
            {
                lbResult.Text = "Login Failed!";

            }
            if(usr != pass)
            {
                lbResult.Text = "Login Succeeded!";
            }

            btnClose = new Button();
            btnClose.Location = new Point(100, 120);
            btnClose.Text = "Close";
            btnClose.Click += BtnClose_Click;
            Controls.Add(btnClose);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
