using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSellingMachine
{
    class Beverages
    {
        internal int price;
        internal int count;
    }
    
    class Coke : Beverages
    {
        public Coke()
        {
            price = 700;
            count = 10;
        }
    }

    class Soda : Beverages
    {
        public Soda()
        {
            price = 700;
            count = 15;
        }
    }

    class Pocari : Beverages
    {
        public Pocari()
        {
            price = 1000;
            count = 7;
        }
    }
}
