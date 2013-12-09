using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Dash
{
    /// <summary>
    /// Class that handles the menu and user input for the menu
    /// </summary>
    class Menu
    {
        private int selectedMenu; //selected menu
        private int highlightedMenuItem;  //highlighted menu item
        private int selectedMenuItem; //selected menu item
        private Graphics dc;  //graphics object to draw on
        private DateTime lastClick; //Datetime that contains time of last click
        private bool gameRunning; // indicates if game has been started or not
        PrivateFontCollection pf = new PrivateFontCollection();

        /// <summary>
        /// Gets or sets LastClick
        /// </summary>
        public DateTime LastClick
        {
            set { lastClick = value; }
            get { return lastClick; }
        }

        /// <summary>
        /// Constructor where menu gets setup
        /// </summary>
        /// <param name="dc">Graphics object that you want to draw to</param>
        public Menu(Graphics dc)
        {
            this.dc = dc;
            selectedMenu = 1;
            highlightedMenuItem = 1;
            pf.AddFontFile("Graphics\\Font.ttf");
        }

        /// <summary>
        /// Method that draws the selected menu to the graphics object
        /// </summary>
        public void DrawMenu()
        {
            switch (selectedMenu)
            {
                case 2:
                    DrawOptionsMenu();
                    break;
                case 3:
                    DrawControlMenu();
                    break;
                default:
                    DrawMainMenu();
                    break;
            }
        }

        /// <summary>
        /// Method that draws the main menu to the graphics object
        /// </summary>
        private void DrawMainMenu()
        {
            if (highlightedMenuItem == 1)
            {
                if (gameRunning)
                {
                    DrawMenuItem("Resume Game", 432, 224, true, 70);
                }
                else
                {
                    DrawMenuItem("New Game", 432, 224, true, 70);
                }
            }
            else
            {
                if (gameRunning)
                {
                    DrawMenuItem("Resume Game", 432, 224, false, 70);
                }
                else
                {
                    DrawMenuItem("New Game", 432, 224, false, 70);
                }

            }
            DrawMenuItem("Options", 432, 318, highlightedMenuItem == 2, 70);
            DrawMenuItem("Quit", 432, 417, highlightedMenuItem == 3, 70);
        }

        /// <summary>
        /// Method that draws the options menu to the graphics object
        /// </summary>
        private void DrawOptionsMenu()
        {
            DrawMenuItem("Options", 432, 200, false, 70);
            DrawMenuItem("Master Volume: " + Audio.MasterVolume, 432, 250, highlightedMenuItem == 1, 43);
            DrawMenuItem("Sound-FX Volume: " + Audio.SoundVolume, 432, 300, highlightedMenuItem == 2, 43);
            DrawMenuItem("Music Volume: " + Audio.MusicVolume, 432, 350, highlightedMenuItem == 3, 43);
            DrawMenuItem("Controls", 432, 400, highlightedMenuItem == 4, 43);
            DrawMenuItem("Back", 432, 450, highlightedMenuItem == 5, 43);
        }

        /// <summary>
        /// Method that draws the Controls menu to the graphics object
        /// </summary>
        private void DrawControlMenu()
        {
            DrawMenuItem("Controls", 432, 200, false, 70);
            
            if (highlightedMenuItem == 1)
            {
                if (selectedMenuItem == 1)
                {
                    DrawMenuItem("Up: Enter new key", 432, 250, true, 43);
                }
                else
                {
                    DrawMenuItem("Up: " + Config.UpKey, 432, 250, true, 43);
                }
            }
            else
            {
                DrawMenuItem("Up: " + Config.UpKey, 432, 250, false, 43);
            }
            if (highlightedMenuItem == 2)
            {
                if (selectedMenuItem == 2)
                {
                    DrawMenuItem("Down: Enter new key", 432, 300, true, 43);
                }
                else
                {
                    DrawMenuItem("Down: " + Config.DownKey, 432, 300, true, 43);
                }

            }
            else
            {
                DrawMenuItem("Down: " + Config.DownKey, 432, 300, false, 43);
            }

            if (highlightedMenuItem == 3)
            {
                if (selectedMenuItem == 3)
                {
                    DrawMenuItem("Left: Enter new key", 432, 350, true, 43);
                }
                else
                {
                    DrawMenuItem("Left: " + Config.LeftKey, 432, 350, true, 43);
                }
            }
            else
            {
                DrawMenuItem("Left: " + Config.LeftKey, 432, 350, false, 43);
            }

            if (highlightedMenuItem == 4)
            {
                if (selectedMenuItem == 4)
                {
                    DrawMenuItem("Right: Enter new key", 432, 400, true, 43);
                }
                else
                {
                    DrawMenuItem("Right: " + Config.RightKey, 432, 400, true, 43);
                }
            }
            else
            {
                DrawMenuItem("Right: " + Config.RightKey, 432, 400, false, 43);
            }

            DrawMenuItem("Back", 432, 450, highlightedMenuItem == 5, 43);
        }

        /// <summary>
        /// Method that handles user input and navigation in the menu
        /// </summary>
        /// <param name="key">Reference variable for keyboard input</param>
        /// <param name="gameRunning">reference for variable that indicates if game has been started or not</param>
        /// <param name="menu">reference variable that indicates if menu is shown or not</param>
        public void Update(ref Keys key, ref bool gameRunning, ref bool menu)
        {
            this.gameRunning = gameRunning;
            int max;
            switch (selectedMenu)
            {
                case 1:
                    max = 2;
                    break;
                case 2:
                    max = 4;
                    break;
                default:
                    max = 4;
                    break;
            }

            if (Keyboard.IsKeyDown(Keys.Up) && highlightedMenuItem >= 2)
            {
                TimeSpan deltaTime = DateTime.Now - LastClick;
                if (deltaTime.TotalMilliseconds > 200)
                {
                    if (selectedMenuItem == 0)
                    {
                        highlightedMenuItem--;
                        lastClick = DateTime.Now;
                    }
                }
            }
            else if (Keyboard.IsKeyDown(Keys.Down) && highlightedMenuItem <= max)
            {
                TimeSpan deltaTime = DateTime.Now - LastClick;
                if (deltaTime.TotalMilliseconds > 200)
                {

                    if (selectedMenuItem == 0)
                    {
                        highlightedMenuItem++;
                        lastClick = DateTime.Now;
                    }
                }

            }
            else if (Keyboard.IsKeyDown(Keys.Enter))
            {
                TimeSpan deltaTime = DateTime.Now - LastClick;
                if (deltaTime.TotalMilliseconds > 200)
                {
                    switch (selectedMenu)
                    {
                        case 1:
                            switch (highlightedMenuItem)
                            {
                                case 1:
                                    gameRunning = true;
                                    menu = false;
                                    lastClick = DateTime.Now;
                                    Audio.PlayMusic("Audio\\soundtrack_Intronitiion_ilikescifi_0.MP3");
                                    break;
                                case 2:
                                    selectedMenu = 2;
                                    highlightedMenuItem = 1;
                                    lastClick = DateTime.Now;
                                    break;
                                case 3:
                                    Application.Exit();
                                    break;
                            }
                            break;
                        case 2:
                            switch (highlightedMenuItem)
                            {
                                case 1:
                                case 2:
                                case 3:
                                    break;
                                case 4:
                                    selectedMenu = 3;
                                    highlightedMenuItem = 1;
                                    lastClick = DateTime.Now;
                                    break;
                                case 5:
                                    selectedMenu = 1;
                                    highlightedMenuItem = 1;
                                    lastClick = DateTime.Now;
                                    Config.UpdateConfig();
                                    break;
                            }
                            break;
                        case 3:
                            switch (highlightedMenuItem)
                            {
                                case 1:
                                    selectedMenuItem = 1;
                                    break;
                                case 2:
                                    selectedMenuItem = 2;
                                    break;
                                case 3:
                                    selectedMenuItem = 3;
                                    break;
                                case 4:
                                    selectedMenuItem = 4;
                                    break;
                                case 5:
                                    selectedMenu = 2;
                                    highlightedMenuItem = 1;
                                    selectedMenuItem = 0;
                                    Config.UpdateConfig();
                                    lastClick = DateTime.Now;
                                    break;
                            }
                            break;
                    }
                }
            }
            else if (Keyboard.IsKeyDown(Keys.Escape))
            {
                TimeSpan deltaTime = DateTime.Now - LastClick;
                if (deltaTime.TotalMilliseconds > 200)
                {

                    if (selectedMenuItem > 0)
                    {
                        selectedMenuItem = 0;
                        lastClick = DateTime.Now;
                    }
                    else if (gameRunning && selectedMenu == 1)
                    {
                        menu = false;
                        lastClick = DateTime.Now;
                    }
                    else if (selectedMenu > 1 && selectedMenuItem == 0)
                    {
                        selectedMenu--;
                        selectedMenuItem = 0;
                        highlightedMenuItem = 1;
                        Config.UpdateConfig();
                        lastClick = DateTime.Now;
                    }
                }
            }

            else if (Keyboard.IsKeyDown(Keys.Left) && selectedMenu == 2 && highlightedMenuItem < 4)
            {
                switch (highlightedMenuItem)
                {
                    case 1:
                        if (Audio.MasterVolume > 0)
                        {
                            Audio.MasterVolume--;
                        }
                        break;
                    case 2:
                        if (Audio.SoundVolume > 0)
                        {
                            Audio.SoundVolume--;
                        }
                        break;
                    case 3:
                        if (Audio.MusicVolume > 0)
                        {
                            Audio.MusicVolume--;
                        }
                        break;
                }
            }
            else if (Keyboard.IsKeyDown(Keys.Right) && selectedMenu == 2 && highlightedMenuItem < 4)
            {
                switch (highlightedMenuItem)
                {
                    case 1:
                        if (Audio.MasterVolume < 100)
                        {
                            Audio.MasterVolume++;
                        }
                        break;
                    case 2:
                        if (Audio.SoundVolume < 100)
                        {
                            Audio.SoundVolume++;
                        }
                        break;
                    case 3:
                        if (Audio.MusicVolume < 100)
                        {
                            Audio.MusicVolume++;
                        }
                        break;
                }
            }

            switch (selectedMenuItem)
            {
                case 1:
                    if (key != Keys.Enter && key != Config.DownKey && key != Config.LeftKey && key != Config.RightKey && key != Config.ShootKey && key != Keys.Menu && key != Keys.Escape)
                    {
                        Config.UpKey = key;
                        selectedMenuItem = 0;
                    }
                    break;
                case 2:
                    if (key != Keys.Enter && key != Config.UpKey && key != Config.LeftKey && key != Config.RightKey && key != Config.ShootKey && key != Keys.Menu && key != Keys.Escape)
                    {
                        Config.DownKey = key;
                        selectedMenuItem = 0;
                    }
                    break;
                case 3:
                    if (key != Keys.Enter && key != Config.DownKey && key != Config.UpKey && key != Config.RightKey && key != Config.ShootKey && key != Keys.Menu && key != Keys.Escape)
                    {
                        Config.LeftKey = key;
                        selectedMenuItem = 0;
                    }
                    break;
                case 4:
                    if (key != Keys.Enter && key != Config.DownKey && key != Config.LeftKey && key != Config.UpKey && key != Config.ShootKey && key != Keys.Menu && key != Keys.Escape)
                    {
                        Config.RightKey = key;
                        selectedMenuItem = 0;
                    }
                    break;
                case 5:
                    if (key != Keys.Enter && key != Config.DownKey && key != Config.LeftKey && key != Config.RightKey && key != Config.UpKey && key != Keys.Menu && key != Keys.Escape)
                    {
                        Config.ShootKey = key;
                        selectedMenuItem = 0;
                    }
                    break;
            }
        }

        private void DrawMenuItem(string tekst, int x, int y, bool highlighted,float size)
        {
            Brush b = new SolidBrush(Color.FromArgb(255, 133, 149, 161)); //Brush for headlines and non selected menu items
            Brush b2 = new SolidBrush(Color.FromArgb(255, 218, 212, 94)); //Brush for selected menu items
            Brush b3 = new SolidBrush(Color.FromArgb(255,20,12,28));
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            GraphicsPath p = new GraphicsPath();
            p.AddString(tekst, pf.Families[0], 0, size, new Point(x,y), stringFormat);
            dc.DrawPath(new Pen(b3, 6), p);
            if (highlighted)
            {
                dc.FillPath(b2, p);    
            }
            else
            {
                dc.FillPath(b, p);
            }
            
            
        }
    }
}