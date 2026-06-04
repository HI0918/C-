using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using 贪吃蛇.Lesson1;
using 贪吃蛇.Lesson3;
using 贪吃蛇.Lesson6;
namespace 贪吃蛇.Lesson4
{
    class Food : GameObejct
    {
        public Food(SnackBody snake)
        {
           RandomPos(snake);
        }
        public override void Draw()
        {
            Console.SetCursorPosition(pos.x, pos.y);
            Console.ForegroundColor=ConsoleColor.Cyan;
            Console.Write("¤");
        }
        public void RandomPos(SnackBody snake)
        {
            Random r = new Random();
            int x=r.Next(2,Game.w/2-1)*2;
            int y = r.Next(1, Game.h - 4);
            pos=new Position(x,y);

            if (snake.CheckSamePos(pos))
            {
                RandomPos(snake);
            }
        }

    }
}
