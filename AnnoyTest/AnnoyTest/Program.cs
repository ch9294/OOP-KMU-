using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnoyTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var myInstance = new {
                // 데이터는 읽기 전용이다.
                // 갱신이 불가능
                Name = "최천일",
                ArrayInt = new int[]{1,2,3}
            };
            
            Console.WriteLine(myInstance.Name);
            foreach(var num in myInstance.ArrayInt)
            {
                Console.WriteLine(num);
            }
            
        }
    }
}
