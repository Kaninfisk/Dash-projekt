using System.Collections.Generic;
using System.Drawing;

namespace Dash
{
    class GridBlock:GameObject
    {
        public GridBlock(PointF position, string imagePath, List<Rect> collisionBoxes)
            : base(position, imagePath, collisionBoxes)
        {
            
        }
    }
}
