using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 贪吃蛇.Lesson2;

namespace 贪吃蛇.Lesson1
{
    enum E_SceneType 
    {
        Start,
        Game,
        End,
    }

    internal class Game
    {
        public const int w = 80;
        public const int h = 20;
        public static  ISceneUpdate nowScene;

        public Game()
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(w, h);
            Console.SetBufferSize(w, h);
            ChangeScene(E_SceneType.Start);
        }

        public void Start()
        {//游戏主循环 主要负责 游戏逻辑场景更新
            while (true)
            {
                if (nowScene != null)
                {
                    nowScene.Update();
                }
            }
        }
       public static  void ChangeScene(E_SceneType type)
        {
            //切场景前 要把上一场景擦除
            Console.Clear();
            switch (type)
            { 
                    case E_SceneType.Start:
                    nowScene = new Begin();
                    break;
                    case E_SceneType.Game:
                    nowScene=new GameScene();
                    break;
                    case E_SceneType.End:
                    nowScene=new End();
                    break;
            }

        }

    }
}
