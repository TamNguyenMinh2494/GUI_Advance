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
    public delegate void MessageSender(object sender, string message);
    public partial class FormSend : Form
    {
        public FormSend()
        {
            InitializeComponent();
        }

        public event MessageSender sendMessage;
        protected virtual void OnSendMessage(string msg)
        {
            sendMessage?.Invoke(this, msg);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            FormReceive formReceive = new FormReceive();
            formReceive.ReceiveMessage += SendMessage;
            formReceive.Show();
        }
        private string SendMessage(object sender)
        {
            return tbMessage.Text;
        }
    }
}
