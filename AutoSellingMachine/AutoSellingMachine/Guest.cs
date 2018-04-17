using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSellingMachine
{
    class Guest
    {
        internal int coke = 0;
        internal int soda = 0;
        internal int pocari = 0;
        internal int change = 0;

        public void Initialize()
        {
            this.coke = 0;
            this.soda = 0;
            this.pocari = 0;
            this.change = 0;
        }
    }
}
