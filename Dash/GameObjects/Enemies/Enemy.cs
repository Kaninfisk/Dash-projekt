using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dash
{
    class Enemy:GameObject
    {
        protected int health;
        protected string name;

        public string Name
        {
            get { return name; }
        }

        public Enemy(int health, string name, PointF position, string imagePath, List<RectangleF> collisionBoxes)
            : base(position, imagePath, collisionBoxes)
        {
            this.health = health;
            this.name = name;
        }

    }
}
