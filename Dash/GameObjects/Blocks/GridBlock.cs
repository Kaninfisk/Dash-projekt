using System.Collections.Generic;
using System.Drawing;

namespace Dash
{
    /// <summary>
    /// GameObject used for solid blocks in foreground and background tiles
    /// </summary>
    class GridBlock:GameObject
    {
        public GridBlock(PointF position, string imagePath, List<Rect> collisionBoxes)
            : base(position, imagePath, collisionBoxes)
        {
            
        }
    }
}
