using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTest
{
    // 델리게이트도 하나의 특수한 클래스(정확히는 래퍼 클래스)
    delegate void EventHandler(string msg);

    class MyNotifier
    {
        public event EventHandler SomethingHappened;

        public void DoSomething(int num)
        {
            int tmp = num % 10;

            if(tmp != 0 && tmp % 3 == 0)
            {
                SomethingHappened(String.Format("{0} : 짝",num));
            }
        }
    }
    class Program
    {
        static public void MyHandler(string msg)
        {
            Console.WriteLine(msg);
        }

        static void Main(string[] args)
        {
            MyNotifier notifier = new MyNotifier();
            notifier.SomethingHappened += new EventHandler(MyHandler);

            for(int i = 1; i < 30; i++)
            {
                notifier.DoSomething(i);
            }
        }
    }
}
