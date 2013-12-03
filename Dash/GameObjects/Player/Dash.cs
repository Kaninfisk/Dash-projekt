using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dash
{
    class Dash : Player
    {
        private int dash;
        private bool dashright;
        private bool dashleft;
        private bool dashup;
        private bool falling;

        public Dash(int dash, int health, int speed, string name, PointF position, string imagePath, List<RectangleF> collisionBoxes)
            : base(health, speed, name, position, imagePath, collisionBoxes)
        {
            this.dash = dash;
            falling = true;
        }

        public override void Draw(Graphics dc)
        {
            base.Draw(dc);
        }

        public void CheckCollisions(ref GameObject[,] levelMap, float fps)
        {
            foreach (GameObject g in levelMap)
            {
                if (g != null && g.GetType().ToString() != "Dash.Dash")
                {
                    if (dashright)
                    {
                        foreach (RectangleF r in collisionBoxes)
                        {
                            RectangleF rect = r;
                            rect.X += dash * (1 / fps);

                            foreach (RectangleF r2 in g.CollisionBoxes)
                            {
                                if (rect.IntersectsWith(r2))
                                {
                                    List<RectangleF> cTemp = new List<RectangleF>();
                                    dashright = false;
                                    falling = true;
                                    position.X = r2.X - collisionBoxes[0].Width;
                                    for (int i = 0; i < collisionBoxes.Count; i++)
                                    {
                                        cTemp.Add(new RectangleF(r2.X - collisionBoxes[i].Width, collisionBoxes[i].Y, collisionBoxes[i].Width, collisionBoxes[i].Height));
                                    }
                                    collisionBoxes = cTemp;
                                }
                            }
                        }
                    }
                    else if (dashleft)
                    {

                        foreach (RectangleF r in collisionBoxes)
                        {
                            RectangleF rect = r;
                            rect.X -= dash  * (1 / fps);

                            foreach (RectangleF r2 in g.CollisionBoxes)
                            {
                                if (rect.IntersectsWith(r2))
                                {
                                    List<RectangleF> cTemp = new List<RectangleF>();
                                    dashleft = false;
                                    falling = true;
                                    position.X = r2.X + r2.Width;
                                    for (int i = 0; i < collisionBoxes.Count; i++)
                                    {
                                        cTemp.Add(new RectangleF(r2.X + r2.Width, collisionBoxes[i].Y, collisionBoxes[i].Width, collisionBoxes[i].Height));
                                    }
                                    collisionBoxes = cTemp;
                                }
                            }
                        }
                    }
                    else if (dashup)
                    {
                        foreach (RectangleF r in collisionBoxes)
                        {
                            RectangleF rect = r;
                            rect.Y -= dash * (1 / fps);

                            foreach (RectangleF r2 in g.CollisionBoxes)
                            {
                                if (rect.IntersectsWith(r2))
                                {
                                    List<RectangleF> cTemp = new List<RectangleF>();
                                    dashup = false;
                                    falling = true;
                                    position.Y = r2.Y +  r2.Height;
                                    for (int i = 0; i < collisionBoxes.Count; i++)
                                    {
                                        cTemp.Add(new RectangleF(collisionBoxes[i].X, r2.Y + r2.Height, collisionBoxes[i].Width, collisionBoxes[i].Height));
                                    }
                                    collisionBoxes = cTemp;

                                }
                            }
                        }
                    }
                    else if (falling)
                    {
                        foreach (RectangleF r in collisionBoxes)
                        {
                            RectangleF rect = r;
                            rect.Y += (dash / 3 * 2) * (1 / fps);

                            foreach (RectangleF r2 in g.CollisionBoxes)
                            {
                                if (rect.IntersectsWith(r2))
                                {
                                    List<RectangleF> cTemp = new List<RectangleF>();
                                    falling = false;
                                    position.Y = r2.Y - collisionBoxes[0].Height;
                                    for (int i = 0; i < collisionBoxes.Count; i++)
                                    {
                                        cTemp.Add(new RectangleF(collisionBoxes[i].X, r2.Y - collisionBoxes[i].Height, collisionBoxes[i].Width, collisionBoxes[i].Height));
                                    }
                                    collisionBoxes = cTemp;
                                }
                            }
                        }
                    }
                }
            }
        }

        public override void Update(float fps, ref GameObject[,] levelMap)
        {
            base.Update(fps, ref levelMap);
            if (Keyboard.IsKeyDown(Config.RightKey))
            {
                if (!dashup && !dashleft)
                {
                    dashright = true;
                }
            }
            else if (Keyboard.IsKeyDown(Config.LeftKey))
            {
                if (!dashup && !dashright)
                {
                    dashleft = true;
                }
            }
            else if (Keyboard.IsKeyDown(Config.UpKey))
            {
                if (!dashleft && !dashright && !falling)
                {
                    dashup = true;
                }

            }
            CheckCollisions(ref levelMap, fps);

            if (dashup)
            {
                position.Y -= dash * (1 / fps);
                for (int i = 0; i < collisionBoxes.Count; i++)
                {
                    collisionBoxes[i] = new RectangleF(collisionBoxes[i].X, collisionBoxes[i].Y - dash * (1 / fps), collisionBoxes[i].Width, collisionBoxes[i].Height);
                }
            }
            else if (dashleft)
            {
                position.X -= dash * (1 / fps);
                for (int i = 0; i < collisionBoxes.Count; i++)
                {
                    collisionBoxes[i] = new RectangleF(collisionBoxes[i].X - dash * (1 / fps), collisionBoxes[i].Y, collisionBoxes[i].Width, collisionBoxes[i].Height);
                }
            }
            else if (dashright)
            {
                position.X += dash * (1 / fps);
                for (int i = 0; i < collisionBoxes.Count; i++)
                {
                    collisionBoxes[i] = new RectangleF(collisionBoxes[i].X + dash * (1 / fps), collisionBoxes[i].Y, collisionBoxes[i].Width, collisionBoxes[i].Height);
                }
            }
            else if (falling)
            {
                position.Y += dash / 3 * 2 * (1 / fps);
                for (int i = 0; i < collisionBoxes.Count; i++)
                {
                    collisionBoxes[i] = new RectangleF(collisionBoxes[i].X, collisionBoxes[i].Y + (((dash / 3) * 2) * (1 / fps)), collisionBoxes[i].Width, collisionBoxes[i].Height);
                }
            }
        }
    }
}
