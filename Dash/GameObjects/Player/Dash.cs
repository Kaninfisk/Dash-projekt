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

        public Dash(int dash, int health, int speed, string name, PointF position, string imagePath)
            : base(health, speed, name, position, imagePath)
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
                        if (rect.IntersectsWith(g.CollisionBox))
                        {
                            dashright = false;
                            falling = true;
                            position.X = g.Position.X - 48;
                        }
                    }
                    else if (dashleft)
                    {
                        RectangleF rect = CollisionBox;
                        rect.X -= dash * (1 / fps);
                        if (rect.IntersectsWith(g.CollisionBox))
                        {
                            dashleft = false;
                            falling = true;
                            position.X = g.Position.X + 48;
                        }
                    }
                    else if (dashup)
                    {
                        RectangleF rect = CollisionBox;
                        rect.Y -= dash*(1/fps);
                        if (rect.IntersectsWith(g.CollisionBox))
                        {
                            dashup = false;
                            falling = true;
                            position.Y = g.Position.Y + 48;
                        }
                        
                    }
                    else if (falling)
                    {
                        RectangleF rect = CollisionBox;
                        rect.Y += (dash / 3 * 2) * (1 / fps);
                        if (rect.IntersectsWith(g.CollisionBox))
                        {
                            falling = false;
                            position.Y = g.Position.Y - 96;
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
                if (!dashup && !dashright)
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
                position.Y += dash/3*2  *(1/fps);
            }
        }
    }
}
