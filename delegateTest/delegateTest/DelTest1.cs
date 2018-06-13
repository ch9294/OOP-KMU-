using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegateTest
{
    delegate int ParseInt(String s);

    class DelTest1
    {
        public int convertInt(String s)
        {
            int num = int.Parse(s);
            return num;
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            DelTest1 test = new DelTest1();
            ParseInt p = new ParseInt(test.convertInt);
            Console.WriteLine(p("123"));
            ParseInt p2 = test.convertInt;
        }
    }
}
