using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodTest
{ 
    class SquareTest
    {
        public static int square(int num)
        {
            return (num * num);
        }

        public static double square(double num)
        {
            return (num * num);
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("수를 입력하세요 : ");
                string input = Console.ReadLine();
                if ()
                {
                    Console.WriteLine("결과값 : " + square(Convert.ToInt32(input)));
                }
                else
                {
                    Console.WriteLine("결과값 : " + square(Convert.ToDouble(input)));

                }

            }
        }
    }
}
