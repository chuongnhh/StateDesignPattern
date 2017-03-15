using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public class TVContext : State
    {
        private State tvState;

        public void setState(State state)
        {
            this.tvState = state;
        }

        public State getState()
        {
            return this.tvState;
        }

        public void doAction()
        {
            this.tvState.doAction();
        }
    }
}
