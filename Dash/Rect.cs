using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dash
{
    public class Rect
    {
        private float width;
        private float height;
        private PointF position;
        
        public PointF Position
        {
            get { return position; }
            set { position = value; }
        }
        

        public Rect(PointF position, int width, int height)
        {
            this.position = position;
            this.width = width;
            this.height = height;
        }

        public RectangleF HitBox(float x, float y)
        {
            return new RectangleF(x + position.X, y + position.Y, width, height);
        }
    }
}
