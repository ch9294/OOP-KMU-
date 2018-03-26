using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodTest
{
    class Program
    {
        static void Main(string[] args)

        {
            int a = 10;

            int b = 20;

            ref int c = ref a;
            Console.WriteLine(a + ", " + b);
            swap(ref a, ref b);
            Console.WriteLine(a + ", " + b);
            Console.WriteLine(a + ", " + b + ", " + c);
        }

        static void swap(ref int a,ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }
    }
}
