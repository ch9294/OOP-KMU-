using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest
{
    class AccessModifierTest
    {
        protected int temperature;

        public void SedTemperature(int temperature)
        {
            if(temperature<-5 || temperature > 42)
            {
                throw new Exception("Out of temperature range");
            }
            this.temperature = temperature;
        }

        internal void TurnOnWater()
        {
            Console.WriteLine("Turn on water : {0}",temperature);
        }
       
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            try
            {
                AccessModifierTest test = new AccessModifierTest();
                test.SedTemperature(20);
                test.TurnOnWater();

                test.SedTemperature(-2);
                test.TurnOnWater();

                test.SedTemperature(50);
                test.TurnOnWater();

            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
