using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dash
{
    abstract class GameObject
    {
        protected PointF position;
        protected List<Image> animationFrames;
        protected float currentAnimationIndex;
        protected Image sprite;

        public RectangleF CollisionBox
        {
            get { return new RectangleF(position, sprite.Size); }
        }

        public PointF Position
        {
            get { return position; }
            set { position = value; }
        }

        protected GameObject(PointF position, string imagePath)
        {
            this.position = position;
            string[] imagePaths = imagePath.Split(';');
            animationFrames = new List<Image>();
            foreach (string p in imagePaths)
            {
                animationFrames.Add(Image.FromFile(p));
            }
            sprite = animationFrames[0];
        }

        public virtual void Draw(Graphics dc)
        {
            dc.DrawImage(sprite, position.X, position.Y, sprite.Width, sprite.Height);
        }

        public virtual void Update(float fps)
        {
            
        }
    }
}
