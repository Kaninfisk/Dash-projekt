using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dash
{
    class TriggerBlock:GridBlock
    {
        private int type;

        private bool pressed;

        public bool Pressed
        {
            get { return pressed; }
            set { pressed = value; }
        }

        public int Type
        {
            get { return type; }
            set { type = value; }
        }

        private Point target;

        public Point Target
        {
            get { return target; }
            set { target = value; }
        }

        public TriggerBlock(int type,Point target, PointF position, string imagePath, List<Rect> collisionBoxes)
            : base(position, imagePath,collisionBoxes)
        {
            this.type = type;
            this.target = target;
        }

        public TriggerBlock(int type, PointF position, string imagePath, List<Rect> collisionBoxes)
            : base(position, imagePath, collisionBoxes)
        {
            this.type = type;
        }

        public override void Draw(Graphics dc)
        {
            if (pressed)
            {
                if (animationFrames.Count > 1)
                {
                    sprite = animationFrames[1];    
                }
            }
            base.Draw(dc);
        }
    }
}
