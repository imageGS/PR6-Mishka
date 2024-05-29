using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR6
{
    internal class Client
    {
        int intertainment = 0;
        public int Money { get; private set; } = 200;

        public bool HasEnoughMoney(int price)
        {
            if (price > Money)
            return false; else return true;
        }
        public void SpendMoney(int price)
        {
            Money -= price;
        }

        public bool CanDrinkMore(int intertainment)
        {
            if ((this.intertainment + intertainment) > 100)
                return false;
            else return true;
        }

        public void Drink(int intertainment)
        {
            this.intertainment += intertainment;
        }
    }
}
