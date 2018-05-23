using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTest
{
    class BirthdayInfo
    {
        private string name;
        private DateTime birthday;

        /*
         * 프로퍼티에 특별한 논리가 들어가지 않을 경우 get,set에 세미콜론을 붙여줌으로써 자동 구현
         * 프로퍼티를 만들 수 있다.
         */
        public string Name
        {
            get;
            set;
        }

        public DateTime Birthday
        {
            get;
            set;
        }

        public int age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(birthday).Ticks).Year;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // 프로퍼티를 이용한 초기화
            // new 연산 뒤에 중괄호를 묶고 각 초기화 하고자 하는 프로퍼티를 작성한다. 이때 세미콜론은 쓰지 않고 콤마만 사용한다.
            // 중괄호를 닫은 후 세미콜론으로 끝을 낸다.
            BirthdayInfo my = new BirthdayInfo()
            {
                Name = "최천일", Birthday = new DateTime(1992, 08, 18)
            };

            Console.WriteLine(my.Name);
            Console.WriteLine(my.Birthday);
            Console.WriteLine(my.age);
        }
    }
}
