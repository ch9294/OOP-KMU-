using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodTest
{
    class UsingNamed
    {

        static int abc(int a = 1,int b = 2)
        {
            return a + b;
        }
        static void print(string name,string phone)
        {
            Console.WriteLine(name);
            Console.WriteLine(phone);
        }
        static void Main(string[] args)
        {
            print(phone:"010-1234-1234",name:"천일");
            Console.WriteLine();
        }
    }
}
