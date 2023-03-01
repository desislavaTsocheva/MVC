using Person.Controller;
using PersonFamily.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace PersonFamily.View
{
    public class Display
    {
        public Family CurrentFamily { get; set; }
        public void InputFamily()
        {
            Console.WriteLine("Enter family name");
            string family = Console.ReadLine();
            Console.WriteLine("Enter family count");
            int count = int.Parse(Console.ReadLine());
            List<Persons> allFamily = new List<Persons>();
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"enter person {i}");
                string name = Console.ReadLine();
                Console.WriteLine($"enter age of {i} person");
                int age = int.Parse(Console.ReadLine());
                Persons person = new Persons(name,age);
                allFamily.Add(person);
            }
            CurrentFamily = new Family(family,allFamily);
        }
        public void OutPut()
        {
            CurrentFamily.PrintMembers();
        }
    }
}
