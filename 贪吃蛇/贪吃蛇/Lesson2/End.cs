using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 贪吃蛇.Lesson1;

namespace 贪吃蛇.Lesson2
{
    class End : StartOrEndScene
    {
        public End()
        {
            title = "游戏结束";
            strOne = "回到开始游戏";
        }
        public override void EnterJDoSmothing()
        {
            if(nowSetIndex == 0)
            {
                Game.ChangeScene(E_SceneType.Start);
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
