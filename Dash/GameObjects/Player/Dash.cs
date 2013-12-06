using System;
using System.Collections.Generic;
using System.Drawing;

namespace Dash
{
    /// <summary>
    /// Class for player controlled character
    /// </summary>
    class Dash : GameObject
    {
        private bool dashRight; //indicates if dashing right
        private bool dashLeft; //indicates if dashing left
        private bool dashUp; //indicates if dashing up
        private bool falling; //indicates if falling
        private bool direction; //indicates direction for sprite flipping
        private int speed; //players speed
        private DateTime fallDelay; //delay used when u hit the ceiling
        private int fallSpeed;

        /// <summary>
        /// Sets falling
        /// </summary>
        public bool Falling
        {
            set { falling = value; }
        }

        /// <summary>
        /// Constructor that sets dash speed and falling
        /// </summary>
        /// <param name="speed">Speed of player</param>
        /// <param name="position">Position of the object on screen</param>
        /// <param name="imagePath">images for the object split string with ; for multiple images</param>
        /// <param name="collisionBoxes">Collisonboxes for the object of type Rect</param>
        public Dash(int speed, PointF position, string imagePath, List<Rect> collisionBoxes)
            : base(position, imagePath, collisionBoxes)
        {
            falling = true;
            this.speed = speed;
            fallSpeed = speed / 4;
        }

        /// <summary>
        /// Method that checks collisions with all other objects on levelmap
        /// </summary>
        /// <param name="levelMap">Reference to the levelmap for current loaded level</param>
        /// <param name="fps">Current fps the program is running at</param>
        /// <param name="playerState">Reference to the state of the player.</param>
        private void CheckCollisions(ref GameObject[,] levelMap, float fps, ref int playerState)
        {
            foreach (GameObject g in levelMap) //runs thru all the gameobjects in foreground map
            {
                if (g != null && g.GetType().ToString() == "Dash.TriggerBlock") //if its an object of the type triggerblock 
                {
                    CheckTriggerCollisions(g, ref playerState, ref levelMap);
                }
                else if (g != null && g.GetType().ToString() == "Dash.Enemy") //if its an object of type enemy
                {
                    CheckEnemyCollisions(g, ref playerState);
                }
                else if (g != null && g.GetType().ToString() == "Dash.CrumblingBlock" && falling) //if its an object of type CrumblingBlock
                {
                    CheckCrumblingCollisions(g, fps);
                }
                else if (g != null && g.GetType().ToString() != "Dash.Dash") //else if its any other type of object other than the player object
                {
                    CheckBlockCollisions(g, fps);
                }
            }
        }

        /// <summary>
        /// Checks for collisions with crumbling blocks
        /// </summary>
        /// <param name="g"></param>
        private void CheckCrumblingCollisions(GameObject g, float fps)
        {
            foreach (Rect r in collisionBoxes) //loops through all the Collisionboxes for player object
            {
                RectangleF rect = r.HitBox(position.X, position.Y + speed * (1 / fps));  //creates rectangle from current hitbox moved 10 pixels down

                foreach (Rect r2 in g.CollisionBoxes) //loops thru all the collisionboxes for the g object
                {
                    if (rect.IntersectsWith(r2.HitBox(g.Position.X, g.Position.Y))) //if player collides with the hitbox stop falling and make it start crumble
                    {
                        CrumblingBlock c = (CrumblingBlock)g;
                        c.Crumbling = true;
                        falling = false;
                        position.Y = g.Position.Y + r2.Position.Y - collisionBoxes[0].HitBox(Position.X, Position.Y).Height;
                    }
                }
            }
        }

