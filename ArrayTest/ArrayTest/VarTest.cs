using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTest
{
    class VarTest
    {
        static void Main(string[] args)
        {
            int[] d = new int[] { 3,7,4,9,1 };
            Array.Sort(d);
            foreach(int item in d)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(Array.IndexOf(d,7));
        }
    }
}
