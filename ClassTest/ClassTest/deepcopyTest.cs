using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest
{
    class deepcopyTest
    {
        public int a;
        public int b;
        public deepcopyTest()
        {
            deepcopyTest renew = new deepcopyTest();
            renew.a = a;
            renew.b = b;

            
        }
        public deepcopyTest(deepcopyTest deepcopy)
        {
            this.a = deepcopy.a;
            this.b = deepcopy.b;
        }

    }
}
