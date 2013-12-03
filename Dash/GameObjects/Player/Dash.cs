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
            : base(health, speed, name, position, imagePath,collisionBoxes)
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
                        RectangleF rect = CollisionBox;
                        rect.X += dash * (1 / fps);
                        foreach (RectangleF r in collisionBoxes)
                        {
                            if (rect.IntersectsWith(r))
                            {
                                dashright = false;
                                falling = true;
                                position.X = r.X - r.Width;
                            }
                        }
                    }
                    else if (dashleft)
                    {
                        RectangleF rect = CollisionBox;
                        rect.X -= dash * (1 / fps);
                        foreach (RectangleF r in collisionBoxes)
                        {
                            if (rect.IntersectsWith(r))
                            {
                                dashleft = false;
                                falling = true;
                                position.X = r.X + r.Width;
                            }
                        }
                    }
                    else if (dashup)
                    {
                        RectangleF rect = CollisionBox;
                        rect.Y -= dash * (1 / fps);
                        foreach (RectangleF r in collisionBoxes)
                        {
                            if (rect.IntersectsWith(r))
                            {
                                dashup = false;
                                falling = true;
                                position.Y = r.Y + r.Height;
                            }
                        }
                    }
                    else if (falling)
                    {
                        RectangleF rect = CollisionBox;
                        rect.Y += (dash / 3 * 2) * (1 / fps);

                        foreach (RectangleF r in collisionBoxes)
                        {
                            
                            if (rect.IntersectsWith(r))
                            {
                                falling = false;
                                position.Y = r.Y - 96;
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
                position.Y += dash/3*2  *(1/fps);
                for (int i = 0; i < collisionBoxes.Count; i++)
                {
                    collisionBoxes[i] = new RectangleF(collisionBoxes[i].X,collisionBoxes[i].Y + dash / 3 * 2 * (1 / fps) ,collisionBoxes[i].Width,collisionBoxes[i].Height);
                }
            }
        }
    }
}
