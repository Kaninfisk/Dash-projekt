using System.Collections.Generic;
using System.Drawing;

namespace Dash
{
    /// <summary>
    /// TriggerBlock is used for buttons and exits
    /// </summary>
    class TriggerBlock : GridBlock
    {
        private int type;  //type of trigger 
        private bool pressed;  // if it has been pressed
        private Point target;  //target of trigger

        /// <summary>
        /// Sets if button has been pressed
        /// </summary>
        public bool Pressed
        {
            set { pressed = value; }
        }

        /// <summary>
        /// Gets type
        /// </summary>
        public int Type
        {
            get { return type; }
        }
        
        /// <summary>
        /// Gets or Sets target as Point
        /// </summary>
        public Point Target
        {
            get { return target; }
        }

        /// <summary>
        /// Constructor for triggers which sets what type of trigger it is.
        /// </summary>
        /// <param name="type">What type the trigger is:  1. Button, 2: Exit trigger</param>
        /// <param name="target">Which tile in LevelMap is the target</param>
        /// <param name="position">Position of the object on screen</param>
        /// <param name="imagePath">images for the object split string with ; for multiple images</param>
        /// <param name="collisionBoxes">Collisonboxes for the object of type Rect</param>>
        public TriggerBlock(int type,Point target, PointF position, string imagePath, List<Rect> collisionBoxes)
            : base(position, imagePath,collisionBoxes)
        {
            this.type = type;
            this.target = target;
        }

        /// <summary>
        /// Constructor for triggers which sets what type of trigger it is.
        /// </summary>
        /// <param name="type">What type the trigger is:  1. Button, 2: Exit trigger</param>
        /// <param name="position">Position of the object on screen</param>
        /// <param name="imagePath">images for the object split string with ; for multiple images</param>
        /// <param name="collisionBoxes">Collisonboxes for the object of type Rect</param>>
        public TriggerBlock(int type, PointF position, string imagePath, List<Rect> collisionBoxes)
            : base(position, imagePath, collisionBoxes)
        {
            this.type = type;
        }

        /// <summary>
        /// /// Override for base draw method, switches image if button has been pressed
        /// </summary>
        /// <param name="dc">Graphics object that you want to draw to</param>
        public override void Draw(Graphics dc)
        {
            if (pressed)
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
