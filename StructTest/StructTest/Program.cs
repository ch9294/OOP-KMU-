using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructTest
{
    struct Point3D
    {
        public int x;
        public int y;
        public int z;

        public Point3D(int x,int y,int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            return "[" + x + "," + y + "," + z + "]";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point3D p1;
            p1.x = 1;
            p1.y = 3;
            p1.z = 5;

            Point3D p2 = p1;
            p2.y = 10;
            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());

        }
    }
}
