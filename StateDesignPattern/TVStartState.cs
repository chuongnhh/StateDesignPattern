using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public class TVStartState : State
    {
        public void doAction()
        {
            Console.WriteLine("TV is turned ON");
            //throw new NotImplementedException();
        }
    }
}
