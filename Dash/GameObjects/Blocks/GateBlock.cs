using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dash
{
    class GateBlock:MovableBlock
    {
        public GateBlock(int speed, int direction, int distance, PointF position, string imagePath, List<Rect> collisionBoxes)
            : base(speed, direction, distance, position, imagePath, collisionBoxes)
        {
            
        }
    }
}
