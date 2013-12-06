using System.Collections.Generic;
using System.Drawing;

namespace Dash
{
    /// <summary>
    /// GameObject for Blocks that start dissapearing when u land on them
    /// </summary>
    class CrumblingBlock:GridBlock
    {
        private float time; //Time used for how long untill the platform dissapears
        private bool crumbling; //Sets if the block should dissapear or not

        /// <summary>
        /// Gets or sets crumbling
        /// </summary>
        public bool Crumbling
        {
            get { return crumbling; }
            set { crumbling = value; }
        }
        
        /// <summary>
        /// Constructor that sets time for block to dissapear to 5 secs
        /// </summary>
        /// <param name="position">Position of the object on screen</param>
        /// <param name="imagePath">images for the object split string with ; for multiple images</param>
        /// <param name="collisionBoxes">Collisonboxes for the object of type Rect</param>>
        public CrumblingBlock(PointF position, string imagePath, List<Rect> collisionBoxes)
            : base(position,imagePath,collisionBoxes)
        {
            time = 3;
        }

        /// <summary>
        /// Method that counts down time and removes block if crumbling is set to true
        /// </summary>
        /// <param name="fps">Current fps the program is running at</param>
        /// <param name="levelMap">Reference to the levelmap for current loaded level</param>
        /// <param name="playerState">Reference to the state of the player.</param>
        public override void Update(float fps, ref GameObject[,] levelMap, ref int playerState)
        {
            if (Crumbling)
            {
                sprite = animationFrames[1];
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
