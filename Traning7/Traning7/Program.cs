using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning7
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractDisplay d1 = new charDisplay('H');
            AbstractDisplay d2 = new stringDisplay("hello, world!");

            d1.display();
            d2.display();
        }
    }
}
