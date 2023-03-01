using PersonFamily.Model;
using PersonFamily.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person.Controller
{
    public class Controller
    {
        Display myDisplay = new Display();
        public Family CurrentFamily { get; set; }
        public Controller()
        {
            myDisplay.InputFamily();
            this.CurrentFamily = myDisplay.CurrentFamily;
            this.CurrentFamily.GetOldestPerson();
            myDisplay.CurrentFamily = this.CurrentFamily;
            myDisplay.OutPut();
        }
    }
}
