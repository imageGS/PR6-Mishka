using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR6
{
    abstract class Drink
    {
        public virtual int Price { get; protected set; } = 10;
        public virtual int Intertainment { get; protected set; }
    }

    internal class RedWine : Drink
    {
        public override int Price { get; protected set; } = 50;
        public override int Intertainment { get; protected set; } = 25;
    }

    internal class Whiskey : Drink
    {
        public override int Price { get; protected set; } = 100;
        public override int Intertainment { get; protected set; } = 50;
    }

    internal class WhiteWine : Drink
    {
        public override int Price { get; protected set; } = 25;
        public override int Intertainment { get; protected set; } = 15;
    }
}
