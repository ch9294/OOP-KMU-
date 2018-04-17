using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    // sealed를 통해 기반 클래스의 상속을 봉인할 수 있다.

    class Parent
    {
        String mama;
        String papa;

        public Parent(String name)
        {
            mama = "영희";
            papa = "철수";

            Console.WriteLine("{0}와 {1}은 결혼을 하여 {2}를 낳았습니다.",mama,papa,name);

        }
    }
    // 다중 상속이 불가능!!
    class Child : Parent
    {
        protected String name;

        public Child(String name) : base(name)
        {
            this.name = name;
            Console.WriteLine("이 아이의 이름은 {0}입니다.",this.name);
        }
    }

    class MainApp
    {

        static void Main(string[] args)
        {
            Child child = new Child("지민");
        }
    }

}
