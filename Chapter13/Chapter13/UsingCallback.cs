﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter13
{
    //delegate int Compare(int a, int b);

    class MainApp
    {
        static int AscendCompare(int a, int b)
        {
            if (a > b)
            {
                return 1;
            }
            else if(a == b)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        static int DescendCompare(int a, int b)
        {
            if(a < b)
            {
                return 1;
            }
            else if(a == b)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        static void BubbleSort(int[] DataSet, Func<int,int,int> func)
        {
            int temp = 0;

            for(int i = 0; i < DataSet.Length - 1; i++)
            {
                for(int j = 0; j < DataSet.Length - (i + 1); j++)
                {
                    if (func(DataSet[j], DataSet[j + 1]) > 0)
                    {
                        temp = DataSet[j + 1];
                        DataSet[j + 1] = DataSet[j];
                        DataSet[j] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int[] array = { 3, 7, 0, 1, 10 };

            foreach(int num in array)
            {
                Console.Write("{0} ", num);
            }
            Console.WriteLine();

            BubbleSort(array, AscendCompare);
            foreach (int num in array)
            {
                Console.Write("{0} ", num);
            }
            Console.WriteLine();

            BubbleSort(array, DescendCompare);
            foreach (int num in array)
            {
                Console.Write("{0} ", num);
            }
            Console.WriteLine();
        }
    }
}
