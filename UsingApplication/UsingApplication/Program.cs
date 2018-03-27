using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingApplication
{
    class MyForm : Form
    {

    }
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MyForm form = new MyForm();
            form.Click += new EventHandler(
                (sender,eventArgs)=> {
                    Console.WriteLine("Closing Window...");
                    Application.Exit();
                });
            Console.WriteLine("Starting Window Application...");
            Application.Run(form);

            Console.WriteLine("Exiting Window Application...");
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }
    }
}
