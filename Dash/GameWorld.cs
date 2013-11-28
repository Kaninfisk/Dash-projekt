using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dash
{
    class GameWorld
    {
        private List<Level> levels;
        private Level currentLevel;
        private Graphics dc;
        private float currentFPS;
        private BufferedGraphics buffer;
        private bool menu = true;
        private Menu m;


        

        private Keys input;

        public Keys Input
        {
            set { input = value; }
        }

        public GameWorld(Graphics dc, Rectangle displayRectangle)
        {
            buffer = BufferedGraphicsManager.Current.Allocate(dc, displayRectangle);
            this.dc = buffer.Graphics;
            m = new Menu(this.dc);
            SetupGameWorld();

        }

        public void GameLoop()
        {
            dc.Clear(Color.White);
            if (menu)
            {
                TimeSpan deltaTime = DateTime.Now - m.LastClick;
                if (deltaTime.TotalMilliseconds > 200)
                {
                    m.Update(ref input);
                }
                m.DrawMenu();
            }
            buffer.Render();
        }

        public void SetupGameWorld()
        {
            Audio.PlayMusic("audio/music.mp3");
        }
    }
}
