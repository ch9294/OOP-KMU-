using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning7
{
    class NameCard
    {
        // private int age;
        // private string name;

        public int Age { get; set; }
        public string Name { get; set; }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            NameCard MyCard = new NameCard()
            {
                Name = "천일",
                Age = 27
            };

           // MyCard.Age = 27;
           // MyCard.Name = "천일";

           Console.WriteLine("나이 : {0}", MyCard.Age);
           Console.WriteLine("이름 : {0}", MyCard.Name);
        }
    }
   
}
