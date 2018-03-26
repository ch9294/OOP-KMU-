using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodTest1
{
    class outTest
    {
        static public void sum(int a,int b,out int quiote,out int remainder)
        {
            quiote = a / b;
            remainder = a % b;
        }
        static void Main(string[] args)
        {
            int a = 7;
            int b = 1;

            sum(a, b, out int q, out int r);
            Console.WriteLine("몫 : "+q);
            Console.WriteLine("나머지 : " + r);
        }
    }
}
