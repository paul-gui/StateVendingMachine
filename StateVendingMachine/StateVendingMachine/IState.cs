using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateVendingMachine
{
    public interface IState
    {

        void Added5c();
        void Added10c();
        void Added20c();
    }
}
