using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCasting
{
    class ObjectType
    {
        public enum MyEnum
        {
            A,B,C
        }
        static void Main(string[] args)
        {
            int a = 1; // 스택에 저장

            object b = null;
            b = a;
            
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(MyEnum.A);
        }
    }
}
