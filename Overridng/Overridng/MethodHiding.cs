using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overridng
{
    class A
    {
        public void myMethod()
        {
            Console.WriteLine("hello a!");
        }
    }

    class B : A
    {
        public void myMethod()
        {
            Console.WriteLine("hello b!");
        }
    }
    class MethodHiding
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            a.myMethod();
            b.myMethod();

            A c = b as A;
            c.myMethod();
        }
    }
}
