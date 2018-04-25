using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning5
{
    class Mammal
    {
        public void Nurse()
        {
            Console.WriteLine("Nurse()");
        }
    }

    class Dog1 : Mammal
    {
        public void Bark()
        {
            Console.WriteLine("Bark()");
        }
    }

    class Cat1 : Mammal
    {
        public void Meow()
        {
            Console.WriteLine("Meow");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Mammal mammal = new Dog1();
            Dog1 dog1;
            
            if(mammal is Dog1)
            {
                dog1 = mammal as Dog1;
                dog1.Bark();
                
            
            }

            Mammal mammal2 = new Cat1();
            Cat1 cat1 = mammal2 as Cat1;

            if(cat1 != null)
            {
                cat1.Meow();
            }

            Cat1 cat2 = mammal as Cat1;

            if(cat2 != null)
            {
                cat2.Meow();
            }
            else
            {
                Console.WriteLine("cat2 is not a Cat");
            }

            
        }
    }
}
