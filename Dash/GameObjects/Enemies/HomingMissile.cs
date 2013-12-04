﻿using System.Collections.Generic;
using System.Drawing;

namespace Dash
{
    /// <summary>
    /// Class for enemy homing missiles
    /// </summary>
    class HomingMissile:MovableEnemy
    {
        /// <summary>
        /// Constructor that sets speed of enemy homingmissiles
        /// </summary>
        /// <param name="speed">Speed of enemy</param>
        /// <param name="health">Health of enemy</param>
        /// <param name="name">Name of enemy</param>
        /// <param name="position">Position of the object on screen</param>
        /// <param name="imagePath">images for the object split string with ; for multiple images</param>
        /// <param name="collisionBoxes">Collisonboxes for the object of type Rect</param>
        public HomingMissile(int speed, int health, string name, PointF position, string imagePath, List<Rect> collisionBoxes)
            : base(speed, health, name, position, imagePath,collisionBoxes)
        {
            
        }
    }
}
