﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crosser
{
    internal class Crosser
    {
        public int x, y;
        public int speed = 6;
        public int width = 30, height = 10;


        public Crosser(int _x, int _y)
        {
            this.x = _x;
            this.y = _y;
        }

        public void Move(string direction)
        {
            if (direction == "left")
            {
                x -= speed;
            }
            if (direction == "right")
            {
                x += speed;
            }
            if (direction == "up")
            {
                y -= speed;
            }
            if (direction == "down")
            {
                y += speed;
            }


        }
    }
}
