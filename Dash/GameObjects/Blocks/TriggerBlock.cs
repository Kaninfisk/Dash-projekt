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

        public int Type
        {
            get { return type; }
            set { type = value; }
        }
        

        public TriggerBlock(int type, PointF position, string imagePath, List<Rect> collisionBoxes)
            : base(position, imagePath,collisionBoxes)
        {
            this.type = type;
        }
    }
}
