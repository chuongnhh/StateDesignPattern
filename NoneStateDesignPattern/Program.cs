using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoneStateDesignPattern
{
    class Program
    {
        private String state = "";

        public void setState(String state)
        {
            this.state = state;
        }

        public void doAction()
        {
            if (state.Equals("ON"))
            {
                Console.WriteLine("TV is turned ON");
            }
            else if (state.Equals("OFF"))
            {
                Console.WriteLine("TV is turned OFF");
            }
        }

        static void Main(string[] args)
        {
            Program remote = new Program();

            remote.setState("ON");
            remote.doAction();

            remote.setState("OFF");
            remote.doAction();
        }
    }
}
