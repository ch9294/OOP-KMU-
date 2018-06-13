using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateChains
{
    delegate void Notify(string msg);

    class Notifier
    {
        public Notify EventOccured;
    }
    
    class EventListener
    {
        public string Name
        {
            get; set;
        }

        public void SomethingHappend(string msg)
        {
            Console.WriteLine("{0}.SomethingHappend : {1}",Name,msg);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Notifier notifier = new Notifier();

            EventListener listener1 = new EventListener()
            {
                Name = "Listener1"
            };

            EventListener listener2 = new EventListener()
            {
                Name = "Listener2"
            };

            EventListener listener3 = new EventListener()
            {
                Name = "Listener3"
            };
            
            // 델리게이트 체인 만들기
            notifier.EventOccured = listener1.SomethingHappend;
            notifier.EventOccured += listener2.SomethingHappend;
            notifier.EventOccured += listener3.SomethingHappend;
            notifier.EventOccured("You've got mail");

            Console.WriteLine();

            // 체인에서 원하는 메소드 제외하기
            notifier.EventOccured -= listener2.SomethingHappend;
            notifier.EventOccured("Download complete");

            Console.WriteLine();

            notifier.EventOccured = new Notify(listener2.SomethingHappend);
                //+ new Notify(listener3.SomethingHappend);

            notifier.EventOccured("Nuclear launch detected");
        }
    }
}
