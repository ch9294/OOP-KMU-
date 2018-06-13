using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter13
{
    //delegate void EventHandler(string msg);

    class MyNotifier
    {
        public event Action<string> SomethingHappend;

        public void DoSomething(int number)
        {
            int temp = number % 10;

            if (temp != 0 && temp % 3 == 0)
            {
                SomethingHappend(String.Format("{0} : 짝", number));
            }
        }
    }

    class EventTest
    {
        //static public void MyHandler(string msg)
        //{
        //    Console.WriteLine(msg);
        //}

        static void Main(string[] args)
        {
            MyNotifier notifier = new MyNotifier();
            notifier.SomethingHappend += (msg) => Console.WriteLine(msg); ;

            for (int i = 0; i < 30; i++)
            {
                notifier.DoSomething(i);
            }
        }
    }
}
