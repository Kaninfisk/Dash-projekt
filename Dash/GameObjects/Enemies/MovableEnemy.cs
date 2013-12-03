using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dash
{
    class MovableEnemy:Enemy
    {
        protected int speed;

        public MovableEnemy(int speed, int health, string name, PointF position, string imagePath, List<Rect> collisionBoxes)
            : base(health, name, position, imagePath,collisionBoxes)
        {
            this.speed = speed;
        }
    }
}
