using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dash
{
    /// <summary>
    /// Class for enemies that move
    /// </summary>
    class MovableEnemy:Enemy
    {
        protected int speed; //Speed of movable enemy

        /// <summary>
        /// Constructor that sets speed of enemy
        /// </summary>
        /// <param name="speed">Speed of enemy</param>
        /// <param name="health">Health of enemy</param>
        /// <param name="name">Name of enemy</param>
        /// <param name="position">Position of the object on screen</param>
        /// <param name="imagePath">images for the object split string with ; for multiple images</param>
        /// <param name="collisionBoxes">Collisonboxes for the object of type Rect</param>
        public MovableEnemy(int speed, int health, string name, PointF position, string imagePath, List<Rect> collisionBoxes)
            : base(health, name, position, imagePath,collisionBoxes)
        {
            this.speed = speed;
        }
    }
}
