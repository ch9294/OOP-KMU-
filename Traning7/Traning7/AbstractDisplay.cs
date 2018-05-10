using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning7
{
    interface AbstractDisplay
    {
        void open();
        void print();
        void close();
        void display();
    }

    class charDisplay : AbstractDisplay
    {
        char character;

        public charDisplay(char character)
        {
            this.character = character;
        }
        public void open()
        {
            Console.Write("<<");
        }

        public void print()
        {
            for(int i = 0; i < 13; i++)
            {
                Console.Write(character);
            }
        }

        public void close()
        {
            Console.WriteLine(">>");
        }

        public void display()
        {
            open();
            print();
            close();
        }
    }

    class stringDisplay : AbstractDisplay
    {
        string str;
        public stringDisplay(string str)
        {
            this.str = str;
        }
        public void open()
        {
            Console.Write('+');
            for(int i = 0; i < 13; i++)
            {
                Console.Write('-');
            }
            Console.Write('+');
            printLine();
        }

        public void print()
        {
            for(int i = 0; i < 5; i++)
            {
                Console.Write('|');
                Console.Write(str);
                Console.Write('|');
                printLine();
            }
        }

        public void close()
        {
            open();
            printLine();
        }

        public void display()
        {
            open();
            print();
            close();
        }

        private void printLine()
        {
            Console.WriteLine();
        }
    }
}
