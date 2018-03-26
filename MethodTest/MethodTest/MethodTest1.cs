using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodTest
{
    class MethodTest1
    {
        int a;

        int b;

        public int sum()
        {
            return this.a + this.b;
        }
        public void setter(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        static void Main(string[] args)
        {
            MethodTest1 method = new MethodTest1();

            method.setter(3, 5);
            Console.WriteLine(method.sum());

            ref MethodTest1 methodtest1 = ref method;
            methodtest1.setter(10, 20);
            Console.WriteLine(methodtest1.sum());

            Console.WriteLine(method.Equals(methodtest1));
         
        }

    }
}
