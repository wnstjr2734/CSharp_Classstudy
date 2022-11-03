using System;
using System.Collections.Generic;
using System.Drawing;


namespace StaticTest
{
    class Program
    {
        static void Main(string[] Args)
        {
            //새로운 Brick 클래스를 담는 br이라는 변수를 만든다(생성자)
            Brick br = new Brick();
            Brick br2 = new Brick(50, 100, 20, Color.Gray);
            Brick br3 = new Brick();

            //set을 설정하여 새로운 값을 집어넣을수 있게 한다
            int w = br2.Width;
            w = 100;

            int volume = br3.Volume;
            int v = volume;
            v = 2 * 2 * 3;

            Console.WriteLine($"br2의 width는 {w}이다.");
            Console.WriteLine(v);
        }
    }
}
