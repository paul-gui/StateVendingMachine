using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateVendingMachine
{
    internal class Ten : IState
    {
        Machine machine;
        public Ten(Machine machine)
        {
            this.machine = machine;
        }

        public void Added5c()
        {
            machine.ChangeState(new Fifteen(machine));
            machine.UpdateCredit(15);
        }

        public void Added10c()
        {
            machine.ChangeState(new Twenty(machine));
            machine.UpdateCredit(20);
        }

        public void Added15c()
        {
            machine.ReleaseDrink();
            machine.ChangeState(new Zero(machine));
            machine.UpdateCredit(0);
        }
    }
}
