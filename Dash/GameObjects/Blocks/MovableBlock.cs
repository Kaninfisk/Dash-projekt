using System.Collections.Generic;
using System.Drawing;

namespace Dash
{
    /// <summary>
    /// Class for movable blocks
    /// </summary>
    class MovableBlock:SolidBlock
    {
        protected int speed; // Pixels to move per second
        protected int direction; // 1 = Up, 2 = down, 3 = left, 4 = right
        protected PointF endPosition; // Position to stop at

        /// <summary>
        /// Constructor that sets endPosition, speed, direction and distance
        /// </summary>
        /// <param name="speed">Speed to move atin pixels per second</param>
        /// <param name="direction">Direction to move 1 = Up, 2 = down, 3 = left, 4 = right</param>
        /// <param name="distance">Distance to move counted in tiles</param>
        /// <param name="position">Position of the object on screen</param>
        /// <param name="imagePath">images for the object split string with ; for multiple images</param>
        /// <param name="collisionBoxes">Collisonboxes for the object of type Rect</param>>
        protected MovableBlock(int speed, int direction, int distance, PointF position, string imagePath, List<Rect> collisionBoxes)
            : base(position, imagePath, collisionBoxes)
        {
            endPosition = position;
            this.speed = speed;
            this.direction = direction;
            switch (direction)
            {
                case 1:
                    endPosition.Y += distance * 48;
                    break;
                case 2:
                    endPosition.Y += distance * 48;
                    break;
                case 3:
                    endPosition.X += distance * 48;
                    break;
                case 4:
                    endPosition.X += distance * 48;
                    break;
            }
        }

        /// <summary>
        /// Method that moves the block
        /// </summary>
        /// <param name="fps">Current fps the program is running at</param>
        /// <param name="levelMap">Reference to the levelmap for current loaded level</param>
        /// <param name="playerState">Reference to the state of the player.</param>
        public override void Update(float fps, ref GameObject[,] levelMap,ref int playerState)
        {
            base.Update(fps, ref levelMap,ref playerState);
            switch (direction)
            {
                case 1:
                    this.position.Y -= speed / fps;
                    if (this.position == position)
                    {
                        direction = 2;
                    }
                    break;
                case 2:
                    this.position.Y += speed / fps;
                    if (this.position == endPosition)
                    {
                        direction = 1;
                    }
                    break;
                case 3:
                    this.position.X -= speed / fps;
                    if (this.position == position)
                    {
                        direction = 4;
                    }
                    break;
                case 4:
                    this.position.X += speed / fps;
                    if (this.position == endPosition)
                    {
                        direction = 3;
                    }
                    break;
            }
        }
    }
}
