using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning11
{
    class Program
    {
        delegate int MyDivide(int a, int b);

        static void Main(string[] args)
        {
            /* 1. 람다식으로 작성*/
            MyDivide myfunc = (a, b) =>
            {
                if (b == 0)
                {
                    return a / 0;
                }

                return a / b;
            };

            Console.WriteLine("{0} / {1} == {2}", 10, 2, myfunc(10, 2));
            Console.WriteLine("{0} / {1} == {2}", 10, 0, myfunc(10, 0));
            //MyDivide myFunc = delegate (int a, int b)
            //{
            //    if (b == 0)
            //    {
            //        return null;
            //    }

            //    return a / b;
            //};
            // 여기에 10 / 2 == 5     와 같이 출력되도록 write 문 완성할 것.
            // 여기에 10 / 0 ==        와 같이 출력되도록 write 문 완성할 것.
        }
    }



}
