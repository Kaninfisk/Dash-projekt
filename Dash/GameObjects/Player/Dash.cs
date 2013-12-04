﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dash
{
    /// <summary>
    /// Class for player controlled character
    /// </summary>
    class Dash : Player
    {
        private int dash;  //Dash speed
        private bool dashRight; //indicates if dashing right
        private bool dashLeft; //indicates if dashing left
        private bool dashUp; //indicates if dashing up
        private bool falling; //indicates if falling
        private bool direction; //indicates direction for sprite flipping

        /// <summary>
        /// Constructor that sets dash speed and falling
        /// </summary>
        /// <param name="dash">Dash speed</param>
        /// <param name="health">Health of player</param>
        /// <param name="speed">Speed of player</param>
        /// <param name="name">Name of player</param>
        /// <param name="position">Position of the object on screen</param>
        /// <param name="imagePath">images for the object split string with ; for multiple images</param>
        /// <param name="collisionBoxes">Collisonboxes for the object of type Rect</param>
        public Dash(int dash, int health, int speed, string name, PointF position, string imagePath, List<Rect> collisionBoxes)
            : base(health, speed, name, position, imagePath, collisionBoxes)
        {
            this.dash = dash;
            falling = true;

        }

        /// <summary>
        /// Draw override for more advanced draw method
        /// </summary>
        /// <param name="dc">Graphics object that you want to draw to</param>
        public override void Draw(Graphics dc)
        {
            base.Draw(dc);
        }

        /// <summary>
        /// Method that checks collisions with all other objects on levelmap
        /// </summary>
        /// <param name="fps">Current fps the program is running at</param>
        /// <param name="levelMap">Reference to the levelmap for current loaded level</param>
        /// <param name="playerState">Reference to the state of the player.</param>
        public void CheckCollisions(ref GameObject[,] levelMap, float fps, ref int playerState)
        {
            if (dashUp)
            {
                if (position.Y - dash * (1 / fps) <= 0)
                {
                    dashUp = false;
                    falling = true;
                }
            }
            else if (dashLeft)
            {
                if (position.X - dash * (1 / fps) <= 0)
                {
                    dashLeft = false;
                    position.X = 0;
                }
            }
            else if (dashRight)
            {
                if (position.X + dash * (1 / fps) >= 864 - CollisionBoxes[0].HitBox(position.X, position.Y).Width)
                {
                    dashRight = false;
                }
            }
            else if (falling)
            {
                if (position.Y + dash * (1 / fps) >= 672 - CollisionBoxes[0].HitBox(position.X,position.Y).Height)
                {
                    falling = false;
                    position.Y = 672 - CollisionBoxes[0].HitBox(position.X, position.Y).Height;
                }
            }

            foreach (GameObject g in levelMap)
            {
                if (g != null && g.GetType().ToString() == "Dash.TriggerBlock")
                {
                    foreach (Rect r in collisionBoxes)
                    {
                        RectangleF rect = r.HitBox(position.X, position.Y);

                        foreach (Rect r2 in g.CollisionBoxes)
                        {
                            if (rect.IntersectsWith(r2.HitBox(g.Position.X, g.Position.Y)))
                            {
                                TriggerBlock t = (TriggerBlock) g;
                                if (t.Type == 1)
                                {
                                    t.Pressed = true;
                                    if (levelMap[t.Target.Y, t.Target.X].GetType().ToString() == "Dash.GateBlock")
                                    {
                                        GateBlock gate = (GateBlock) levelMap[t.Target.Y, t.Target.X];
                                        gate.Open = true;
                                        gate.CollisionBoxes = new List<Rect>();
                                    }
                                }
                                else if (t.Type == 2)
                                {
                                    playerState = 1;
                                }
                            }
                        }
                    }
                }
                else if (g!= null && g.GetType().ToString() == "Dash.Enemy")
                {
                    foreach (Rect r in collisionBoxes)
                    {
                        RectangleF rect = r.HitBox(position.X, position.Y);

                        foreach (Rect r2 in g.CollisionBoxes)
                        {
                            if (rect.IntersectsWith(r2.HitBox(g.Position.X, g.Position.Y)))
                            {
                                dashRight = false;
                                falling = false;
                                dashLeft = false;
                                dashUp = false;
                                playerState = 2;
                            }
                        }
                    }
                }
                else if (g != null && g.GetType().ToString() != "Dash.Dash")
                {
                    if (dashRight)
                    {
                        foreach (Rect r in collisionBoxes)
                        {
                            RectangleF rect = r.HitBox(position.X,position.Y);
                            rect.Offset(new PointF(dash  * (1 / fps),0));

                            foreach (Rect r2 in g.CollisionBoxes)
                            {
                                if (rect.IntersectsWith(r2.HitBox(g.Position.X, g.Position.Y)))
                                {
                                    dashRight = false;
                                    falling = true;
                                    position.X = g.Position.X + r2.Position.X - collisionBoxes[0].HitBox(position.X,position.Y).Width;
                                }
                            }
                        }
                    }
                    else if (dashLeft)
                    {

                        foreach (Rect r in collisionBoxes)
                        {
                            RectangleF rect = r.HitBox(position.X,position.Y);
                            rect.Offset(-dash * (1 / fps),0);

                            foreach (Rect r2 in g.CollisionBoxes)
                            {
                                if (rect.IntersectsWith(r2.HitBox(g.Position.X, g.Position.Y)))
                                {
                                    dashLeft = false;
                                    falling = true;
                                    position.X = g.Position.X - r2.Position.X + r2.HitBox(g.Position.X, g.Position.Y).Width;
                                }
                            }
                        }
                    }
                    else if (dashUp)
                    {
                        foreach (Rect r in collisionBoxes)
                        {
                            RectangleF rect = r.HitBox(position.X,position.Y);
                            rect.Offset(0,-dash * (1 / fps));

                            foreach (Rect r2 in g.CollisionBoxes)
                            {
                                if (rect.IntersectsWith(r2.HitBox(g.Position.X, g.Position.Y)))
                                {
                                    dashUp = false;
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

        /// <summary>
        /// Override for update that gets user input and moves accordingly
        /// </summary>
        /// <param name="fps">Current fps the program is running at</param>
        /// <param name="levelMap">Reference to the levelmap for current loaded level</param>
        /// <param name="playerState">Reference to the state of the player.</param>
        public override void Update(float fps, ref GameObject[,] levelMap, ref int playerState)
        {
            base.Update(fps, ref levelMap, ref playerState);
            if (Keyboard.IsKeyDown(Config.RightKey))
            {
                if (!dashUp && !dashLeft)
                {
                    dashRight = true;
                }
            }
            else if (Keyboard.IsKeyDown(Config.LeftKey))
            {
                if (!dashUp && !dashRight)
                {
                    dashLeft = true;
                }
            }
            else if (Keyboard.IsKeyDown(Config.UpKey))
            {
                if (!dashLeft && !dashRight && !falling)
                {
                    dashUp = true;
                }

            }
            CheckCollisions(ref levelMap, fps, ref playerState);

            if (dashUp)
            {
                position.Y -= dash * (1 / fps);
            }
            else if (dashLeft)
            {
                if (!direction)
                {
                    sprite.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    direction = true;
                }
                position.X -= dash * (1 / fps);
                
            }
            else if (dashRight)
            {
                if (direction)
                {
                    sprite.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    direction = false;
                }
                position.X += dash * (1 / fps);
            }
            else if (falling)
            {
                position.Y += dash / 3 * 2 * (1 / fps);
            }
        }
    }
}
