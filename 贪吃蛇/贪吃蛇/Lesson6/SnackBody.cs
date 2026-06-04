using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 贪吃蛇.Lesson3;
using 贪吃蛇.Lesson4;
using 贪吃蛇.Lesson5;

namespace 贪吃蛇.Lesson6
{
    enum E_SnakeMoveDir 
    {
        up, down, left, right,
    }


    class SnackBody : IDraw
    {
        Snake[] bodys;
        int nowNum;
        E_SnakeMoveDir Dir;
        public SnackBody(int x, int y)
        {
            bodys = new Snake[200];
            bodys[0]=new Snake(E_SnakeType.head,x,y);
            nowNum = 1;
            Dir=E_SnakeMoveDir.right;
        }
        public void Draw()
        {
            for(int i=0;i<nowNum;i++)
            {
                bodys[i].Draw();
            }
        }
        #region 蛇的移动
        public void Move()
        {
            Snake lastBody=bodys[nowNum-1];
            Console.SetCursorPosition(lastBody.pos.x, lastBody.pos.y);
            Console.Write("  ");

            for(int i = nowNum - 1; i > 0; i--)
            {
                bodys[i].pos = bodys[i-1].pos;
            }
            
            switch (Dir)
            {
                case E_SnakeMoveDir.up:
                    --bodys[0].pos.y;
                    break;
                case E_SnakeMoveDir.down:
                    ++bodys[0].pos.y;
                    break;
                case E_SnakeMoveDir.left:
                    bodys[0].pos.x-=2;
                    break;
                case E_SnakeMoveDir.right:
                    bodys[0].pos.x+=2;
                    break;
            }
        }
        #endregion
        #region 蛇的方向
        public void ChangeDir(E_SnakeMoveDir dir)
        {
            if(this.Dir == dir||nowNum>1&&(this.Dir==E_SnakeMoveDir.left&&dir==E_SnakeMoveDir.right||
                this.Dir==E_SnakeMoveDir.right&&dir==E_SnakeMoveDir.left||
                this.Dir==E_SnakeMoveDir.up&&dir==E_SnakeMoveDir.down||
                this.Dir==E_SnakeMoveDir.down&&dir==E_SnakeMoveDir.up)) 
                { return; }
            this.Dir = dir;
        }

        public bool ChangeEnd(Map map)
        {
            for(int i = 0; i < map.walls.Length; i++)
            {
                if (bodys[0].pos == map.walls[i].pos)
                {
                    return true;
                }
            }
            for(int i = 1; i < nowNum; i++)
            {
                if (bodys[0].pos == bodys[i].pos )
                    return true;
            }
            return false;
        }
        #endregion
        #region 检查是否和食物重合
        public bool CheckSamePos(Position p)
        {
            for(int i = 0; i < nowNum; i++)
            { 
                if (bodys[0].pos == p)
                {
                    return true;
                }
            }           
            return false;
        }
#endregion

        #region 吃食物
        public void CheckEatFood(Food food)
        {
            if (bodys[0].pos == food.pos)
            {
                food.RandomPos(this);
                AddBody();
            }
        }
        #endregion
        #region 长身体
        private void AddBody()
        {
            //先长
            Snake frontBody = bodys[nowNum - 1];
            bodys[nowNum]=new Snake(E_SnakeType.body,frontBody.pos.x,frontBody.pos.y);
            //在加
            ++nowNum;
        }
        #endregion
    }
}
