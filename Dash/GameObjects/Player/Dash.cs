using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dash
{
    class Dash:Player
    {
        private int dash;

        public Dash(int dash, int health, int speed, string name, PointF position, string imagePath) : base(health, speed, name, position, imagePath)
        {
            this.dash = dash;
        }
    }
}
