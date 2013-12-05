using System.Collections.Generic;
using System.Drawing;

namespace Dash
{
    /// <summary>
    /// GameObject for doors
    /// </summary>
    class GateBlock:GridBlock
    {
        private bool open;

        /// <summary>
        /// Sets if the door is open
        /// </summary>
        public bool Open
        {
            set { open = value; }
        }
        

        /// <summary>
        /// Constructor for doors
        /// </summary>
        /// <param name="position">Position of the object on screen</param>
        /// <param name="imagePath">images for the object split string with ; for multiple images</param>
        /// <param name="collisionBoxes">Collisonboxes for the object of type Rect</param>
        public GateBlock(PointF position, string imagePath, List<Rect> collisionBoxes)
            : base(position, imagePath, collisionBoxes)
        {
            open = false;
        }

        /// <summary>
        /// Override for base draw method, switches image if door is open
        /// </summary>
        /// <param name="dc">Graphics object that you want to draw to</param>
        public override void Draw(Graphics dc)
        {
            if (open)
            {
                if (animationFrames.Count > 1)
                {
                    sprite = animationFrames[1];
                }
            }
            base.Draw(dc);
        }
    }
}
