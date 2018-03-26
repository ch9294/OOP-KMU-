using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest
{
    class ThisTest
    {
        int a, b, c;

        public ThisTest()
        {
            this.a = 5425;
            Console.WriteLine("ThisTest()");
        }
        public ThisTest(int b) : this()
        {
            this.b = b;
            Console.WriteLine("ThisTest(int b)");
        }
        public ThisTest(int b,int c):this(b)
        {
            this.c = c;
            Console.WriteLine("ThisTest(int b,int c)");
        }
    }
}
