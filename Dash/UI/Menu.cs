using System;
using System.Drawing;
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
        private int screenWidth = 864; //width of the screen space
        private Font f = new Font("Arial", 30);  //Font for menu items
        private Font headLine = new Font("Arial", 48); //Font for main headlines
        private Font headLine2 = new Font("Arial", 40); //For for secondary headlines
        private Brush b = new SolidBrush(Color.Black); //Brush for headlines and non selected menu items
        private Brush b2 = new SolidBrush(Color.Red); //Brush for selected menu items

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
            string tekst = "Captain Dash";
            Rectangle rect1 = new Rectangle(0, 0, screenWidth, 90);
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            dc.DrawString(tekst, headLine, b, rect1, stringFormat);

            if (highlightedMenuItem == 1)
            {
                if (gameRunning)
                {
                    tekst = "Resume Game";
                    rect1 = new Rectangle(0, 90, screenWidth, 60);
                    dc.DrawString(tekst, f, b2, rect1, stringFormat);
                }
                else
                {
                    tekst = "New Game";
                    rect1 = new Rectangle(0, 90, screenWidth, 60);
                    dc.DrawString(tekst, f, b2, rect1, stringFormat);
                }
            }
            else
            {
                if (gameRunning)
                {
                    tekst = "Resume Game";
                    rect1 = new Rectangle(0, 90, screenWidth, 60);
                    dc.DrawString(tekst, f, b, rect1, stringFormat);
                }
                else
                {
                    tekst = "New Game";
                    rect1 = new Rectangle(0, 90, screenWidth, 60);
                    dc.DrawString(tekst, f, b, rect1, stringFormat);
                }

            }
            if (highlightedMenuItem == 2)
            {
                tekst = "Options";
                rect1 = new Rectangle(0, 150, screenWidth, 60);
                dc.DrawString(tekst, f, b2, rect1, stringFormat);
            }
            else
            {
                tekst = "Options";
                rect1 = new Rectangle(0, 150, screenWidth, 60);
                dc.DrawString(tekst, f, b, rect1, stringFormat);
            }
            if (highlightedMenuItem == 3)
            {
                tekst = "How to Play";
                rect1 = new Rectangle(0, 210, screenWidth, 60);
                dc.DrawString(tekst, f, b2, rect1, stringFormat);
            }
            else
            {
                tekst = "How to Play";
                rect1 = new Rectangle(0, 210, screenWidth, 60);
                dc.DrawString(tekst, f, b, rect1, stringFormat);
            }
            if (highlightedMenuItem == 4)
            {
                tekst = "Quit";
                rect1 = new Rectangle(0, 270, screenWidth, 60);
                dc.DrawString(tekst, f, b2, rect1, stringFormat);
            }
            else
            {
                tekst = "Quit";
                rect1 = new Rectangle(0, 270, screenWidth, 60);
                dc.DrawString(tekst, f, b, rect1, stringFormat);
            }
        }

        /// <summary>
        /// Method that draws the options menu to the graphics object
        /// </summary>
        private void DrawOptionsMenu()
        {
            string tekst = "Options";
            Rectangle rect1 = new Rectangle(0, 0, screenWidth, 90);
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            dc.DrawString(tekst, headLine, b, rect1, stringFormat);
            rect1 = new Rectangle(0, 90, screenWidth, 60);
            tekst = "Sound";
            dc.DrawString(tekst, headLine2, b, rect1, stringFormat);

            if (highlightedMenuItem == 1)
            {
                tekst = "Master Volume: " + Audio.MasterVolume;
                rect1 = new Rectangle(0, 150, screenWidth, 60);
                dc.DrawString(tekst, f, b2, rect1, stringFormat);
            }
            else
            {
                tekst = "Master Volume: " + Audio.MasterVolume;
                rect1 = new Rectangle(0, 150, screenWidth, 60);
                dc.DrawString(tekst, f, b, rect1, stringFormat);
            }

            if (highlightedMenuItem == 2)
            {
                tekst = "Sound-FX Volume: " + Audio.SoundVolume;
                rect1 = new Rectangle(0, 210, screenWidth, 60);
                dc.DrawString(tekst, f, b2, rect1, stringFormat);
            }
            else
            {
                tekst = "Sound-FX Volume: " + Audio.SoundVolume;
                rect1 = new Rectangle(0, 210, screenWidth, 60);
                dc.DrawString(tekst, f, b, rect1, stringFormat);
            }

            if (highlightedMenuItem == 3)
            {
                tekst = "Music Volume: " + Audio.MusicVolume;
                rect1 = new Rectangle(0, 270, screenWidth, 60);
                dc.DrawString(tekst, f, b2, rect1, stringFormat);
            }
            else
            {
                tekst = "Music Volume: " + Audio.MusicVolume;
                rect1 = new Rectangle(0, 270, screenWidth, 60);
                dc.DrawString(tekst, f, b, rect1, stringFormat);
            }
            if (highlightedMenuItem == 4)
            {
                tekst = "Controls";
                rect1 = new Rectangle(0, 320, screenWidth, 60);
                dc.DrawString(tekst, f, b2, rect1, stringFormat);
            }
            else
            {
                tekst = "Controls";
                rect1 = new Rectangle(0, 320, screenWidth, 60);
                dc.DrawString(tekst, f, b, rect1, stringFormat);
            }
            if (highlightedMenuItem == 5)
            {
                tekst = "Back";
                rect1 = new Rectangle(0, 380, screenWidth, 60);
                dc.DrawString(tekst, f, b2, rect1, stringFormat);
            }
            else
            {
                tekst = "Back";
                rect1 = new Rectangle(0, 380, screenWidth, 60);
                dc.DrawString(tekst, f, b, rect1, stringFormat);
            }
        }

        /// <summary>
        /// Method that draws the Controls menu to the graphics object
        /// </summary>
        private void DrawControlMenu()
        {
            string tekst = "Controls";
            Rectangle rect1 = new Rectangle(0, 0, screenWidth, 90);
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            dc.DrawString(tekst, headLine, b, rect1, stringFormat);
            rect1 = new Rectangle(0, 90, screenWidth, 60);
            tekst = "Movement keys";
            dc.DrawString(tekst, headLine2, b, rect1, stringFormat);

            if (highlightedMenuItem == 1)
            {
                if (selectedMenuItem == 1)
                {
                    tekst = "Up: Enter new key";
                    rect1 = new Rectangle(0, 160, screenWidth, 60);
                    dc.DrawString(tekst, f, b2, rect1, stringFormat);
                }
                else
                {
                    tekst = "Up: " + Config.UpKey;
                    rect1 = new Rectangle(0, 160, screenWidth, 60);
                    dc.DrawString(tekst, f, b2, rect1, stringFormat);
                }

            }
            else
            {
                tekst = "Up: " + Config.UpKey;
                rect1 = new Rectangle(0, 160, screenWidth, 60);
                dc.DrawString(tekst, f, b, rect1, stringFormat);
            }
            if (highlightedMenuItem == 2)
            {
                if (selectedMenuItem == 2)
                {
                    tekst = "Down: Enter new key";
                    rect1 = new Rectangle(0, 220, screenWidth, 60);
                    dc.DrawString(tekst, f, b2, rect1, stringFormat);
                }
                else
                {
                    tekst = "Down: " + Config.DownKey;
                    rect1 = new Rectangle(0, 220, screenWidth, 60);
                    dc.DrawString(tekst, f, b2, rect1, stringFormat);
                }

            }
            else
            {
                tekst = "Down: " + Config.DownKey;
                rect1 = new Rectangle(0, 220, screenWidth, 60);
                dc.DrawString(tekst, f, b, rect1, stringFormat);
            }

            if (highlightedMenuItem == 3)
            {
                if (selectedMenuItem == 3)
                {
                    tekst = "Left: Enter new key";
                    rect1 = new Rectangle(0, 280, screenWidth, 60);
                    dc.DrawString(tekst, f, b2, rect1, stringFormat);
                }
                else
                {
                    tekst = "Left: " + Config.LeftKey;
                    rect1 = new Rectangle(0, 280, screenWidth, 60);
                    dc.DrawString(tekst, f, b2, rect1, stringFormat);
                }
            }
            else
            {
                tekst = "Left: " + Config.LeftKey;
                rect1 = new Rectangle(0, 280, screenWidth, 60);
                dc.DrawString(tekst, f, b, rect1, stringFormat);
            }

            if (highlightedMenuItem == 4)
            {
                if (selectedMenuItem == 4)
                {
                    tekst = "Right: Enter new key";
                    rect1 = new Rectangle(0, 340, screenWidth, 60);
                    dc.DrawString(tekst, f, b2, rect1, stringFormat);
                }
                else
                {
                    tekst = "Right: " + Config.RightKey;
                    rect1 = new Rectangle(0, 340, screenWidth, 60);
                    dc.DrawString(tekst, f, b2, rect1, stringFormat);
                }
            }
            else
            {
                tekst = "Right: " + Config.RightKey;
                rect1 = new Rectangle(0, 340, screenWidth, 60);
                dc.DrawString(tekst, f, b, rect1, stringFormat);
            }

            tekst = "Ship Controls";
            rect1 = new Rectangle(0, 400, screenWidth, 60);
            dc.DrawString(tekst, headLine2, b, rect1, stringFormat);

            if (highlightedMenuItem == 5)
            {
                if (selectedMenuItem == 4)
                {
                    tekst = "Shoot: Enter new key";
                    rect1 = new Rectangle(0, 460, screenWidth, 60);
                    dc.DrawString(tekst, f, b2, rect1, stringFormat);
                }
                else
                {
                    tekst = "Shoot: " + Config.ShootKey;
                    rect1 = new Rectangle(0, 460, screenWidth, 60);
                    dc.DrawString(tekst, f, b2, rect1, stringFormat);
                }
            }
            else
            {
                tekst = "Shoot: " + Config.ShootKey;
                rect1 = new Rectangle(0, 460, screenWidth, 60);
                dc.DrawString(tekst, f, b, rect1, stringFormat);
            }
            if (highlightedMenuItem == 6)
            {
                tekst = "Back";
                rect1 = new Rectangle(0, 520, screenWidth, 60);
                dc.DrawString(tekst, f, b2, rect1, stringFormat);
            }
            else
            {
                tekst = "Back";
                rect1 = new Rectangle(0, 520, screenWidth, 60);
                dc.DrawString(tekst, f, b, rect1, stringFormat);
            }
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
                    max = 3;
                    break;
                case 2:
                    max = 4;
                    break;
                default:
                    max = 5;
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
                                    break;
                                case 2:
                                    selectedMenu = 2;
                                    highlightedMenuItem = 1;
                                    lastClick = DateTime.Now;
                                    break;
                                case 3:
                                    break;
                                case 4:
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
                                    selectedMenuItem = 5;
                                    break;
                                case 6:
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
    }
}