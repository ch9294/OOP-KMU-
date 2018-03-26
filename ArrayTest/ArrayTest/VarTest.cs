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
            var a = 20;
            Console.WriteLine("Type: {0}, Value: {1}", a.GetType(), a);

            var b = 3.14159;
            Console.WriteLine("Type: {0}, Value: {1}", b.GetType(), b);

            var c = "Hello world!!";
            Console.WriteLine("Type: {0}, Value: {1}", c.GetType(), c);

            var d = new int[] { 1, 2, 3, 4, 5 };
            //for(int i = 0; i < 5; i++)
            foreach(var value in d)
            {
                Console.WriteLine("Type: {0}, Value: {1}", d.GetType(), d);
            }

            
        }
    }
}
