using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateVendingMachine
{
    internal class Fifteen : IState
    {
        Machine machine;
        public Fifteen(Machine machine)
        {
            this.machine = machine;
        }

        public void Added5c()
        {
            machine.ChangeState(new Twenty(machine));
            machine.UpdateCredit(20);
        }

        public void Added10c()
        {
            machine.ReleaseDrink();
            machine.ChangeState(new Zero(machine));
            machine.UpdateCredit(0);
        }

        public void Added15c()
        {
            machine.ReleaseDrink();
            machine.GiveChange(5);
            machine.ChangeState(new Zero(machine));
            machine.UpdateCredit(0);
        }
    }
}
