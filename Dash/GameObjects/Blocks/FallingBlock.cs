using System.Collections.Generic;
using System.Drawing;

namespace Dash
{
    class FallingBlock:MovableBlock
    {
        public FallingBlock(int speed, int direction, int distance, PointF position, string imagePath, List<Rect> collisionBoxes)
            : base(speed, direction, distance,position,imagePath,collisionBoxes)
        {
            
        }
    }
}
