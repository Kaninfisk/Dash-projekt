﻿using System;
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
        private Level currentLevel; // field til nuværende bane
        private Graphics dc;
        public float currentFPS; //field til at indeholde nuværende frames per second
        private BufferedGraphics buffer; //Grafik buffer
        private bool menu; //field som bruges til om menu skal vises eller ej
        private Menu m; //menu objektet
        private DateTime lastFrameStarted; //Datetime field som bruges til at beregne currentFPS
        private bool gameRunning; //field som bruges til at indikere om spiller er startet eller ej
        private double t; //field som bruges til timer funktion i spillet
        public int cLevel; //field som indeholder nuværende bane som int
        public int playerState;
        public int alpha;

        private Keys input;  //field som bruges til at gemme hvilke keys der bliver trykket på

        /// <summary>
        /// Property til keyinput
        /// </summary>
        public Keys Input
        {
            set { input = value; }
        }

        /// <summary>
        ///  Constructor som indstiller skærm buffer og kører metoderne SetupLevels og SetupGameWorld
        /// </summary>
        /// <param name="dc">Grafik objektet fra formen</param>
        /// <param name="displayRectangle">Rektangel som er på størrelse med tegne arealet på formen</param>
        public GameWorld(Graphics dc, Rectangle displayRectangle)
        {
            buffer = BufferedGraphicsManager.Current.Allocate(dc, displayRectangle);
            this.dc = buffer.Graphics;
            cLevel = 1;
            m = new Menu(this.dc);
            SetupGameWorld();


        }

        /// <summary>
        /// Viser menu eller kører gameloop metoderne draw,update
        /// </summary>
        public void GameLoop()
        {
            TimeSpan deltaTime2 = DateTime.Now - lastFrameStarted;
            int milliSeconds = deltaTime2.Milliseconds > 0 ? deltaTime2.Milliseconds : 1;
            currentFPS = 1000 / milliSeconds;
            lastFrameStarted = DateTime.Now;


            if (playerState < 2)
            {
                dc.Clear(Color.White);    
            }
            Font f = new Font("Arial", 12);
            Brush b = new SolidBrush(Color.Black);

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
                    f = new Font("Arial", 36);
                    b = new SolidBrush(Color.Black);
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
        /// Tegner alle gameobjecterne i currentlevel ud til skærmen
        /// </summary>
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


        public void DrawUI()
        {
            Font f = new Font("Arial", 12);
            Brush b = new SolidBrush(Color.Black);
            dc.DrawString(Math.Round(t, 2).ToString().Replace(',', '.'), f, b, 600, 0);
#if DEBUG
            dc.DrawString(currentFPS.ToString(), f, b, 800, 0);
#endif
        }

        public void DrawFade()
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
        /// Kører alle gameobjecterne i currentlevel update funktion
        /// </summary>
        public void Update()
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
        /// Indstiller startvariablerne for gameworld
        /// </summary>
        public void SetupGameWorld()
        {
            dc.Clear(Color.White);
            gameRunning = false;
            menu = true;
            RestartLevel();
            
            //Audio.PlayMusic("audio/music.mp3");
        }

        /// <summary>
        /// Nulstiller nuværende bane
        /// </summary>
        public void RestartLevel()
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
