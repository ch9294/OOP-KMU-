using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Base
    {
        protected string Name;

        public Base(string Name)
        {
            this.Name = Name;
            Console.WriteLine("{0}.Base()",this.Name);
        }
        ~Base()
        {
            Console.WriteLine("{0}.~Base()",this.Name);
        }

        public void BaseMethod()
        {
            Console.WriteLine("{0}.BaseMethod()",this.Name);
        }
    }

    class Drived : Base
    {
        public Drived(string Name) : base(Name)
        {
            Console.WriteLine("{0}.Drived()",this.Name);
        }

        ~Drived()
        {
            Console.WriteLine("{0}.~Drived()",this.Name);
        }

        public void DrivedMethod()
        {
            Console.WriteLine("{0}.DrivedMethod()",this.Name);
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Base a = new Base("a");
            a.BaseMethod();

            Drived b = new Drived("b");
            b.BaseMethod();
            b.DrivedMethod();

            Console.WriteLine();
        }
        
    }
}
