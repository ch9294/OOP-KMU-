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
            char[] reverse = str.ToCharArray();
            Array.Reverse(reverse);
            return reverse.ToString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string str = "helloworld";
            
            string reverse = str.Reverse();
            Console.WriteLine(str);
            Console.WriteLine(reverse);
        }
    }
}
