using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            TVContext context = new TVContext();
            State tvStartState = new TVStartState();
            State tvStopState = new TVStopState();

            context.setState(tvStartState);
            context.doAction();

            context.setState(tvStopState);
            context.doAction();
        }
    }
}
