﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dash
{
    class FallingBlock:MovableBlock
    {
        public FallingBlock(int speed, PointF position, string imagePath, List<RectangleF> collisionBoxes)
            : base(speed, position, imagePath,collisionBoxes)
        {
            
        }
    }
}
