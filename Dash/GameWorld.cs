using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        private bool menu;
        private Menu m;
        private DateTime lastFrameStarted;
        private bool gameRunning;
        
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
            TimeSpan deltaTime2 = DateTime.Now - lastFrameStarted;
            int milliSeconds = deltaTime2.Milliseconds > 0 ? deltaTime2.Milliseconds : 1;
            currentFPS = 1000 / milliSeconds;
            lastFrameStarted = DateTime.Now;

            

            dc.Clear(Color.White);
            //Font f = new Font("Arial", 12);
            //Brush b = new SolidBrush(Color.Black);
            //dc.DrawString(currentFPS.ToString(), f, b, 600, 0);
            if (!menu && gameRunning)
            {
                Update();
                Draw();

                if (Keyboard.IsKeyDown(Keys.Escape))
                {
                    TimeSpan deltaTime = DateTime.Now - m.LastClick;
                    if (deltaTime.TotalMilliseconds > 200)
                    {
                        menu = true;
                        m.LastClick = DateTime.Now;
                    }
                }
            }
            else if (menu)
            {

                m.Update(ref input, ref gameRunning, ref menu);
                m.DrawMenu();
            }
            
            buffer.Render();
        }

        public void Draw()
        {
            foreach (GameObject g in currentLevel.BackgroundMap)
            {
                if (g != null)
                {
                    g.Draw(dc);
                }
            }
            foreach (GameObject g in currentLevel.LevelMap)
            {
                if (g != null)
                {
                    g.Draw(dc);
                }
            }
        }

        public void Update()
        {
            foreach (GameObject g in currentLevel.LevelMap)
            {
                if (g != null)
                {
                    g.Update(currentFPS);    
                }
                
            }
        }

        public void SetupGameWorld()
        {
            gameRunning = false;
            menu = true;
            GameObject[,] levelMap = new GameObject[14, 18]{{null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null},{null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null},{null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null},{null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null},{null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null},{null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null},{null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null},{null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null},{null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null},{null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null},{null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null},{null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null},{null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null},{null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null},};
            GameObject[,] backgroundMap = new GameObject[14, 18] { { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null }, { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null }, { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null }, { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null }, { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null }, { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null }, { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null }, { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null }, { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null }, { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null }, { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null }, { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null }, { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null }, { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null }, };
            
            currentLevel = new Level(levelMap, backgroundMap, 10);
            //Audio.PlayMusic("audio/music.mp3");
        }
    }
}
