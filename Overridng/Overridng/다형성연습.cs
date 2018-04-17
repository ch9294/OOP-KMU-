using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overridng
{
    class ArmorSuite
    {
        public virtual void Initialize()
        {
            Console.WriteLine("기본 장착");
        }
    }

    class IronMan : ArmorSuite
    {
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("아이언맨 전용");
        }
    }

    class WarMachine : ArmorSuite
    {
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("워머신 전용");
        }
    }
    class 다형성연습
    {
        static void Main(string[] args)
        {
            IronMan i = new IronMan();
            WarMachine w = new WarMachine();

            ArmorSuite a = new IronMan();
            ArmorSuite b = new WarMachine();

            i.Initialize();
            w.Initialize();

            a.Initialize();
            b.Initialize();
        }
    }
}
