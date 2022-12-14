using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateVendingMachine
{
    public interface IState
    {
        /// <summary>
        /// Performs the actions needed when a nickel is inserted
        /// </summary>
        void Added5c();

        /// <summary>
        /// Performs the actions needed when a dime is inserted
        /// </summary>
        void Added10c();

        /// <summary>
        /// Performs the actions needed when a quarter is inserted
        /// </summary>
        void Added20c();
    }
}
