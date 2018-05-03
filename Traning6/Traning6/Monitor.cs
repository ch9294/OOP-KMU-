using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning6
{
    class Monitor
    {
        IBorder border;

        public Monitor(IBorder border)
        {
            this.border = border;
        }
        
        public void start(string str)
        {
            border.WriteBorder(str);
        }
    }
}
