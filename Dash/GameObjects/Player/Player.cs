using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dash
{
    /// <summary>
    /// Class for player objects
    /// </summary>
    abstract class Player:GameObject
    {
        protected int health; //health of player
        protected int speed; //speed of player
        protected string name; //name of player
        
        /// <summary>
        /// Gets name of player
        /// </summary>
        public string Name
        {
            get { return name; }
        }

        /// <summary>
        /// Constructor that sets health speed and name for Player objects
        /// </summary>
        /// <param name="speed">Speed of enemy</param>
        /// <param name="health">Health of enemy</param>
        /// <param name="name">Name of enemy</param>
        /// <param name="position">Position of the object on screen</param>
        /// <param name="imagePath">images for the object split string with ; for multiple images</param>
        /// <param name="collisionBoxes">Collisonboxes for the object of type Rect</param>
        protected Player(int health, int speed, string name, PointF position, string imagePath, List<Rect> collisionBoxes)
            : base(position, imagePath,collisionBoxes)
        {
            this.health = health;
            this.speed = speed;
            this.name = name;
        }
    }
}
