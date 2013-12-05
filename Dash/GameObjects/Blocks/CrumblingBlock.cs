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
                time -= 1/fps;
                if (time <= 0)
                {
                    foreach (GameObject g in levelMap)
                    {
                        if (g != null)
                        {
                            if (g.GetType().ToString() == "Dash.Dash")
                            {
                                foreach (Rect r in collisionBoxes)
                                {
                                    RectangleF rect = r.HitBox(position.X, position.Y - 10);

                                    foreach (Rect r2 in g.CollisionBoxes)
                                    {
                                        if (rect.IntersectsWith(r2.HitBox(g.Position.X, g.Position.Y)))
                                        {
                                            Dash d = (Dash) g;
                                            d.Falling = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    collisionBoxes = new List<Rect>();
                    sprite = null;
                }
            }
        }
    }
}
