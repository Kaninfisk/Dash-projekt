using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dash
{
    class Ship:Player
    {
        private int armor;

        public Ship(int armor, int health, int speed, string name, PointF position, string imagePath) : base(health, speed, name, position, imagePath)
        {
            this.armor = armor;
        }

        public override void Update(float fps, ref GameObject[,] levelMap)
        {
            base.Update(fps, ref levelMap);
        }
    }
}
