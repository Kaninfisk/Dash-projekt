using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
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
        private float cutScene; //used to see if cutscenes should play and for how long
        private bool cutScenePlayed; //used to see if the cutscenes have played for current level

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


            if (playerState < 2) //if player is not dead clear screen
            {
                dc.Clear(Color.Gray);
            }

            if (!menu && gameRunning) //if menu is false and gameRunning is true run game
            {
                if (playerState == 1)   //if player got thru level
                {
                    RestartLevel();
                }
                else if (playerState == 2) //if player died or time ran out  
                {
                    DrawFade();
                }
                else if (cutScene > 0)  //if cutscene should be played
                {
                    PlayCutScene();
                }
                else if (t > 0) //if timer is larger than 0 run the game
                {
                    t -= deltaTime2.TotalSeconds;
                    Update();
                    Draw();
                    DrawUI();
                    if (Keyboard.IsKeyDown(Keys.Escape))  //if you hit escape during game menu will be shown
                    {
                        TimeSpan deltaTime = DateTime.Now - m.LastClick;
                        if (deltaTime.TotalMilliseconds > 200)
                        {
                            menu = true;
                            m.LastClick = DateTime.Now;
                        }
                    }
                }
                else  //Shows time ran out screen
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
                    if (Keyboard.IsKeyDown(Keys.Enter))  //if you hit enter level restarts
                    {
                        RestartLevel();
                    }
                    else if (Keyboard.IsKeyDown(Keys.Escape))  //if you escape game ends and you go back to main menu
                    {
                        SetupGameWorld();
                    }
                }
            }
            else //show menu if game isnt running or menu = true
            {
                dc.DrawImage(Image.FromFile("Graphics/mainmenu.gif"), 0, 0, 864, 672);
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
            foreach (GameObject g in currentLevel.BackgroundMap)  //loops thru backgroundmap and draws it
            {
                if (g != null)
                {
                    g.Draw(dc);
                }
            }
            foreach (GameObject g in currentLevel.LevelMap)  //loops thru foregroundmap and draws it
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
            Brush b = new SolidBrush(Color.FromArgb(255, 133, 149, 161));
            Brush b3 = new SolidBrush(Color.FromArgb(255,20,12,28));
            PrivateFontCollection pf = new PrivateFontCollection();

            Point pos = new Point(800, 30);
            GraphicsPath p = new GraphicsPath();
            string tekst = (Math.Round(t, 0).ToString());
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            pf.AddFontFile("Graphics\\Font.ttf");
            p.AddString(tekst, pf.Families[0], 0, 32, pos, stringFormat);
            dc.DrawPath(new Pen(b3, 6), p);
            dc.FillPath(b, p);
        }

        /// <summary>
        /// Method that draws "death animation"
        /// </summary>
        private void DrawFade()
        {
            Brush brush = new SolidBrush(Color.FromArgb(alpha, 0, 0, 0));
            dc.FillRectangle(brush, 0, 0, 864, 672);
            alpha += (int)(25 * 1 / currentFPS);
            if (alpha > 100) //if alpha is higher than 100 restart current level
            {
                RestartLevel();
            }
        }

        /// <summary>
        /// Method that runs update function on all objects in currentLevels levelmap
        /// </summary>
        private void Update()
        {
            foreach (GameObject g in currentLevel.LevelMap) //runs update for all objects in foregroundmap
            {
                if (g != null)
                {
                    g.Update(currentFPS, ref currentLevel.LevelMap, ref playerState);
                }
            }
        }

        /// <summary>
        /// Sets up start values for gameworld
        /// </summary>
        private void SetupGameWorld()
        {

            gameRunning = false;
            menu = true;
            cutScenePlayed = false;
            cLevel = 1;
            RestartLevel();
            Audio.StopAllSounds();
            Audio.PlayMusic("audio/Intro.mp3");
        }

        /// <summary>
        /// Resets current level
        /// </summary>
        private void RestartLevel()
        {
            if (playerState == 1) //if player finished current level and currentlevel is not 20 save time in log and go to next level
            {
                WriteLog("lvltimes.txt", "Level: " + cLevel + " Tid: " + Math.Round(currentLevel.Time - t, 2) + Environment.NewLine);
                cLevel++;
                cutScenePlayed = false;
            }

            if ((cLevel == 1 || cLevel == 6 || cLevel == 11 || cLevel == 16 || cLevel == 21) && !cutScenePlayed) //if thre is cutscene for the currentlevel enable cutscenes and set cutscene played to true so it only plays once per level
            {
                cutScene = 1;
                cutScenePlayed = true;
            }

            playerState = 0;
            currentLevel = new Level(cLevel);
            t = currentLevel.Time;
            alpha = 0;
        }

        /// <summary>
        /// Method to play cutscenes
        /// </summary>
        private void PlayCutScene()
        {
            if (cLevel == 1) //if current level == 1 play this cutscene
            {
                dc.DrawImage(Image.FromFile("Graphics/scene1.gif"), 0, 0, 864, 672);
            }
            else if (cLevel == 6) //if current level == 6 play this cutscene
            {
                dc.DrawImage(Image.FromFile("Graphics/scene2.gif"), 0, 0, 864, 672);
            }
            else if (cLevel == 11) //if current level == 11 play this cutscene
            {
                dc.DrawImage(Image.FromFile("Graphics/scene3.gif"), 0, 0, 864, 672);
            }
            else if (cLevel == 16) //if current level == 16 play this cutscene
            {
                dc.DrawImage(Image.FromFile("Graphics/scene4.gif"), 0, 0, 864, 672);
            }
            else if (cLevel == 21)
            {
                dc.DrawImage(Image.FromFile("Graphics/scene5.gif"), 0, 0, 864, 672);
            }

            Brush b = new SolidBrush(Color.FromArgb(255, 133, 149, 161));
            Brush b3 = new SolidBrush(Color.FromArgb(255, 20, 12, 28));
            PrivateFontCollection pf = new PrivateFontCollection();
            Point pos = new Point(432, 590);
            GraphicsPath p = new GraphicsPath();
            string tekst = "Press space to continue";
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            pf.AddFontFile("Graphics\\Font.ttf");
            p.AddString(tekst, pf.Families[0], 0, 32, pos, stringFormat);
            dc.DrawPath(new Pen(b3, 6), p);
            dc.FillPath(b, p);


            if (Keyboard.IsKeyDown(Keys.Space))
            {
                cutScene = 0;
            }

            if (cutScene == 0 && cLevel == 21)
            {
                SetupGameWorld();
            }
            
        }

        /// <summary>
        /// Method to write to a log file
        /// </summary>
        /// <param name="path">File path to write to</param>
        /// <param name="tekstline">Line of tekst to add</param>
        /// <returns>Error if write failed</returns>
        private string WriteLog(string path, string tekstline)
        {
            try
            {
                if (File.Exists(path)) //check if file exists if it does read contents then write it to tekstfile and add a new line
                {
                    StreamReader sr = new StreamReader(path);
                    string tekst = sr.ReadToEnd();
                    sr.Close();
                    StreamWriter sw = new StreamWriter(path);
                    sw.Write(tekst);
                    sw.WriteLine(tekstline);
                    sw.Close();
                }
                else //if file doesnt exist create it and write tekstline to it
                {
                    StreamWriter sw = File.CreateText(path);
                    sw.Close();
                    sw = new StreamWriter(path);
                    sw.WriteLine(tekstline);
                    sw.Close();
                }
                return "Linie skrevet i logfilen";
            }
            catch (Exception ex)
            {
                return "Der opstod en fejl: " + ex.Message;
            }
        }
    }
}
