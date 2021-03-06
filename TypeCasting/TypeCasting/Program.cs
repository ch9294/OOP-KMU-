﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCasting
{
    class Mammal
    {
        public void Nurse()
        {
            Console.WriteLine("Nurse()");
        }
    }

    class Dog : Mammal
    {
        public void Bark()
        {
            Console.WriteLine("Bark()");
        }
    }

    class Cat : Mammal
    {
        public void Meow()
        {
            Console.WriteLine("Meow()");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Mammal m = new Dog();
            Dog dog;

            if(m is Dog)
            {
                dog = (Dog)m;
                dog.Bark();
            }

            Mammal m2 = new Cat();
            Cat cat;

            cat = m2 as Cat;

            if(cat != null)
            {
                cat.Meow();
            }

            Cat cat2;
            cat2 = m as Cat;
            if(cat2 != null)
            {
                cat2.Meow();
            }
            else
                Console.WriteLine("cat2 is not a Cat");
        }
    }
}
