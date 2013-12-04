using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dash
{
    /// <summary>
    /// Class for player spaceship
    /// </summary>
    class Ship:Player
    {
        private int armor; // armor  of playership

        /// <summary>
        /// Constructor that sets armor of ship
        /// </summary>
        /// <param name="armor">Armor of playership</param>
        /// <param name="health">Health of playership</param>
        /// <param name="speed">Speed of playership</param>
        /// <param name="name">Name of playership</param>
        /// <param name="position">Position of the object on screen</param>
        /// <param name="imagePath">images for the object split string with ; for multiple images</param>
        /// <param name="collisionBoxes">Collisonboxes for the object of type Rect</param>
        public Ship(int armor, int health, int speed, string name, PointF position, string imagePath, List<Rect> collisionBoxes)
            : base(health, speed, name, position, imagePath,collisionBoxes)
        {
            this.armor = armor;
        }
    }
}
