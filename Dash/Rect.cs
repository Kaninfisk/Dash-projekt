using System.Drawing;

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
        }
        
        /// <summary>
        /// Constructor that sets position, height and width.
        /// </summary>
        /// <param name="position">start Position of hitbox within tile</param>
        /// <param name="width">width of hitbox</param>
        /// <param name="height">height of hitbox</param>
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
        /// <returns>one Hitbox for object</returns>
        public RectangleF HitBox(float x, float y)
        {
            return new RectangleF(x + position.X, y + position.Y, width, height);
        }
    }
}
