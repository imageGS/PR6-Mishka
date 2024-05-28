using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR6
{
    internal class Client
    {
        double intertainment = 0;
        int money = 200;


        Singleton instance;
        public Singleton getInstance()
        {
            if (instance == null)
                instance = new Singleton();
            return instance;
        }
        public void DrinkRedWine(double intertainment, int money)
        {
            RedWine redWine = new RedWine();
            
            this.intertainment = intertainment;
            this.money = money;
            
        }
    }
}
