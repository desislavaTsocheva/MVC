using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TileRepair.Model;
using TileRepair.View;

namespace TileRepair.Controller
{
    public class Controller
    {
            Display newDisplay = new Display();
            public Repair currentRepair { get; set; }
            public Controller()
            {
            newDisplay.InPut();
            this.currentRepair = newDisplay.currentRepair;
            newDisplay.currentRepair = this.currentRepair;
            newDisplay.OutPut();
            }
        }
    }

