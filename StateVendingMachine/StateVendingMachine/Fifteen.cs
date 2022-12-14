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
            machine.ChangeState(new Zero(machine));
            machine.ReleaseDrink();
            machine.UpdateCredit(0);
        }

        public void Added10c()
        {
            machine.ChangeState(new Zero(machine));
            machine.ReleaseDrink();
            machine.GiveChange(5);
            machine.UpdateCredit(0);
        }

        public void Added20c()
        {
            machine.ChangeState(new Zero(machine));
            machine.ReleaseDrink();
            machine.GiveChange(15);
            machine.UpdateCredit(0);
        }
    }
}
