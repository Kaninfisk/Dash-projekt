﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dash
{
    class SpaceShip:MovableEnemy
    {
        public SpaceShip(int speed, int health, string name, PointF position, string imagePath) : base(speed, health, name, position, imagePath)
        {
            
        }
    }
}
