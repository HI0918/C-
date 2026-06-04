using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 贪吃蛇.Lesson1;

namespace 贪吃蛇.Lesson2
{
    class Begin : StartOrEndScene
    {
        public Begin()
        {
            title = "贪吃蛇";
            strOne= "开始游戏";
        }
        public override void EnterJDoSmothing()
        {
            if (nowSetIndex == 0)
            {
                Game.ChangeScene(E_SceneType.Game);
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
