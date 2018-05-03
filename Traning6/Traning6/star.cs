using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning6
{
    class Star : Border
    {
        public override void WriteBorder(string str)
        {
            head(str,'*');
            body(str,'*');
            foot(str,'*');
        }
    }
}
