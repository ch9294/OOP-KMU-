using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10
{
    class Mylist : IEnumerable
    {
        private int[] array;

        public Mylist()
        {
            array = new int[3];
        }

        public int this[int index]
        {
            get
            {
                return array[index];
            }

            set
            {
                if (index >= array.Length)
                {
                    Array.Resize<int>(ref array, index + 1);
                }
                array[index] = value;
            }
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                yield return array[i];
            }
        }
    }

    class IndexerTest
    {
        static void Main(string[] args)
        {
            Mylist list = new Mylist();

            list[0] = 10;
            list[1] = 20;
            list[2] = 30;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.WriteLine();

            list[3] = 40;
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
