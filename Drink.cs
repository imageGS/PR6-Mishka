using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR6
{
    abstract class Drink
    {
        int price;
        double intertainment;

        void DrinkThis()
        {

        }
    }

    internal class RedWine : Drink
    {
        int price = 50;
        double intertainment = 25;

        int GetRedWinePrice()
        {
            return price;
        }

        double GetRedWineIntertainment()
        {
            return intertainment;
        }
        public RedWine() 
        {
            GetRedWinePrice();
            GetRedWineIntertainment();
        }
    }

    internal class Whiskey : Drink
    {
        int price = 100;
        double intertainment = 50;

        int GetWhiskeyPrice() 
        {
            return price;
        }

        int GetWhiskeyIntertainment()
        {
            return intertainment;
        }
    }

    internal class WhiteWine : Drink
    {
        int price = 25;
        int intertainment = 15;

        int GetWhiteWinePrice() 
        {
            return price;
        }

        int GetWhiteWineIntertainment()
        {
            return intertainment;
        }
    }
}
