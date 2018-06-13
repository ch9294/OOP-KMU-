using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter13
{
    public delegate int MyDelegate(int a, int b);

    class Program
    {
        public int Plus(int a, int b)
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }

        static void Main(string[] args)
        {
            MyDelegate m = new Program().Plus;
        }
    }
}
