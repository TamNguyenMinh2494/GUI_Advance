using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example05
{
    public delegate string MessageReceive(object sender);
    public partial class FormReceive : Form
    {
        public FormReceive()
        {
            InitializeComponent();

        }
        public event MessageReceive ReceiveMessage;

        protected virtual void OnReceiveMessage()
        {
            tbMessage.Text = ReceiveMessage?.Invoke(this);
        }

        private void FormReceive_Load(object sender, EventArgs e)
        {
            OnReceiveMessage();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
