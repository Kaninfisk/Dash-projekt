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
        private int screenWidth = 864; //width of the screen space
        private Font f;  //Font for menu items
        private Font headLine; //Font for main headlines
        private Font headLine2; //For for secondary headlines
        private Brush b = new SolidBrush(Color.FromArgb(255, 133, 149, 161)); //Brush for headlines and non selected menu items
        private Brush b2 = new SolidBrush(Color.FromArgb(255, 218, 212, 94)); //Brush for selected menu items
        private Brush b3 = new SolidBrush(Color.FromArgb(255,20,12,28));
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
            f = new Font(pf.Families[0], 32);
            headLine = new Font(pf.Families[0], 48);
            headLine2 = new Font(pf.Families[0], 48);
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
            string tekst = "";
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            GraphicsPath p;
            Point pos = new Point(432, 224);

            if (highlightedMenuItem == 1)
            {
                if (gameRunning)
                {
                    p = new GraphicsPath();
                    tekst = "Resume Game";
                    p.AddString(tekst, pf.Families[0] , 0, 70, pos, stringFormat);
                    dc.DrawPath(new Pen(b3, 6), p);
                    dc.FillPath(b2, p);

                }
                else
                {
                    p = new GraphicsPath();
                    tekst = "New Game";
                    p.AddString(tekst, pf.Families[0], 0, 70, pos, stringFormat);
                    dc.DrawPath(new Pen(b3, 6), p);
                    dc.FillPath(b2,p);
                }
            }
            else
            {
                if (gameRunning)
                {
                    p = new GraphicsPath();
                    tekst = "Resume Game";
                    p.AddString(tekst, pf.Families[0], 0, 70, pos, stringFormat);
                    dc.DrawPath(new Pen(b3, 6), p);
                    dc.FillPath(b2, p);
                }
                else
                {
                    p = new GraphicsPath();
                    tekst = "New Game";
                    p.AddString(tekst, pf.Families[0], 0, 70, pos, stringFormat);
                    dc.DrawPath(new Pen(b3, 6), p);
                    dc.FillPath(b, p);
                }

            }
            if (highlightedMenuItem == 2)
            {
                p = new GraphicsPath();
                tekst = "Options";
                pos = new Point(432, 318);
                p.AddString(tekst, pf.Families[0], 0, 70, pos, stringFormat);
                dc.DrawPath(new Pen(b3, 6), p);
                dc.FillPath(b2, p);
            }
            else
            {
                p = new GraphicsPath();
                tekst = "Options";
                pos = new Point(432, 318);
                p.AddString(tekst, pf.Families[0], 0, 70, pos, stringFormat);
                dc.DrawPath(new Pen(b3, 6), p);
                dc.FillPath(b, p);
            }
            if (highlightedMenuItem == 3)
            {
                tekst = "Quit";
                p = new GraphicsPath();
                pos = new Point(432, 417);
                p.AddString(tekst, pf.Families[0], 0, 70, pos, stringFormat);
                dc.DrawPath(new Pen(b3, 6), p);
                dc.FillPath(b2, p);

            }
            else
            {
                tekst = "Quit";
                p = new GraphicsPath();
                pos = new Point(432, 417);
                p.AddString(tekst, pf.Families[0], 0, 70, pos, stringFormat);
                dc.DrawPath(new Pen(b3, 6), p);
                dc.FillPath(b, p);
            }
        }

        /// <summary>
        /// Method that draws the options menu to the graphics object
        /// </summary>
        private void DrawOptionsMenu()
        {

            Point pos = new Point(432, 200);
            GraphicsPath p = new GraphicsPath();
            string tekst = "Options";
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            p = new GraphicsPath();
            p.AddString(tekst, pf.Families[0], 0, 70, pos, stringFormat);
            dc.DrawPath(new Pen(b3, 6), p);
            dc.FillPath(b, p);

            if (highlightedMenuItem == 1)
            {
                p = new GraphicsPath();
                tekst = "Master Volume: " + Audio.MasterVolume;
                pos = new Point(432, 250);
                p.AddString(tekst, pf.Families[0], 0, 43, pos, stringFormat);
                dc.DrawPath(new Pen(b3, 6), p);
                dc.FillPath(b2, p);

            }
            else
            {
                p = new GraphicsPath();
                tekst = "Master Volume: " + Audio.MasterVolume;
                pos = new Point(432, 250);
                p.AddString(tekst, pf.Families[0], 0, 43, pos, stringFormat);
                dc.DrawPath(new Pen(b3, 6), p);
                dc.FillPath(b, p);
            }

            if (highlightedMenuItem == 2)
            {
                p = new GraphicsPath();
                tekst = "Sound-FX Volume: " + Audio.SoundVolume;
                pos = new Point(432, 300);
                p.AddString(tekst, pf.Families[0], 0, 43, pos, stringFormat);
                dc.DrawPath(new Pen(b3, 6), p);
                dc.FillPath(b2, p);
            }
            else
            {
                p = new GraphicsPath();
                tekst = "Sound-FX Volume: " + Audio.SoundVolume;
                pos = new Point(432, 300);
                p.AddString(tekst, pf.Families[0], 0, 43, pos, stringFormat);
                dc.DrawPath(new Pen(b3, 6), p);
                dc.FillPath(b, p);
            }

            if (highlightedMenuItem == 3)
            {
                tekst = "Music Volume: " + Audio.MusicVolume;
                

                p = new GraphicsPath();
                pos = new Point(432, 350);
                p.AddString(tekst, pf.Families[0], 0, 43, pos, stringFormat);
                dc.DrawPath(new Pen(b3, 6), p);
                dc.FillPath(b2, p);
            }
            else
            {
                tekst = "Music Volume: " + Audio.MusicVolume;
                p = new GraphicsPath();
                pos = new Point(432, 350);
                p.AddString(tekst, pf.Families[0], 0, 43, pos, stringFormat);
                dc.DrawPath(new Pen(b3, 6), p);
                dc.FillPath(b, p);
            }
            if (highlightedMenuItem == 4)
            {
                tekst = "Controls";
                p = new GraphicsPath();
                pos = new Point(432, 400);
                p.AddString(tekst, pf.Families[0], 0, 43, pos, stringFormat);
                dc.DrawPath(new Pen(b3, 6), p);
                dc.FillPath(b2, p);
            }
            else
            {
                tekst = "Controls";
                p = new GraphicsPath();
                pos = new Point(432, 400);
                p.AddString(tekst, pf.Families[0], 0, 43, pos, stringFormat);
                dc.DrawPath(new Pen(b3, 6), p);
                dc.FillPath(b, p);
            }
            if (highlightedMenuItem == 5)
            {
                tekst = "Back";
                p = new GraphicsPath();
                pos = new Point(432, 450);
                p.AddString(tekst, pf.Families[0], 0, 43, pos, stringFormat);
                dc.DrawPath(new Pen(b3, 6), p);
                dc.FillPath(b2, p);
            }
            else
            {
                tekst = "Back";
                p = new GraphicsPath();
                pos = new Point(432, 450);
                p.AddString(tekst, pf.Families[0], 0, 43, pos, stringFormat);
                dc.DrawPath(new Pen(b3, 6), p);
                dc.FillPath(b, p);
            }
        }

        /// <summary>
        /// Method that draws the Controls menu to the graphics object
        /// </summary>
        private void DrawControlMenu()
        {
            Point pos = new Point(432, 200);
            GraphicsPath p = new GraphicsPath();
            string tekst = "Controls";
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            p.AddString(tekst, pf.Families[0], 0, 70, pos, stringFormat);
            dc.DrawPath(new Pen(b3, 6), p);
            dc.FillPath(b, p);
            
            if (highlightedMenuItem == 1)
            {
                if (selectedMenuItem == 1)
                {
                    tekst = "Up: Enter new key";
                    pos = new Point(432, 250);
                    p = new GraphicsPath();
                    p.AddString(tekst, pf.Families[0], 0, 43, pos, stringFormat);
                    dc.DrawPath(new Pen(b3, 6), p);
                    dc.FillPath(b2, p);
                }
                else
                {
                    tekst = "Up: " + Config.UpKey;
                    pos = new Point(432, 250);
                    p = new GraphicsPath();
                    p.AddString(tekst, pf.Families[0], 0, 43, pos, stringFormat);
                    dc.DrawPath(new Pen(b3, 6), p);
                    dc.FillPath(b2, p);
                }

            }
            else
            {
                tekst = "Up: " + Config.UpKey;
                pos = new Point(432, 250);
                p = new GraphicsPath();
                p.AddString(tekst, pf.Families[0], 0, 43, pos, stringFormat);
                dc.DrawPath(new Pen(b3, 6), p);
                dc.FillPath(b, p);
            }
            if (highlightedMenuItem == 2)
            {
                if (selectedMenuItem == 2)
                {
                    tekst = "Down: Enter new key";
                    pos = new Point(432, 300);
                    p = new GraphicsPath();
                    p.AddString(tekst, pf.Families[0], 0, 43, pos, stringFormat);
                    dc.DrawPath(new Pen(b3, 6), p);
                    dc.FillPath(b2, p);
                }
                else
                {
                    tekst = "Down: " + Config.DownKey;
                    pos = new Point(432, 300);
                    p = new GraphicsPath();
                    p.AddString(tekst, pf.Families[0], 0, 43, pos, stringFormat);
                    dc.DrawPath(new Pen(b3, 6), p);
                    dc.FillPath(b2, p);
                }

            }
            else
            {
                tekst = "Down: " + Config.DownKey;
                pos = new Point(432, 300);
                p = new GraphicsPath();
                p.AddString(tekst, pf.Families[0], 0, 43, pos, stringFormat);
                dc.DrawPath(new Pen(b3, 6), p);
                dc.FillPath(b, p);
            }

            if (highlightedMenuItem == 3)
            {
                if (selectedMenuItem == 3)
                {
                    tekst = "Left: Enter new key";
                    pos = new Point(432, 350);
                    p = new GraphicsPath();
                    p.AddString(tekst, pf.Families[0], 0, 43, pos, stringFormat);
                    dc.DrawPath(new Pen(b3, 6), p);
                    dc.FillPath(b2, p);
                }
                else
                {
                    tekst = "Left: " + Config.LeftKey;
                    pos = new Point(432, 350);
                    p = new GraphicsPath();
                    p.AddString(tekst, pf.Families[0], 0, 43, pos, stringFormat);
                    dc.DrawPath(new Pen(b3, 6), p);
                    dc.FillPath(b2, p);
                }
            }
            else
            {
                tekst = "Left: " + Config.LeftKey;
                pos = new Point(432, 350);
                p = new GraphicsPath();
                p.AddString(tekst, pf.Families[0], 0, 43, pos, stringFormat);
                dc.DrawPath(new Pen(b3, 6), p);
                dc.FillPath(b, p);
            }

            if (highlightedMenuItem == 4)
            {
                if (selectedMenuItem == 4)
                {
                    tekst = "Right: Enter new key";
                    pos = new Point(432, 400);
                    p = new GraphicsPath();
                    p.AddString(tekst, pf.Families[0], 0, 43, pos, stringFormat);
                    dc.DrawPath(new Pen(b3, 6), p);
                    dc.FillPath(b2, p);
                }
                else
                {
                    tekst = "Right: " + Config.RightKey;
                    pos = new Point(432, 400);
                    p = new GraphicsPath();
                    p.AddString(tekst, pf.Families[0], 0, 43, pos, stringFormat);
                    dc.DrawPath(new Pen(b3, 6), p);
                    dc.FillPath(b2, p);
                }
            }
            else
            {
                tekst = "Right: " + Config.RightKey;
                pos = new Point(432, 400);
                p = new GraphicsPath();
                p.AddString(tekst, pf.Families[0], 0, 43, pos, stringFormat);
                dc.DrawPath(new Pen(b3, 6), p);
                dc.FillPath(b, p);
            }
            
            if (highlightedMenuItem == 5)
            {
                tekst = "Back";
                pos = new Point(432, 450);
                p = new GraphicsPath();
                p.AddString(tekst, pf.Families[0], 0, 43, pos, stringFormat);
                dc.DrawPath(new Pen(b3, 6), p);
                dc.FillPath(b2, p);
            }
            else
            {
                tekst = "Back";
                pos = new Point(432, 450);
                p = new GraphicsPath();
                p.AddString(tekst, pf.Families[0], 0, 43, pos, stringFormat);
                dc.DrawPath(new Pen(b3, 6), p);
                dc.FillPath(b, p);
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
    }
}