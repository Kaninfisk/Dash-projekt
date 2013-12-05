using System.Collections.Generic;
using System.Drawing;

namespace Dash
{
    class CrumblingBlock:GridBlock
    {
        private float time;
        private bool crumbling;

        public bool Crumbling
        {
            get { return crumbling; }
            set { crumbling = value; }
        }
        

        public CrumblingBlock(PointF position, string imagePath, List<Rect> collisionBoxes)
            : base(position,imagePath,collisionBoxes)
        {
            time = 5;
        }

        public override void Update(float fps, ref GameObject[,] levelMap, ref int playerState)
        {
            if (Crumbling)
            {
                if (time <= 0)
                {
                    collisionBoxes = new List<Rect>();
                    sprite = null;
                }
            }
        }
    }
}
