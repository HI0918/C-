using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贪吃蛇.Lesson3
{    
   abstract class GameObejct : IDraw
    {
        public Position pos;
        public abstract void Draw();        
    }
}
