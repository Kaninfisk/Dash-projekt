using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dash
{
    class GateBlock:SolidBlock
    {
        private bool open;

        public bool Open
        {
            get { return open; }
            set { open = value; }
        }
        

        public GateBlock(PointF position, string imagePath, List<Rect> collisionBoxes)
            : base(position, imagePath, collisionBoxes)
        {
            open = false;
        }

        public override void Draw(Graphics dc)
        {
            if (Open)
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
