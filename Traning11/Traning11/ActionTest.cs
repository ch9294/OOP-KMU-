using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning11
{
    class ActionTest
    {
        static void Main(string[] args)
        {
            Action<int, int> action = (a, b) =>
            {

                if (b == 0)
                {
                    Console.WriteLine("{0} / {1} == {2}", a, b, a / 0);
                }

                Console.WriteLine("{0} / {1} == {2}", a, b, a / b);
            };
            action(10, 2);
        }
    }
}
