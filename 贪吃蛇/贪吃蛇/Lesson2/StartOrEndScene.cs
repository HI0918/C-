using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 贪吃蛇.Lesson1;

namespace 贪吃蛇.Lesson2
{
    abstract class StartOrEndScene:ISceneUpdate
    {
        protected string title;
        protected string strOne;
        public int nowSetIndex= 0;

        public abstract void EnterJDoSmothing();
        public void Update()
        {
            Console.ForegroundColor= ConsoleColor.White;
            Console.SetCursorPosition(Game.w / 2 - title.Length, 6);
            Console.Write(title);
            Console.SetCursorPosition(Game.w/2-strOne.Length, 8);
            Console.ForegroundColor= nowSetIndex==0?ConsoleColor.Red:ConsoleColor.White;
            Console.Write(strOne);
            Console.SetCursorPosition(Game.w / 2 - 4, 10);
            Console.ForegroundColor = nowSetIndex == 1 ? ConsoleColor.Red : ConsoleColor.White;
            Console.Write("结束游戏");

            switch (Console.ReadKey(true).Key) 
            {
                case ConsoleKey.W:
                    --nowSetIndex;
                    if(nowSetIndex<0)
                        nowSetIndex = 0;
                    break;
                case ConsoleKey.S:
                    ++nowSetIndex;
                    if(nowSetIndex>1)
                        nowSetIndex = 1;
                    break;
                case ConsoleKey.J:
                    EnterJDoSmothing();
                    break;
            }


        }
    }
}
