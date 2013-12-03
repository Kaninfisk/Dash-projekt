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
        protected List<Rect> collisionBoxes;

        public List<Rect> CollisionBoxes
        {
            get { return collisionBoxes; }
        }

        public PointF Position
        {
            get { return position; }
            set { position = value; }
        }

        protected GameObject(PointF position, string imagePath, List<Rect> collisionBoxes)
        {
            this.collisionBoxes = collisionBoxes;
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
            foreach (Rect collisionBox in collisionBoxes)
            {
                SolidBrush b = new SolidBrush(Color.Black);
                Pen p = new Pen(b);
                RectangleF r = collisionBox.HitBox(position.X,position.Y);
                dc.DrawRectangle(p, r.X,r.Y,r.Width,r.Height);
            }
        }

        public virtual void Update(float fps, ref GameObject[,] levelMap)
        {
            
        }
    }
}