        /// <summary>
        /// Checks for collisions with enemies
        /// </summary>
        /// <param name="g">Gameobject to check</param>
        /// <param name="playerState">Reference to the state of the player.</param>
        private void CheckEnemyCollisions(GameObject g, ref int playerState)
        {
            foreach (Rect r in collisionBoxes) //loops through all the Collisionboxes for player object
            {
                RectangleF rect = r.HitBox(position.X, position.Y); //creates rectangle from current hitbox

                foreach (Rect r2 in g.CollisionBoxes) //loops thru all the collisionboxes for the g object
                {
                    if (rect.IntersectsWith(r2.HitBox(g.Position.X, g.Position.Y))) //if player collides with the hitbox stop moving, set playerstate to dead switch to death sprite image and play gameover sound
                    {
                        Audio.PlaySoundFX("Audio\\Game Over_1.mp3");
                        dashRight = false;
                        falling = false;
                        dashLeft = false;
                        dashUp = false;
                        sprite = animationFrames[1];
                        playerState = 2;
                    }
                }
            }
        }

        /// <summary>
        /// Checks for collisions with triggers
        /// </summary>
        /// <param name="g">GameObject to check</param>
        /// <param name="playerState">Reference to the state of the player.</param>
        /// <param name="levelMap">Reference to the levelmap for current loaded level</param>
        private void CheckTriggerCollisions(GameObject g, ref int playerState, ref GameObject[,] levelMap)
        {
            foreach (Rect r in collisionBoxes) //loops through all the Collisionboxes for player object
            {
                RectangleF rect = r.HitBox(position.X, position.Y); //creates rectangle from current hitbox

                foreach (Rect r2 in g.CollisionBoxes) //loops thru all the collisionboxes for the g object
                {
                    if (rect.IntersectsWith(r2.HitBox(g.Position.X, g.Position.Y))) //if player collides with the hitbox trigger the button
                    {
                        TriggerBlock t = (TriggerBlock)g;
                        if (t.Type == 1) //if type is 1 then open door linked to the trigger
                        {
                            t.Pressed = true;
                            if (levelMap[t.Target.Y, t.Target.X] != null && levelMap[t.Target.Y, t.Target.X].GetType().ToString() == "Dash.GateBlock") //if the object linked to the trigger is of type gateblock open it and remove the hitboxes
                            {
                                GateBlock gate = (GateBlock)levelMap[t.Target.Y, t.Target.X];
                                gate.Open = true;
                                gate.CollisionBoxes = new List<Rect>();
                            }
                        }
                        else if (t.Type == 2) //if type is 2 then playerstate will be set to current level finished
                        {
                            playerState = 1;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Checks for collisions with solid objects
        /// </summary>
        /// <param name="g">GameObject to check</param>
        /// <param name="playerState">Reference to the state of the player.</param>
        /// <param name="fps">Current fps the program is running at</param>
        private void CheckBlockCollisions(GameObject g, float fps)
        {

            foreach (Rect r in collisionBoxes) //loops through all the Collisionboxes for player object
            {
                RectangleF rect = r.HitBox(position.X, position.Y); //creates rectangle from current hitbox
                if (dashRight)  //dashing right
                {
                    rect.Offset(new PointF(speed * (1 / fps), 0)); //offsets rectangle

                    foreach (Rect r2 in g.CollisionBoxes)  //loops thru all the collisionboxes for the g object
                    {
                        if (rect.IntersectsWith(r2.HitBox(g.Position.X, g.Position.Y))) //if player collides with hitbox stop dashing right start falling and move to the object
                        {
                            dashRight = false;
                            falling = true;
                            position.X = g.Position.X + r2.Position.X - collisionBoxes[0].HitBox(position.X, position.Y).Width;
                        }
                    }
                }
                else if (dashLeft) //dashing left
                {
                    rect.Offset(-speed * (1 / fps), 0); //offsets rectangle

                    foreach (Rect r2 in g.CollisionBoxes) //loops thru all the collisionboxes for the g object
                    {
                        if (rect.IntersectsWith(r2.HitBox(g.Position.X, g.Position.Y))) //if player collides with hitbox stop dashing left start falling and move to the object
                        {
                            dashLeft = false;
                            falling = true;
                            position.X = g.Position.X - r2.Position.X + r2.HitBox(g.Position.X, g.Position.Y).Width;
                        }
                    }
                }
                else if (dashUp) //dashing up
                {
                    rect.Offset(0, -speed * (1 / fps)); //offsets rectagle

                    foreach (Rect r2 in g.CollisionBoxes) //loops thru all the collisionboxes for the g object
                    {
                        if (rect.IntersectsWith(r2.HitBox(g.Position.X, g.Position.Y))) //if player collides with hitbox stop dashing up start falling after a delay and move to the object
                        {
                            dashUp = false;
                            falling = true;
                            position.Y = g.Position.Y + r2.Position.Y + r2.HitBox(g.Position.X, g.Position.Y).Height;
                            fallDelay = DateTime.Now;
                        }
                    }

                }

                else if (falling) //falling
                {
                    rect.Offset(0, ((fallSpeed / 100) * 100) * (1 / fps)); //offsets rectangle

                    foreach (Rect r2 in g.CollisionBoxes) //loops thru all the collisionboxes for the g object
                    {
                        if (rect.IntersectsWith(r2.HitBox(g.Position.X, g.Position.Y))) //if player collides with hitbox stop falling and move to object
                        {
                            falling = false;
                            fallSpeed = speed;
                            position.Y = g.Position.Y + r2.Position.Y - collisionBoxes[0].HitBox(Position.X, Position.Y).Height;
                        }
                    }

                }
            }
        }





        /// <summary>
        /// Checks if player is at edge of screen and makes sure that the player object cant go outside the screen area
        /// </summary>
        /// <param name="fps">Current fps the program is running at</param>
        private void CheckEdge(float fps)
        {
            if (dashUp) //dashing up
            {
                if (position.Y - speed * (1 / fps) <= 0) //if players position is about to move outside screen area stop dashing up and start falling
                {
                    dashUp = false;
                    falling = true;
                }
            }
            else if (dashLeft) //dashing left
            {
                if (position.X - speed * (1 / fps) <= 0) //if players position is about to move outside screen area stop dashing left and move to edge
                {
                    dashLeft = false;
                    position.X = 0;
                }
            }
            else if (dashRight) //dashing right
            {
                if (position.X + speed * (1 / fps) >= 864 - CollisionBoxes[0].HitBox(position.X, position.Y).Width) //if players position is about to move outside screen area stop dashing right and move to edge
                {
                    dashRight = false;
                }
            }
            else if (falling) //falling
            {
                if (position.Y + speed * (1 / fps) >= 672 - CollisionBoxes[0].HitBox(position.X, position.Y).Height) //if players position is about to move outside screen area stop falling and move to edge
                {
                    falling = false;
                    fallSpeed = speed;
                    position.Y = 672 - CollisionBoxes[0].HitBox(position.X, position.Y).Height;
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
            if (Keyboard.IsKeyDown(Config.RightKey)) //if rightkey is down
            {
                if (!dashUp && !dashLeft) //if not dashing left or up, dash right
                {
                    dashRight = true;
                }
            }
            else if (Keyboard.IsKeyDown(Config.LeftKey)) //if leftkey is down
            {
                if (!dashUp && !dashRight) //if not dashing right or up, dash left
                {
                    dashLeft = true;
                }
            }
            else if (Keyboard.IsKeyDown(Config.UpKey)) //if upkey is down
            {
                if (!dashLeft && !dashRight && !falling) //if not dashing right or left or falling, dash up
                {
                    dashUp = true;
                }

            }
            CheckEdge(fps);
            CheckCollisions(ref levelMap, fps, ref playerState);

            if (dashUp) //if dashup move speed multiplied by 1/fps up
            {
                position.Y -= speed * (1 / fps);
            }
            else if (dashLeft) //if dashup move speed multiplied by 1/fps left
            {
                if (!direction) //if changing direction flip playersprite
                {
                    sprite.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    direction = true;
                }
                position.X -= speed * (1 / fps);

            }
            else if (dashRight) //if dashup move speed multiplied by 1/fps right
            {
                if (direction) //if changing direction flip playersprite
                {
                    sprite.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    direction = false;
                }
                position.X += speed * (1 / fps);
            }
            else if (falling && DateTime.Now > fallDelay.AddMilliseconds(20)) //if falling and datetime is larger than delay move speed multiplied by 1/fps down
            {
                position.Y +=  fallSpeed * (1 / fps);
            }
        }
    }
}
