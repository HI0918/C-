using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 贪吃蛇.Lesson1;
using 贪吃蛇.Lesson4;
using 贪吃蛇.Lesson5;
using 贪吃蛇.Lesson6;

namespace 贪吃蛇.Lesson2
{
    class GameScene : ISceneUpdate
    {
        Map map;
        SnackBody snake;
        Food food;
        int updateIndex = 0;
        public GameScene()
        {
            map = new Map();
            snake = new SnackBody(20,10);
            food=new Food(snake);
        }
        public void Update()
        {
            if(updateIndex%6666==0)
            {
                map.Draw();
                food.Draw();
                snake.Move();
                snake.Draw();
                if(snake.ChangeEnd(map))
                    Game.ChangeScene(E_SceneType.End);

                snake.CheckEatFood(food);
                updateIndex = 0;
            }
            updateIndex++;

            if(Console.KeyAvailable)
            {
                 switch (Console.ReadKey(true).Key) 
                            {
                                case ConsoleKey.W:
                                    snake.ChangeDir(E_SnakeMoveDir.up);
                                    break;
                                case ConsoleKey.A:
                                    snake.ChangeDir(E_SnakeMoveDir.left);
                                    break;
                                case ConsoleKey.S:
                                    snake.ChangeDir(E_SnakeMoveDir.down);
                                    break;
                                case ConsoleKey.D:
                                    snake.ChangeDir(E_SnakeMoveDir.right);
                                    break;
                            }
            }
           

        }
    }
}
