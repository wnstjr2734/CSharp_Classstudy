using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace StaticTest
{
    //이러한 클래스의 단점은 클래스의 필드값이 고정되어있어서 변경이 힘들다.
    class Brick
    {
        //필드(데이터)
        private int width;  //private는 현재 클래스 내에서만 쓰이게한다. 외부에서 엑세스가 안된다.
        private int height;
        private int depth;
        private Color color;
        private int volume;

        //생성자(Constructor)
        public Brick()
        {
            width = 10;
            height = 10;
            depth = 5;
            color = Color.Red;
        }

        //위의 클래스를 보완하기 위해 파라미터를 설정
        public Brick(int w, int h, int d, Color c)
        {
            //위의 매개변수 지정
            this.width = w;
            this.height = h;
            this.depth = d;
            this.color = c;
        }

        //속성(property)
        public int Width
        {
            //get은 읽기전용이다.
            get { return width; }
            //set을 쓰게 되면 value 값을 집어넣을수 있게 만든다.
            set { width = value; }
        }

        public Color Color
        {
            get { return Color; }
        }

        public int Volume
        {
            get { return width * height * depth; }
            set { volume = value; }
        }
    }
}
