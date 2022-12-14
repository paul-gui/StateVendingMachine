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

        public void ChangeState(IState state)
        {
            this.state = state;
        }

        public void Added5c()
        {
            lblChange.Text = "";
            lblDrink.Text = "";
            state.Added5c();
        }

        public void Added10c()
        {
            lblChange.Text = "";
            lblDrink.Text = "";
            state.Added10c();
        }

        public void Added15c()
        {
            lblChange.Text = "";
            lblDrink.Text = "";
            state.Added20c();
        }

        public void ReleaseDrink()
        {
            lblDrink.Text = "You have recieved your drink.";
        }

        public void GiveChange(int amount)
        {
            lblChange.Text = "Change:" + amount.ToString() + "¢";
        }
        public void UpdateCredit(int credit)
        {
            lblCredit.Text = "Credit: " + credit.ToString() + "¢";
        }
    }
}
