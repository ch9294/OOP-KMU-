using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning6
{
    class Program
    {
        static void Main(string[] args)
        {
            Monitor m = new Monitor(new Slash());
            m.start("Hello world");
            Console.WriteLine();
            m = new Monitor(new Star());
            m.start("Goodbye world");
            Console.WriteLine();
            m = new Monitor(new Wave());
            m.start("Have a nive day");
        }
    }
}
