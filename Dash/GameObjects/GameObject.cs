using System.Collections.Generic;
using System.Drawing;

namespace Dash
{
    /// <summary>
    /// Superclass for all objects in the gameworld
    /// </summary>
    abstract class GameObject
    {
        protected PointF position;
        protected List<Image> animationFrames;
        protected Image sprite;
        protected List<Rect> collisionBoxes;

        /// <summary>
        /// Gets or sets CollisionBoxes of type rect
        /// </summary>
        public List<Rect> CollisionBoxes
        {
            get { return collisionBoxes; }
            set { collisionBoxes = value; }
        }

        /// <summary>
        /// Gets the Position as PointF
        /// </summary>
        public PointF Position
        {
            get { return position; }
            set { position = value; }
        }

        /// <summary>
        /// Constructor for gameobject that sets up standard functionality
        /// </summary>
        /// <param name="position">Position of the object on screen</param>
        /// <param name="imagePath">images for the object split string with ; for multiple images</param>
        /// <param name="collisionBoxes">Collisonboxes for the object of type Rect</param>
        protected GameObject(PointF position, string imagePath, List<Rect> collisionBoxes)
        {
            this.collisionBoxes = collisionBoxes;
            this.position = position;
            if (imagePath != "")
            {
                string[] imagePaths = imagePath.Split(';');
                animationFrames = new List<Image>();
                foreach (string p in imagePaths)
                {
                    animationFrames.Add(Image.FromFile(p));
                }
                sprite = animationFrames[0];
            }
        }

        /// <summary>
        /// Virtual method that draws the gameobjects if they have a sprite can be overrided if more complex draw method is needed for sub classes
        /// </summary>
        /// <param name="dc">Graphics object that you want to draw to</param>
        public virtual void Draw(Graphics dc)
        {
            if (sprite != null)
            {
                dc.DrawImage(sprite, (int)position.X, (int)position.Y, sprite.Width, sprite.Height);
            }
#if DEBUG
            foreach (Rect collisionBox in collisionBoxes)
            {
                SolidBrush b = new SolidBrush(Color.Black);
                Pen p = new Pen(b);
                RectangleF r = collisionBox.HitBox(position.X, position.Y);
                dc.DrawRectangle(p, r.X, r.Y, r.Width, r.Height);
            }
#endif
        }

        /// <summary>
        /// Virtual update method for gameobjects with no code because the default behavior for gameobjects is to do nothing.
        /// </summary>
        /// <param name="fps">Current fps the program is running at</param>
        /// <param name="levelMap">Reference to the levelmap for current loaded level</param>
        /// <param name="playerState">Reference to the state of the player.</param>
        public virtual void Update(float fps, ref GameObject[,] levelMap, ref int playerState)
        {

        }
    }
}
