using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_DataBindingEF
{
    class Person
    {
        private string name;
        public string Name { get => name; set => name = value; }


        private int age;
        public int Age
        {
            get => age;
            set
            {
                if (value != age)
                {
                    age = value;
                }
            }
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public override string ToString()
        {
            return Name + " is " + Age;
        }
    }
}
