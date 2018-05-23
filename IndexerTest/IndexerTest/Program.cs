using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerTest
{
    class Mylist : IEnumerable, IEnumerator
    {
        private int[] arr;
        private int position = -1; // 인덱스는 0부터 시작

        public Mylist()
        {
            arr = new int[3];
        }

        public int this[int index]
        {
            get { return index; }
            set
            {
                if (index >= arr.Length)
                {
                    Array.Resize<int>(ref arr, index + 1);
                }
                arr[index] = value;
            }
        }

        public int getLength()
        {
            return arr.Length;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < getLength(); i++)
            {
                yield return (arr[i]); // 호출자에게 컬렉션을 하나씩 반환할 때
            }

        }

        public object Current
        {
            get
            {
                return arr[position];
            }
        }

        public void Reset()
        {
            position = -1;
        }

        public bool MoveNext()
        {
            if (position == arr.Length - 1) // 현재 위치가 배열의 가장 마지막 요소일 경우
            {
                Reset();
                return false;
            }
            else
            {
                position++;
                return (position < arr.Length);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Mylist list = new Mylist();
            
            for(int i = 0; i < list.getLength(); i++)
            {
                list[i] = i + 1;
                
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
