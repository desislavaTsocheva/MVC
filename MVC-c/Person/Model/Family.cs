using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PersonFamily.Model
{
    public class Family:Persons
    {
        private string familyName;
        public string FamilyName
        {
            get { return familyName; }
            set { familyName = value; }
        }
        private List<Family> allFamily;
        public List<Family> AllFamily
        {
            get { return allFamily; }
            set { allFamily = value; }
        }
        public Family(string familyName, List<Family> allFamily)
        {
            this.familyName = familyName;
            this.allFamily = allFamily;
        }

        public void PrintMembers()
        {
            Console.WriteLine($"Family name is: {this.FamilyName}");
            Console.WriteLine($"Family have {this.allFamily.Count} members");
        }
        public Persons GetOldestPerson()
        {
            Persons findPerson = new Persons();
            int maxAge = allFamily.Max(x => x.Age);
            findPerson = allFamily.Find(x => x.Age == maxAge);
            return findPerson;
        }
    }
}
