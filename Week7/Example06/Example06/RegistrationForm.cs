using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example06
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
            profile1.Validate += CheckRegister;
        }

        private void CheckRegister(object sender, Person person)
        {
            int dob;
            bool isNumDob = int.TryParse(person.dob.ToString(), out dob);
            int phone;
            bool isNumPhone = int.TryParse(person.phone.ToString(), out phone);
            if (person.name == "")
            {
                MessageBox.Show("Name is not null");
            }
            if (person.dob == "")
            {
                MessageBox.Show("Dob is not null");
            }
            if (person.addr == "")
            {
                MessageBox.Show("Address is not null");
            }
            if (person.phone == "")
            {
                MessageBox.Show("Phone is not null");
            }
            if (person.email == "")
            {
                MessageBox.Show("Email is not null");
            }
            if(isNumDob == false)
            {
                MessageBox.Show("Dob must be number");
            }
            if (isNumPhone == false)
            {
                MessageBox.Show("Phone must be number");
            }
            else
            {
                MessageBox.Show(person.ToString());
            }

        }
    }
}
