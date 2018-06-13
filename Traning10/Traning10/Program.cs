using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning10
{
    delegate int MyDelegate(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate Callback;

            Callback = delegate (int a, int b)
            {
                return a + b;
            };
            Console.WriteLine(Callback(3,4));

            Callback = (a, b) => a - b;
            Console.WriteLine(Callback(7,5));
        }
    }
}
