using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Crosser
{
    internal class Enemy
    {
        public int x, y, width = 30 , height = 15, xSpeed = 6;
        

        public Enemy(int _x, int _y, int _xSpeed)
        {
            this.x = _x;
            this.y = _y;
            this.xSpeed = _xSpeed;
        }


        public void Move(int screenWidth, int screenHeight)
        {
            x += xSpeed;

            /*if (x > screenWidth - width || x < 0)
            {
                speed *= -1;
            }*/
        }
        public bool Collision(Crosser c)
        {
            Rectangle enemyRec = new Rectangle(x, y, width, height);
            Rectangle crosserRec = new Rectangle(c.x, c.y, c.width, c.height);

            if (enemyRec.IntersectsWith(crosserRec))
            {
                #region
                /*if (speed > 0)
                {
                    x = c.x - width;
                }
                else
                {
                    x = c.x + c.height;
                }

                speed *= -1; */
                #endregion
                return true;
            }
            return false;
        }
    }
}
