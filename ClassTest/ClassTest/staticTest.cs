using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest
{
    class staticTest
    {
        public static int a;
        public int b;

        public static void Aprint()
        {
            Console.WriteLine(a);
        }
        public void Bprint()
        {
            Console.WriteLine(b);
        }
    }
}
