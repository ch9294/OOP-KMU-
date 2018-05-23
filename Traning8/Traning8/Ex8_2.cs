using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning8
{
    class Ex8_2
    {
        class List : IEnumerator
        {
            ArrayList list;
            int pos = -1;

            public List()
            {
                list = new ArrayList();
            }

            public object Current
            {
                get
                {
                    return list[pos];
                }
            }

            public bool MoveNext()
            {
                if(pos == list.Count - 1)
                {
                    Reset();
                    return false;
                }

                pos++;
                return true;
            }

            public void Reset()
            {
                pos = -1;
            }
        }
        static void Main(string[] args)
        {
            //ArrayList list = new ArrayList();
            //for(int i = 0; i < 5; i++)
            //{
            //    list.Add(i);
            //}

            //list.RemoveAt(2);
            //list.Insert(2, 2);
            //list.Add("abc");
            //list.Add("def");

            List list = new List();
            
            while()

            
        }
    }
}
