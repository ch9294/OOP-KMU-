using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning5
{
    class Zookeeper
    {
        public void wash(Animal animal)
        {
            Console.WriteLine(animal.name+ "동물을 wash합니다.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Zookeeper keeper = new Zookeeper();
            keeper.wash(new Dog());
            keeper.wash(new Lion());
            keeper.wash(new Cat());
            keeper.wash(new Elepant());
            keeper.wash(new Horse());
            keeper.wash(new Rabbit());
            keeper.wash(new Monkey());

            Animal ani = new Animal();
            ani = ani as Cat;
            if(ani != null) { keeper.wash(ani); }
            else { Console.WriteLine("변환 불가"); }
            
        }
    }
}
