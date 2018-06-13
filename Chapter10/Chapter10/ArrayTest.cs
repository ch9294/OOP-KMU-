using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10
{
    class ArrayTest
    {
        static void Main(string[] args)
        {
            int[] arr = { 10,3,7,16,30,38 };

            //for(int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //Array.Sort(arr);

            //foreach(var num in arr)
            //{
            //    Console.WriteLine(num);
            //}
            Console.WriteLine(Array.IndexOf(arr, 30)); 
        }
    }
}
