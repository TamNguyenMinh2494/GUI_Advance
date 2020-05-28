using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example06
{
    public class Person
    {
        public string name { get; set; }
        public string dob { get; set; }
        public string addr { get; set; }
        public string phone { get; set; }
        public string email { get; set; }

        public Person()
        {

        }

        public Person(string name, string dob, string addr, string phone, string email)
        {
            this.name = name;
            this.dob = dob;
            this.addr = addr;
            this.phone = phone;
            this.email = email;
        }
        public override string ToString()
        {
            return "Name: " + name + "\n"
                    + "DoB: " + dob  + "\n"
                    + "Address: " + addr + "\n"
                    + "Phone: " + phone + "\n"
                    + "Email: " + email + "\n";
        }
    }

}
