﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dash
{
    class GateBlock:MovableBlock
    {
        public GateBlock(int speed, PointF position, string imagePath, List<Rect> collisionBoxes)
            : base(speed, position, imagePath,collisionBoxes)
        {
            
        }
    }
}
