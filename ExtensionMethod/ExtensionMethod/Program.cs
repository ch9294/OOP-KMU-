using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    static class Ex_Method
    {
        public static string Reverse(this string str)
        {
            Stack<char> copy = new Stack<char>();
            char[] copy2 = str.ToCharArray();

            for(int i = 0; i < copy2.Length; i++)
            {
                copy.Push(copy2[i]);
            }

            for(int i = 0; i < copy2.Length; i++)
            {
                copy2[i] = copy.Pop();
            }
            string result = copy2.ToString();
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string str = "helloworld";
            string reverse = str.Reverse();
            Console.WriteLine(reverse);
        }
    }
}
