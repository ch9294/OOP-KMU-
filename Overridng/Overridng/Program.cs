using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overridng
{
    class ArmorSuite
    {
        public void Initialize()
        {
            Console.WriteLine("ArmorSuite");
        }
    }

    class IronMan : ArmorSuite
    {
        public void Initialize()
        {
            Console.WriteLine("아이언맨 추가 장비 장착");
        }
    }

    class WarMachine : ArmorSuite
    {
        public new void Initialize()
        {
            base.Initialize();
            Console.WriteLine("워머신 추가 장비 장착");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            ArmorSuite armorSuite = new ArmorSuite();
            armorSuite.Initialize();

            IronMan ironMan = new IronMan();
            ironMan.Initialize();

            WarMachine warMachine = new WarMachine();
            warMachine.Initialize();
        }
    }
}
