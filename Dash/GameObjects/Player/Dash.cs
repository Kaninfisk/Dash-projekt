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

        public Dash(int dash, int health, int speed, string name, PointF position, string imagePath, List<Rect> collisionBoxes)
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
                        foreach (Rect r in collisionBoxes)
                        {
                            RectangleF rect = r.HitBox(position.X,position.Y);
                            rect.Offset(new PointF(dash  * (1 / fps),0));

                            foreach (Rect r2 in g.CollisionBoxes)
                            {
                                if (rect.IntersectsWith(r2.HitBox(g.Position.X, g.Position.Y)))
                                {
                                    dashright = false;
                                    falling = true;
                                    position.X = g.Position.X + r2.Position.X - collisionBoxes[0].HitBox(position.X,position.Y).Width;
                                }
                            }
                        }
                    }
                    else if (dashleft)
                    {

                        foreach (Rect r in collisionBoxes)
                        {
                            RectangleF rect = r.HitBox(position.X,position.Y);
                            rect.Offset(-dash * (1 / fps),0);

                            foreach (Rect r2 in g.CollisionBoxes)
                            {
                                if (rect.IntersectsWith(r2.HitBox(g.Position.X, g.Position.Y)))
                                {
                                    dashleft = false;
                                    falling = true;
                                    position.X = g.Position.X - r2.Position.X + r2.HitBox(g.Position.X, g.Position.Y).Width;
                                }
                            }
                        }
                    }
                    else if (dashup)
                    {
                        foreach (Rect r in collisionBoxes)
                        {
                            RectangleF rect = r.HitBox(position.X,position.Y);
                            rect.Offset(0,-dash * (1 / fps));

                            foreach (Rect r2 in g.CollisionBoxes)
                            {
                                if (rect.IntersectsWith(r2.HitBox(g.Position.X, g.Position.Y)))
                                {
                                    dashup = false;
                                    falling = true;
                                    position.Y = g.Position.Y + r2.Position.Y + r2.HitBox(g.Position.X, g.Position.Y).Height;
                                }
                            }
                        }
                    }
                    else if (falling)
                    {
                        foreach (Rect r in collisionBoxes)
                        {
                            RectangleF rect = r.HitBox(position.X,position.Y);
                            rect.Offset(0,(dash / 3 * 2) * (1 / fps));

                            foreach (Rect r2 in g.CollisionBoxes)
                            {
                                if (rect.IntersectsWith(r2.HitBox(g.Position.X, g.Position.Y)))
                                {
                                    falling = false;
                                    position.Y = g.Position.Y + r2.Position.Y - collisionBoxes[0].HitBox(Position.X, Position.Y).Height;
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
            }
            else if (dashleft)
            {
                position.X -= dash * (1 / fps);
            }
            else if (dashright)
            {
                position.X += dash * (1 / fps);
            }
            else if (falling)
            {
                position.Y += dash / 3 * 2 * (1 / fps);
            }
        }
    }
}
