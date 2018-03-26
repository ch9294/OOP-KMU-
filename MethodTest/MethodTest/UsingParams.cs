using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodTest
{
    class UsingParams
    {
        static int sum(params int[] args)
        {
            int sum = 0;
            foreach(var item in args)
            {
                sum += item;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(sum(1, 2, 3));
            Console.WriteLine(sum(1, 3, 5, 7, 9, 11));
        }
    }
}
