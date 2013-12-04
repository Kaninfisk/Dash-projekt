using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Dash
{
    class MovableBlock:SolidBlock
    {
        protected int speed; // Pixels pr frame?
        protected int direction; //1 = op, 2 = ned, 3 = venstre, 4 = højre
        protected int distance;

        public MovableBlock(int speed, int direction, int distance, PointF position, string imagePath, List<Rect> collisionBoxes, float fps)
            : base(position, imagePath, collisionBoxes)
        {
            PointF endPosition = position;
            endPosition.X += distance;
            this.speed = speed;
            this.direction = direction;
            this.distance = distance;

         
        }

        public void MovePlatform(float fps, PointF endPosition)
        {
            switch (direction)
            {
                case 1:
                    this.position.Y -= speed / fps;
                    if (this.position == position)
                    {
                        direction = 2;
                    }
                    break;
                case 2:
                    this.position.Y += speed / fps;
                    if (this.position == endPosition)
                    {
                        direction = 1;
                    }
                    break;
                case 3:
                    this.position.X -= speed / fps;
                    if (this.position == endPosition)
                    {
                        direction = 4;
                    }
                    break;
                case 4:
                    this.position.X += speed / fps;
                    if (this.position == endPosition)
                    {
                        direction = 3;
                    }
                    break;
            }
        }
    }
}
