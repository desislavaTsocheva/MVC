using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonFamily.Model
{
    public class Persons
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int age;
        public int Age
        {
            get { return age; }
            set { this.age = value; }
        }
        public Persons(string name,int age)
        {
            this.name = name;
            this.age = age;
        }
        public Persons()
        {

        }
    }
}
