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
        protected int direction; // 1 = op, 2 = ned, 3 = venstre, 4 = højre
        protected int distance; // tælles i antal tiles
        protected PointF endPosition;

        public MovableBlock(int speed, int direction, int distance, PointF position, PointF endPosition, string imagePath, List<Rect> collisionBoxes, float fps)
            : base(position, imagePath, collisionBoxes)
        {
            endPosition = position;
            this.speed = speed;
            this.direction = direction;
            this.distance = distance + 48;
        }

        public void Update(float fps)
        {
            switch (direction)
            {
                case 1:
                    endPosition.Y += distance;
                    this.position.Y -= speed / fps;
                    if (this.position == position)
                    {
                        direction = 2;
                    }
                    break;
                case 2:
                    endPosition.Y += distance;
                    this.position.Y += speed / fps;
                    if (this.position == endPosition)
                    {
                        direction = 1;
                    }
                    break;
                case 3:
                    endPosition.X += distance;
                    this.position.X -= speed / fps;
                    if (this.position == position)
                    {
                        direction = 4;
                    }
                    break;
                case 4:
                    endPosition.X += distance;
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
