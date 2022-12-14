using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StateVendingMachine
{
    public class Machine
    {
        public IState state;
        Label lblCredit;
        Label lblChange;
        Label lblDrink;
        public Machine(Label lblCredit, Label lblChange, Label lblDrink)
        {
            this.state = new Zero(this);
            this.lblCredit = lblCredit;
            this.lblChange = lblChange;
            this.lblDrink = lblDrink;
        }

        /// <summary>
        /// Changes the state of the machine
        /// </summary>
        /// <param name="state">The state the machine will be changed to</param>
        public void ChangeState(IState state)
        {
            this.state = state;
        }

        /// <summary>
        /// Performs the actions needed when a nickel is inserted depending on the current state of the machine
        /// </summary>
        public void Added5c()
        {
            lblChange.Text = "";
            lblDrink.Text = "";
            state.Added5c();
        }

        /// <summary>
        /// Performs the actions needed when a dime is inserted depending on the current state of the machine
        /// </summary>
        public void Added10c()
        {
            lblChange.Text = "";
            lblDrink.Text = "";
            state.Added10c();
        }

        /// <summary>
        /// Performs the actions needed when a quarter is inserted depending on the current state of the machine
        /// </summary>
        public void Added15c()
        {
            lblChange.Text = "";
            lblDrink.Text = "";
            state.Added20c();
        }

        /// <summary>
        /// Notifies the user that the drink has been released
        /// </summary>
        public void ReleaseDrink()
        {
            lblDrink.Text = "You have recieved your drink.";
        }

        /// <summary>
        /// Notifies the user how much change has been given back
        /// </summary>
        /// <param name="amount">The amount of change to be released</param>
        public void GiveChange(int amount)
        {
            lblChange.Text = "Change:" + amount.ToString() + "¢";
        }
        /// <summary>
        /// Updates the amount of credit shown on the screen
        /// </summary>
        /// <param name="amount">The new amount of credit</param>
        public void UpdateCredit(int amount)
        {
            lblCredit.Text = "Credit: " + amount.ToString() + "¢";
        }
    }
}
