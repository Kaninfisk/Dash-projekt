using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dash
{
    /// <summary>
    /// GameObject for doors
    /// </summary>
    class GateBlock:SolidBlock
    {
        private bool open;

        /// <summary>
        /// Gets or Sets if the door is open
        /// </summary>
        public bool Open
        {
            get { return open; }
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
            if (Open)
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
