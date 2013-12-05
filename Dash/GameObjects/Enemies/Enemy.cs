using System.Collections.Generic;
using System.Drawing;

namespace Dash
{
    /// <summary>
    /// Class which is used for enemies that dont move ie spikes
    /// </summary>
    class Enemy : GameObject
    {
        /// <summary>
        /// Constructor that sets health and name of enemy
        /// </summary>
        /// <param name="position">Position of the object on screen</param>
        /// <param name="imagePath">images for the object split string with ; for multiple images</param>
        /// <param name="collisionBoxes">Collisonboxes for the object of type Rect</param>
        public Enemy(PointF position, string imagePath, List<Rect> collisionBoxes)
            : base(position, imagePath, collisionBoxes)
        {
            
        }

    }
}
