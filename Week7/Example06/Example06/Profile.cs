using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example06
{
    public delegate void Validation(object sender, Person person);
    public partial class Profile : UserControl
    {
        public Profile()
        {
            InitializeComponent();
        }
        public event Validation Validate;
        protected virtual void OnValidate()
        {
            Person person = new Person() {
               name = tbName.Text,
               dob = tbDob.Text,
               addr = tbAddr.Text,
               phone = tbPhone.Text,
               email = tbEmail.Text
            };
            Validate?.Invoke(this, person);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            OnValidate();
        }
    }
}
