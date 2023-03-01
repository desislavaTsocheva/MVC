using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportPrice.Model;
using TransportPrice.View;

namespace TransportPrice.Controller
{
    public class Controller
    {
        Display newDisplay=new Display();
        public Transport CurrentTransport { get; set; }
        public Controller()
        {
            newDisplay.InPutData();
            this.CurrentTransport = newDisplay.CurrentTransport;
            newDisplay.CurrentTransport = this.CurrentTransport;
            newDisplay.OutPutTheBestTransport();
        }
    }
}
