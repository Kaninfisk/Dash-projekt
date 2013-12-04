using System;
using System.Drawing;
using System.Windows.Forms;

namespace Dash
{
    /// <summary>
    /// Class for gameworld
    /// </summary>
    class GameWorld
    {
        private Level currentLevel; // contains current level
        private Graphics dc; // graphics object to draw to
        private float currentFPS; //current fps
        private BufferedGraphics buffer; //graphics buffer
        private bool menu; // indicates if menu is to be shown
        private Menu m; // menu object
        private DateTime lastFrameStarted; // DateTime which is used to calculate currentFPS
        private bool gameRunning; // indicates if game has been started or not
        private double t; // used for the level timer
        private int cLevel; // indicates which level to load
        private int playerState; //indicates if player is alive or dead
        private int alpha; //alpha value for "death animation"
        private Keys input;  // used for key input

        /// <summary>
        /// Sets input
        /// </summary>
        public Keys Input
        {
            set { input = value; }
        }

        /// <summary>
        /// Constructor that sets up graphics buffer and gameworld
        /// </summary>
        /// <param name="dc">Graphics object from the form</param>
        /// <param name="displayRectangle">Rectangle that is the size of the graphics object</param>
        public GameWorld(Graphics dc, Rectangle displayRectangle)
        {
            buffer = BufferedGraphicsManager.Current.Allocate(dc, displayRectangle);
            this.dc = buffer.Graphics;
            cLevel = 1;
            m = new Menu(this.dc);
            SetupGameWorld();
        }

        /// <summary>
        /// GameLoop that runs game and menu
        /// </summary>
        public void GameLoop()
        {
            TimeSpan deltaTime2 = DateTime.Now - lastFrameStarted;
            int milliSeconds = deltaTime2.Milliseconds > 0 ? deltaTime2.Milliseconds : 1;
            currentFPS = (float)1000 / milliSeconds;
            lastFrameStarted = DateTime.Now;


            if (playerState < 2)
            {
                dc.Clear(Color.White);    
            }

            if (!menu && gameRunning)
            {
                if (playerState == 1)
                {
                    RestartLevel();
                }
                else if (playerState == 2)
                {
                    DrawFade();
                }
                else if (t > 0)
                {
                    t -= deltaTime2.TotalSeconds;
                    Update();
                    Draw();
                    DrawUI();
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
                else
                {
                    Font f = new Font("Arial", 36);
                    Brush b = new SolidBrush(Color.Black);
                    string tekst = "Time ran out press enter to retry or escape to exit";
                    int screenwidth = 864;
                    Rectangle rect1 = new Rectangle(0, 0, screenwidth, 150);
                    StringFormat stringFormat = new StringFormat();
                    stringFormat.Alignment = StringAlignment.Center;
                    stringFormat.LineAlignment = StringAlignment.Center;
                    dc.DrawString(tekst, f, b, rect1, stringFormat);
                    if (Keyboard.IsKeyDown(Keys.Enter))
                    {
                        RestartLevel();
                    }
                    else if (Keyboard.IsKeyDown(Keys.Escape))
                    {
                        RestartLevel();
                        menu = true;
                        gameRunning = false;
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

        /// <summary>
        /// Method that draws all objects to screen
        /// </summary>
        private void Draw()
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


        /// <summary>
        /// Method that draws UI to screen
        /// </summary>
        private void DrawUI()
        {
            Font f = new Font("Arial", 12);
            Brush b = new SolidBrush(Color.Black);
            dc.DrawString(Math.Round(t, 2).ToString().Replace(',', '.'), f, b, 600, 0);
#if DEBUG
            dc.DrawString(currentFPS.ToString(), f, b, 800, 0);
#endif
        }

        /// <summary>
        /// Method that draws "death animation"
        /// </summary>
        private void DrawFade()
        {
            
            Brush brush = new SolidBrush(Color.FromArgb(alpha, 0, 0, 0));
            dc.FillRectangle(brush,0,0,864,672);
            alpha += 2;
            if (alpha > 100)
            {
                RestartLevel();
            }
        }

        /// <summary>
        /// Method that runs update function on all objects in currentLevels levelmap
        /// </summary>
        private void Update()
        {
            foreach (GameObject g in currentLevel.LevelMap)
            {
                if (g != null)
                {
                    g.Update(currentFPS, ref currentLevel.levelMap,ref playerState);
                }
            }
        }

        /// <summary>
        /// Sets up start values for gameworld
        /// </summary>
        private void SetupGameWorld()
        {
            dc.Clear(Color.White);
            gameRunning = false;
            menu = true;
            RestartLevel();
            
            //Audio.PlayMusic("audio/music.mp3");
        }

        /// <summary>
        /// Resets current level
        /// </summary>
        private void RestartLevel()
        {
            if (playerState == 1 && cLevel != 20)
            {
                cLevel++;
            }

            currentLevel = new Level(cLevel);
            t = currentLevel.Time;
            alpha = 0;
            playerState = 0;
        }
    }
}
