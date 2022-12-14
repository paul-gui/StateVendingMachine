using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateVendingMachine
{
    internal class Zero : IState
    {
        Machine machine;
        public Zero(Machine machine)
        {
            this.machine = machine;
        }

        public void Added5c()
        {
            machine.ChangeState(new Five(machine));
            machine.UpdateCredit(5);
        }
        public void Added10c()
        {
            machine.ChangeState(new Ten(machine));
            machine.UpdateCredit(10);
        }
        public void Added20c()
        {
            machine.ReleaseDrink();
        }
    }
}
