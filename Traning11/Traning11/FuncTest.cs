using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning11
{
    class FuncTest
    {
        static void Main(string[] args)
        {
            Func<int, int, int> func = (a, b) =>
              {
                  if (b == 0)
                  {
                      return a / 0;
                  }

                  return a / b;
              };

            Console.WriteLine("{0} / {1} == {2}", 10, 2, func(10, 2));
            Console.WriteLine("{0} / {1} == {2}", 10, 0, func(10, 0));
        }
    }
}
