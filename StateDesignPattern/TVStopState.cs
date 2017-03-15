using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public class TVStopState : State
    {
        public void doAction()
        {
            Console.WriteLine("TV is turned OFF");
            //throw new NotImplementedException();
        }
    }
}
