using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overridng
{
    class Shape
    {
        protected int width;
        protected int height;

        public Shape(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public virtual void draw()
        {
            Console.WriteLine("도형 그리기");
        }
    }

    class Triangle : Shape
    {
        public Triangle(int width, int height) : base(width,height)
        {
            this.width = width;
            this.height = height;
        }
        public override void draw()
        {
            Console.WriteLine("가로: {0} , 세로: {1} 삼각형 그리기", this.width, this.height);
        }
    }

    class Rectangle : Shape
    {
        public Rectangle(int width,int height) : base(width,height)
        {
            this.width = width;
            this.height = height;
        }
        public override void draw()
        {
            Console.WriteLine("가로: {0} , 세로: {1} 사각형 그리기",this.width,this.height);
        }
    }

    class Circle : Shape
    {
        public Circle(int width,int height):base(width,height)
        {
            this.width = width;
            this.height = height;
        }
        public override void draw()
        {
            Console.WriteLine("가로: {0} , 세로: {1} 원 그리기", this.width, this.height);
        }
    }

    class practice
    {
        static void Main(string[] args)
        {
            Shape s1 = new Triangle(10, 10);
            s1.draw();

            Shape s2 = new Rectangle(5, 3);
            s2.draw();

            Shape s3 = new Circle(2, 3);
            s3.draw();

            Triangle t1 = new Triangle(5, 5);
            Shape s4 = t1 as Shape; // as는 참조형 변수를 캐스팅 할경우 사용한다. 캐스팅 실패시 null 반환
        }
    }
}
