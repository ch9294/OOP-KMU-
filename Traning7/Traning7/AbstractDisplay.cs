using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning7
{
    abstract class AbstractDisplay
    {
        abstract public void open();
        abstract public void print();
        abstract public void close();

        public void display()
        {
            open();
            print();
            close();
        }
    }

    class charDisplay : AbstractDisplay
    {
        char character;

        public charDisplay(char character)
        {
            this.character = character;
        }

        public override void open()
        {
            Console.Write("<<");
        }

        public override void print()
        {
            for(int i = 0; i < 13; i++)
            {
                Console.Write(character);
            }
        }

        public override void close()
        {
            Console.WriteLine(">>");
        }
    }

    class stringDisplay : AbstractDisplay
    {
        string str;
        public stringDisplay(string str)
        {
            this.str = str;
        }
        public override void open()
        {
            Console.Write('+');
            for(int i = 0; i < 13; i++)
            {
                Console.Write('-');
            }
            Console.WriteLine('+');
        }

        public override void print()
        {
            printLine();
        }

        public override void close()
        {
            open();
        }

        private void printLine()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write('|');
                Console.Write(str);
                Console.Write('|');
                Console.WriteLine();
            }
        }
    }
}
