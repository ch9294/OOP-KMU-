using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTest
{
    interface INamedValue
    {
        string Name
        {
            get;set;
        }

        string Value
        {
            get;set;
        }
    }

    class NameValued : INamedValue
    {
        public string Name
        {
            get;set;
        }

        public string Value
        {
            get;set;
        }
    }

    class PropertiesInterfaceTest
    {
        static void Main(string[] args)
        {
            NameValued name = new NameValued()
            {
                Name="이름",
                Value ="최천일"
            };

            NameValued height = new NameValued()
            {
                Name = "키",

                Value ="177"
            };

            NameValued weight = new NameValued()
            {
                Name = "체중",
                Value = "67"
            };

            Console.WriteLine(name.Name+':'+name.Value);
            Console.WriteLine(height.Name+':'+height.Value);
            Console.WriteLine(weight.Name+':'+weight.Value);
        }
    }
}
