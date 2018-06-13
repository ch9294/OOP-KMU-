using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10
{
    class JaggedArray
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[2][] { new int[] { 1, 2 },new int[]{3,4,5} };

            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine(arr[i][j]);
                }
            }
        }
    }
}
