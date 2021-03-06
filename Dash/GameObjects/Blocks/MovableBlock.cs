﻿using System.Collections.Generic;
using System.Drawing;

namespace Dash
{
    /// <summary>
    /// Class for movable blocks
    /// </summary>
    class MovableBlock : GridBlock
    {
        protected int speed; // Pixels to move per second
        protected int startDirection;
        protected int direction; // 1 = Up, 2 = down, 3 = left, 4 = right
        protected PointF endPosition; // Position to stop at
        protected PointF startPosition;

        /// <summary>
        /// Constructor that sets endPosition, speed, direction and distance
        /// </summary>
        /// <param name="speed">Speed to move atin pixels per second</param>
        /// <param name="direction">Direction to move 1 = Up, 2 = down, 3 = left, 4 = right</param>
        /// <param name="distance">Distance to move counted in tiles</param>
        /// <param name="position">Position of the object on screen</param>
        /// <param name="imagePath">images for the object split string with ; for multiple images</param>
        /// <param name="collisionBoxes">Collisonboxes for the object of type Rect</param>>
        public MovableBlock(int speed, int direction, int distance, PointF position, string imagePath, List<Rect> collisionBoxes)
            : base(position, imagePath, collisionBoxes)
        {
            endPosition = new PointF(position.X, position.Y);
            startPosition = new PointF(position.X, position.Y);
            this.speed = speed;
            this.direction = direction;
            this.startDirection = direction;
            switch (direction)
            {
                case 1:
                    endPosition.Y -= distance * 48;
                    break;
                case 2:
                    endPosition.Y += distance * 48;
                    break;
                case 3:
                    endPosition.X -= distance * 48;
                    break;
                case 4:
                    endPosition.X += distance * 48;
                    break;
            }
        }

        /// <summary>
        /// Method that moves the block
        /// </summary>
        /// <param name="fps">Current fps the program is running at</param>
        /// <param name="levelMap">Reference to the levelmap for current loaded level</param>
        /// <param name="playerState">Reference to the state of the player.</param>
        public override void Update(float fps, ref GameObject[,] levelMap, ref int playerState)
        {
            base.Update(fps, ref levelMap, ref playerState);


            switch (direction)
            {
                case 1:
                    if (startDirection == 2)
                    {
                        if (this.position.Y <= startPosition.Y)
                        {
                            direction = 2;
                            this.position.Y += speed * 1 / fps;
                        }
                        else
                        {
                            this.position.Y -= speed * 1 / fps;
                        }
                    }
                    else
                    {
                        if (this.position.Y <= endPosition.Y)
                        {
                            direction = 2;
                            this.position.Y += speed * 1 / fps;
                        }
                        else
                        {
                            this.position.Y -= speed * 1 / fps;
                        }
                    }
                    break;
                case 2:
                    if (startDirection == 1)
                    {
                        if (this.position.Y <= startPosition.Y)
                        {
                            direction = 1;
                            this.position.Y -= speed * 1 / fps;
                        }
                        else
                        {
                            this.position.Y += speed * 1 / fps;
                        }
                    }
                    else
                    {
                        if (this.position.Y >= endPosition.Y)
                        {
                            direction = 1;
                            this.position.Y -= speed * 1 / fps;
                        }
                        else
                        {
                            this.position.Y += speed * 1 / fps;
                        }
                    }

                    break;
                case 3:
                    if (startDirection == 4)
                    {
                        if (this.position.X <= startPosition.X)
                        {
                            direction = 4;
                            this.position.X += speed * 1 / fps;
                        }
                        else
                        {
                            this.position.X -= speed * 1 / fps;
                        }
                    }
                    else
                    {
                        if (this.position.X <= endPosition.X)
                        {
                            direction = 4;
                            this.position.X += speed * 1 / fps;
                        }
                        else
                        {
                            this.position.X -= speed * 1 / fps;
                        }
                    }
                    break;
                case 4:
                    if (startDirection == 3)
                    {
                        if (this.position.X >= startPosition.X)
                        {
                            direction = 3;
                            this.position.X -= speed * 1 / fps;
                        }
                        else
                        {
                            this.position.X += speed * 1 / fps;
                        }
                    }
                    else
                    {
                        if (this.position.X >= endPosition.X)
                        {
                            direction = 3;
                            this.position.X -= speed * 1 / fps;
                        }
                        else
                        {
                            this.position.X += speed * 1 / fps;
                        }
                    }
                    break;
            }
            CheckCollisions(ref levelMap, fps);
        }

