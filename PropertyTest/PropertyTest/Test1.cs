using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTest
{
    interface ILogger
    {
        void WriteLog(string msg);
    }

    class ConsoleLogger : ILogger
    {
        public void WriteLog(string msg)
        {
            Console.WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), msg);
        }
    }

    class FileLogger : ILogger
    {
        private StreamWriter writer;

        public FileLogger(string path)
        {
            writer = File.CreateText(path);
            writer.AutoFlush = true;
        }

        public void WriteLog(string msg)
        {
            writer.WriteLine("{0} {1}", DateTime.Now.ToShortDateString(), msg);
        }
    }

    class ClimateMonitor
    {
        private ILogger logger;

        public ClimateMonitor(ILogger logger)
        {
            this.logger = logger;
        }

        public void start()
        {
            while (true)
            {
                Console.WriteLine("온도를 입력해주세요 : ");
                string temperature = Console.ReadLine();

                if (temperature == "")
                {
                    break;
                }

                logger.WriteLog("현재 온도 : " + temperature);
            }
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            ConsoleLogger logger1 = new ConsoleLogger();
            //FileLogger logger2 = new FileLogger("D:\\");
            ClimateMonitor monitor1 = new ClimateMonitor(logger1);
            monitor1.start();

            //ClimateMonitor m = new ClimateMonitor(logger2);
            //m.start();

        }
    }
}
