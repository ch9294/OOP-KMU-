using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter13
{
    delegate void Notify(string msg);

    class Notifier
    {
        public Notify EventOccured;
    }

    class EventListener
    {
        private string name;

        public EventListener(string name)
        {
            this.name = name;
        }

        public void SomethingHappend(string msg)
        {
            Console.WriteLine("{0}.SomethingHappend : {1}",name,msg);
        }
    }

    class DelegateChains
    {
        static void Main(string[] args)
        {
            Notifier notifier = new Notifier();

            EventListener listener1 = new EventListener("Listener1");
            EventListener listener2 = new EventListener("Listener2");
            EventListener listener3 = new EventListener("Listener3");

            notifier.EventOccured += listener1.SomethingHappend;
            notifier.EventOccured += listener2.SomethingHappend;
            notifier.EventOccured += listener3.SomethingHappend;

            notifier.EventOccured("You've got mail.");
            Console.WriteLine();
            notifier.EventOccured -= listener2.SomethingHappend;
            notifier.EventOccured("You've got mail.");
        }
    }
}
