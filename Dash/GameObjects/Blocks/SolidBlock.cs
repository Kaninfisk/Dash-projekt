﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dash
{
    class SolidBlock:GridBlock
    {
        public SolidBlock(PointF position, string imagePath, List<RectangleF> collisionBoxes)
            : base(position, imagePath,collisionBoxes)
        {
            
        }
    }
}
