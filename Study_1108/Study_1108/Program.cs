using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 상속 : 다른 클래스로부터 코드를 물려받는 것
/// 상속의 대상 : 클래스의 멤버(필드,메소드,프로퍼티 등)
/// 새로 선언하는 클래스이름 뒤에 :와 기반 클래스의 이름을 표기하여 상속
/// </summary>
namespace Study_1108
{
    //기반 클래스
    class Parent
    {
        public int num;

        public Parent()
        {
            Console.WriteLine("부모클래스의 생성자가 호출되었습니다.");
        }
    }

    class Child : Parent
    {
        public Child(int num)
        {
            //base 키워드를 이용하여 자식클래스에도 num 멤버 변수로 접근할 수 있다.
            base.num = num;
            Console.WriteLine("자식 클래스의 생성자가 호출되었습니다.");
        }

        public void DisplayValue()
        {
            Console.WriteLine("num의 값은 {0} 입니다", num);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Child cd = new Child(20);

            cd.DisplayValue();
        }
    }
}
