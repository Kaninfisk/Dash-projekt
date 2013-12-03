using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dash
{
    abstract class Player:GameObject
    {
        protected int health;
        protected int speed;
        protected string name;
        public string Name
        {
            get { return name; }
        }

        public Player(int health, int speed, string name, PointF position, string imagePath) : base(position, imagePath)
        {
            this.health = health;
            this.speed = speed;
            this.name = name;
        }

        public override void Update(float fps, ref GameObject[,] levelMap)
        {
            base.Update(fps,ref levelMap);
        }
    }
}
