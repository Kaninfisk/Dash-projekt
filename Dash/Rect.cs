using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dash
{
    /// <summary>
    /// Datatype Class for collisionboxes
    /// </summary>
    public class Rect
    {
        private float width; //width of hitbox
        private float height; //height of hitbox
        private PointF position; //position of hitbox
        
        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        public PointF Position
        {
            get { return position; }
            set { position = value; }
        }
        
        /// <summary>
        /// Constructor that sets position, height and width.
        /// </summary>
        /// <param name="position"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public Rect(PointF position, int width, int height)
        {
            this.position = position;
            this.width = width;
            this.height = height;
        }

        /// <summary>
        /// Returns hitbox based on Coordinates supplied
        /// </summary>
        /// <param name="x">X position</param>
        /// <param name="y">Y position</param>
        /// <returns></returns>
        public RectangleF HitBox(float x, float y)
        {
            return new RectangleF(x + position.X, y + position.Y, width, height);
        }
    }
}
