using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 贪吃蛇.Lesson3;

namespace 贪吃蛇.Lesson4
{
   enum E_SnakeType
    {
        head,
        body,
    }
     class Snake:GameObejct
    {
        public E_SnakeType type;
        public Snake(E_SnakeType type,int x,int y)
        {
            this.type=type;
            pos=new Position(x,y);
        }
        public override void Draw()
        {
            Console.SetCursorPosition(pos.x,pos.y);
            Console.ForegroundColor=type==E_SnakeType.head?ConsoleColor.Yellow:ConsoleColor.Green;
            Console.Write(type == E_SnakeType.head ? "●" : "○");
        }

       
    }
}
