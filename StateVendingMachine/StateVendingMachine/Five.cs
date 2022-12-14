using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateVendingMachine
{
    internal class Five : IState
    {
        Machine machine;
        public Five(Machine machine)
        {
            this.machine = machine;
        }

        public void Added5c()
        {
            machine.ChangeState(new Ten(machine));
            machine.UpdateCredit(10);
        }

        public void Added10c()
        {
            machine.ChangeState(new Fifteen(machine));
            machine.UpdateCredit(15);
        }

        public void Added20c()
        {
            machine.ChangeState(new Zero(machine));
            machine.ReleaseDrink();
            machine.GiveChange(5);
            machine.UpdateCredit(0);
        }
    }
}
