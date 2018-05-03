using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning6
{
    interface IBorder
    {
       void WriteBorder(string str);
    }

    abstract class Border : IBorder
    {
        abstract public void WriteBorder(string str);
     
        public void head(string str , char border)
        {
            for (int i = 0; i < str.Length + 4; i++)
            {
                Console.Write(border);
            }
            Console.WriteLine();
        }
        public void body(string str, char border)
        {
            char[] copy = str.ToCharArray();
            for (int i = 0; i < 5; i++)
            {
                if (i == 2)
                {
                    for (int j = 0; j < str.Length; j++)
                    {
                        Console.Write(copy[j]);
                    }
                    continue;
                }
                Console.Write(border);
            }
            Console.WriteLine();
        }
        public void foot(string str,char border)
        {
            head(str,border);
        }
    }

}