        /// <summary>
        /// finds player object in levelMap
        /// </summary>
        /// <param name="levelMap"></param>
        /// <param name="fps"></param>
        private void CheckCollisions(ref GameObject[,] levelMap, float fps)
        {
            foreach (GameObject g in levelMap)
            {
                if (g != null)
                {
                    if (g.GetType().ToString() == "Dash.Dash")
                    {
                        MovePlayer(ref levelMap, g, fps);
                    }
                }
            }
        }

        /// <summary>
        /// If hitbox of block collides with player it moves the player accordingly
        /// </summary>
        /// <param name="levelMap"></param>
        /// <param name="g"></param>
        /// <param name="fps"></param>
        private void MovePlayer(ref GameObject[,] levelMap,GameObject g, float fps)
        {
            foreach (Rect r in collisionBoxes)
            {
                RectangleF rect = r.HitBox(position.X, position.Y - 2);
                
                foreach (Rect r2 in g.CollisionBoxes)
                {
                    if (rect.IntersectsWith(r2.HitBox(g.Position.X, g.Position.Y)))
                    {
                        Dash d = (Dash)g;
                        if (!d.DashLeft && !d.DashRight && !d.DashUp)
                        {
                            if (direction == 1)
                            {
                                g.Position = new PointF(g.Position.X, g.Position.Y - speed * 1 / fps);
                            }
                            else if (direction == 2)
                            {
                                g.Position = new PointF(g.Position.X, g.Position.Y + speed * 1 / fps);
                            }
                            else if (direction == 3)
                            {
                                g.Position = new PointF(g.Position.X - speed * 1 / fps, g.Position.Y);
                            }
                            else if (direction == 4)
                            {
                                g.Position = new PointF(g.Position.X + speed * 1 / fps, g.Position.Y);
                            }
                        }
                    }
                }
            }

            Dash player = (Dash)g;

            foreach (GameObject g2 in levelMap) //runs thru all the gameobjects in foreground map
            {
                if (g2 != null && g2.GetType().ToString() != "Dash.Dash" && g2.GetType().ToString() != "Dash.TriggerBlock" && g2.GetType().ToString() != "Dash.Enemy")
                {
                    if (!player.DashLeft && !player.DashRight && !player.DashUp)
                    {
                        foreach (Rect r in player.CollisionBoxes)
                        {
                            RectangleF rect = r.HitBox(player.Position.X, player.Position.Y);

                            foreach (Rect r2 in g2.CollisionBoxes)
                            {
                                if (rect.IntersectsWith(r2.HitBox(g2.Position.X, g2.Position.Y)))
                                {
                                    if (direction == 1)
                                    {
                                        
                                    }
                                    else if (direction == 2)
                                    {
                                        
                                    }
                                    else if (direction == 3)
                                    {
                                        player.Position = new PointF(g2.Position.X - r2.Position.X + r2.HitBox(g2.Position.X, g2.Position.Y).Width, player.Position.Y);
                                    }
                                    else if (direction == 4)
                                    {
                                        player.Position = new PointF(g2.Position.X + r2.Position.X - player.CollisionBoxes[0].HitBox(player.Position.X, player.Position.Y).Width, player.Position.Y);
                                    }
                                    
                                }
                            }
                        }
                    }
                }
            }
        }
    }

}
