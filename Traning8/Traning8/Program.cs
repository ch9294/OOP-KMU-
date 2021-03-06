﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning8
{
    class MyList : IEnumerable/*,IEnumerator*/
    {
        private int[] array;
        int position = -1;

        public MyList()
        {
            array = new int[3];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }
        }

        //public int this[int index]
        //{
        //    get
        //    {
        //        return array[index];
        //    }
        //    set
        //    {
        //        if(index >= array.Length)
        //        {
        //            Array.Resize<int>(ref array, index + 1);
        //            Console.WriteLine("Array Resized : {0}",array.Length);
        //        }
        //            array[index] = value;
        //    }
        //}

        ////IEnumerator 멤버
        //public object Current
        //{
        //    get
        //    {
        //        return array[position];
        //    }
        //}

        ////IEnumerator 멤버
        //public bool MoveNext()
        //{
        //    if (position == array.Length - 1)
        //    {
        //        Reset();
        //        return false;
        //    }
        //    position++;
        //    return (position < array.Length);
        //}

        ////IEnumerator 멤버
        //public void Reset()
        //{
        //    position = -1;
        //}

        //IEnumerable 멤버
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                yield return (array[i]);
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            MyList list = new MyList();
            
            //for(int i = 0; i < 5; i++)
            //{
            //    list[i] = i;
            //}

            foreach(int e in list)
            {
                Console.WriteLine(e);
            }
        }
    }
}
