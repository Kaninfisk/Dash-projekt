using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dash
{
    /// <summary>
    /// Klasse som håndterer menu og bruger indput hertil
    /// </summary>
    class Menu : UI
    {
        private int selectedMenu; //field som indeholder nuværende valgte menu
        private int highlightedMenuItem;  //field som indeholder nuværende highligtede menu punkt
        private int selectedMenuItem; //field som indeholder nuværende valgte menu punkt
        private Graphics dc;  //field som indeholder bufferen fra gameworld
        private DateTime lastClick; //field som indeholder tidspunkt for sidste tryk på en tast
        private bool gameRunning; //field som indeholder om spillet er startet eller ej
        int screenwidth = 864;

        /// <summary>
        /// Property til at sætte og hente tidspunkt for sidste tryk på en tast
        /// </summary>
        public DateTime LastClick
        {
            set { lastClick = value; }
            get { return lastClick; }
        }


        private Font f = new Font("Arial", 30);  //Font til menupunkter
        private Font headLine = new Font("Arial", 48); //Font til overskrifter
        private Font headLine2 = new Font("Arial", 40); //Font til under overskrifter
        private Brush b = new SolidBrush(Color.Black); //brush til ikke valgte menupunkter og overskrifter
        private Brush b2 = new SolidBrush(Color.Red); //brush til valgte menupunkter

        /// <summary>
        /// Konstruktor hvor menu bliver sat op og  grafik objektet bliver initialiseret.
        /// </summary>
        /// <param name="dc">Grafik objekt som skal tegnes ud til</param>
        public Menu(Graphics dc)
        {
            this.dc = dc;
            selectedMenu = 1;
            highlightedMenuItem = 1;
        }

        /// <summary>
        /// Metode som tegner den valgte menu ud til skærmen
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
        /// Metode som tegner hoved menuen ud til skærmen
        /// </summary>
        public void DrawMainMenu()
        {
            string tekst = "Captain Dash";
            Rectangle rect1 = new Rectangle(0, 0, screenwidth, 90);
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            dc.DrawString(tekst, headLine, b, rect1, stringFormat);

            if (highlightedMenuItem == 1)
            {
                if (gameRunning)
                {
                    tekst = "Resume Game";
                    rect1 = new Rectangle(0, 90, screenwidth, 60);
                    dc.DrawString(tekst, f, b2, rect1, stringFormat);
                }
                else
                {
                    tekst = "New Game";
                    rect1 = new Rectangle(0, 90, screenwidth, 60);
                    dc.DrawString(tekst, f, b2, rect1, stringFormat);
                }
            }
            else
            {
                if (gameRunning)
                {
                    tekst = "Resume Game";
                    rect1 = new Rectangle(0, 90, screenwidth, 60);
                    dc.DrawString(tekst, f, b, rect1, stringFormat);
                }
                else
                {
                    tekst = "New Game";
                    rect1 = new Rectangle(0, 90, screenwidth, 60);
                    dc.DrawString(tekst, f, b, rect1, stringFormat);
                }

            }
            if (highlightedMenuItem == 2)
            {
                tekst = "Options";
                rect1 = new Rectangle(0, 150, screenwidth, 60);
                dc.DrawString(tekst, f, b2, rect1, stringFormat);
            }
            else
            {
                tekst = "Options";
                rect1 = new Rectangle(0, 150, screenwidth, 60);
                dc.DrawString(tekst, f, b, rect1, stringFormat);
            }
            if (highlightedMenuItem == 3)
            {
                tekst = "How to Play";
                rect1 = new Rectangle(0, 210, screenwidth, 60);
                dc.DrawString(tekst, f, b2, rect1, stringFormat);
            }
            else
            {
                tekst = "How to Play";
                rect1 = new Rectangle(0, 210, screenwidth, 60);
                dc.DrawString(tekst, f, b, rect1, stringFormat);
            }
            if (highlightedMenuItem == 4)
            {
                tekst = "Quit";
                rect1 = new Rectangle(0, 270, screenwidth, 60);
                dc.DrawString(tekst, f, b2, rect1, stringFormat);
            }
            else
            {
                tekst = "Quit";
                rect1 = new Rectangle(0, 270, screenwidth, 60);
                dc.DrawString(tekst, f, b, rect1, stringFormat);
            }
        }

        /// <summary>
        /// Metode som tegner Options menuen ud til skærmen
        /// </summary>
        public void DrawOptionsMenu()
        {
            string tekst = "Options";
            Rectangle rect1 = new Rectangle(0, 0, screenwidth, 90);
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            dc.DrawString(tekst, headLine, b, rect1, stringFormat);
            rect1 = new Rectangle(0,90,screenwidth, 60);
            tekst = "Sound";
            dc.DrawString(tekst, headLine2, b, rect1, stringFormat);

            if (highlightedMenuItem == 1)
            {
                tekst = "Master Volume: " + Audio.MasterVolume;
                rect1 = new Rectangle(0, 150, screenwidth, 60);
                dc.DrawString(tekst, f, b2, rect1, stringFormat);
            }
            else
            {
                tekst = "Master Volume: " + Audio.MasterVolume;
                rect1 = new Rectangle(0, 150, screenwidth, 60);
                dc.DrawString(tekst, f, b, rect1, stringFormat);
            }

            if (highlightedMenuItem == 2)
            {
                tekst = "Sound-FX Volume: " + Audio.SoundVolume;
                rect1 = new Rectangle(0, 210, screenwidth, 60);
                dc.DrawString(tekst, f, b2, rect1, stringFormat);
            }
            else
            {
                tekst = "Sound-FX Volume: " + Audio.SoundVolume;
                rect1 = new Rectangle(0, 210, screenwidth, 60);
                dc.DrawString(tekst, f, b, rect1, stringFormat);
            }

            if (highlightedMenuItem == 3)
            {
                tekst = "Music Volume: " + Audio.MusicVolume;
                rect1 = new Rectangle(0, 270, screenwidth, 60);
                dc.DrawString(tekst, f, b2, rect1, stringFormat);
            }
            else
            {
                tekst = "Music Volume: " + Audio.MusicVolume;
                rect1 = new Rectangle(0, 270, screenwidth, 60);
                dc.DrawString(tekst, f, b, rect1, stringFormat);
            }
            if (highlightedMenuItem == 4)
            {
                tekst = "Controls";
                rect1 = new Rectangle(0, 320, screenwidth, 60);
                dc.DrawString(tekst, f, b2, rect1, stringFormat);
            }
            else
            {
                tekst = "Controls";
                rect1 = new Rectangle(0, 320, screenwidth, 60);
                dc.DrawString(tekst, f, b, rect1, stringFormat);
            }
            if (highlightedMenuItem == 5)
            {
                tekst = "Back";
                rect1 = new Rectangle(0, 380, screenwidth, 60);
                dc.DrawString(tekst, f, b2, rect1, stringFormat);
            }
            else
            {
                tekst = "Back";
                rect1 = new Rectangle(0, 380, screenwidth, 60);
                dc.DrawString(tekst, f, b, rect1, stringFormat);
            }
        }

        /// <summary>
        /// Metode som tegner Controls menuen ud til skærmen
        /// </summary>
        public void DrawControlMenu()
        {
            string tekst = "Controls";
            Rectangle rect1 = new Rectangle(0, 0, screenwidth, 90);
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            dc.DrawString(tekst, headLine, b, rect1, stringFormat);
            rect1 = new Rectangle(0,90,screenwidth,60);
            tekst = "Movement keys";
            dc.DrawString(tekst, headLine2, b, rect1, stringFormat);
            
            if (highlightedMenuItem == 1)
            {
                if (selectedMenuItem == 1)
                {
                    tekst = "Up: Enter new key";
                    rect1 = new Rectangle(0, 160, screenwidth, 60);
                    dc.DrawString(tekst, f, b2, rect1, stringFormat);
                }
                else
                {
                    tekst = "Up: " + Config.UpKey;
                    rect1 = new Rectangle(0, 160, screenwidth, 60);
                    dc.DrawString(tekst, f, b2, rect1, stringFormat);
                }

            }
            else
            {
                tekst = "Up: " + Config.UpKey;
                rect1 = new Rectangle(0, 160, screenwidth, 60);
                dc.DrawString(tekst, f, b, rect1, stringFormat);
            }
            if (highlightedMenuItem == 2)
            {
                if (selectedMenuItem == 2)
                {
                    tekst = "Down: Enter new key";
                    rect1 = new Rectangle(0, 220, screenwidth, 60);
                    dc.DrawString(tekst, f, b2, rect1, stringFormat);
                }
                else
                {
                    tekst = "Down: " + Config.DownKey;
                    rect1 = new Rectangle(0, 220, screenwidth, 60);
                    dc.DrawString(tekst, f, b2, rect1, stringFormat);
                }

            }
            else
            {
                tekst = "Down: " + Config.DownKey;
                rect1 = new Rectangle(0, 220, screenwidth, 60);
                dc.DrawString(tekst, f, b, rect1, stringFormat);
            }

            if (highlightedMenuItem == 3)
            {
                if (selectedMenuItem == 3)
                {
                    tekst = "Left: Enter new key";
                    rect1 = new Rectangle(0, 280, screenwidth, 60);
                    dc.DrawString(tekst, f, b2, rect1, stringFormat);
                }
                else
                {
                    tekst = "Left: " + Config.LeftKey;
                    rect1 = new Rectangle(0, 280, screenwidth, 60);
                    dc.DrawString(tekst, f, b2, rect1, stringFormat);
                }
            }
            else
            {
                tekst = "Left: " + Config.LeftKey;
                rect1 = new Rectangle(0, 280, screenwidth, 60);
                dc.DrawString(tekst, f, b, rect1, stringFormat);
            }

            if (highlightedMenuItem == 4)
            {
                if (selectedMenuItem == 4)
                {
                    tekst = "Right: Enter new key";
                    rect1 = new Rectangle(0, 340, screenwidth, 60);
                    dc.DrawString(tekst, f, b2, rect1, stringFormat);
                }
                else
                {
                    tekst = "Right: " + Config.RightKey;
                    rect1 = new Rectangle(0, 340, screenwidth, 60);
                    dc.DrawString(tekst, f, b2, rect1, stringFormat);
                }
            }
            else
            {
                tekst = "Right: " + Config.RightKey;
                rect1 = new Rectangle(0, 340, screenwidth, 60);
                dc.DrawString(tekst, f, b, rect1, stringFormat);
            }

            tekst = "Ship Controls";
            rect1 = new Rectangle(0, 400, screenwidth, 60);
            dc.DrawString(tekst, headLine2, b, rect1, stringFormat);
            
            if (highlightedMenuItem == 5)
            {
                if (selectedMenuItem == 4)
                {
                    tekst = "Shoot: Enter new key";
                    rect1 = new Rectangle(0, 460, screenwidth, 60);
                    dc.DrawString(tekst, f, b2, rect1, stringFormat);
                }
                else
                {
                    tekst = "Shoot: " + Config.ShootKey;
                    rect1 = new Rectangle(0, 460, screenwidth, 60);
                    dc.DrawString(tekst, f, b2, rect1, stringFormat);
                }
            }
            else
            {
                tekst = "Shoot: " + Config.ShootKey;
                rect1 = new Rectangle(0, 460, screenwidth, 60);
                dc.DrawString(tekst, f, b, rect1, stringFormat);
            }
            if (highlightedMenuItem == 6)
            {
                tekst = "Back";
                rect1 = new Rectangle(0, 520, screenwidth, 60);
                dc.DrawString(tekst, f, b2, rect1, stringFormat);
            }
            else
            {
                tekst = "Back";
                rect1 = new Rectangle(0, 520, screenwidth, 60);
                dc.DrawString(tekst, f, b, rect1, stringFormat);
            }
        }

        /// <summary>
        /// Metode som håndterer bruger input og navigation i menuen
        /// </summary>
        /// <param name="key">Reference variabel som indeholder keyboard input</param>
        /// <param name="gameRunning">reference variabel som bestemmer om spillet er startet eller ej</param>
        /// <param name="menu">reference variabel som bestemmer om menuen bliver vist eller ej</param>
        public void Update(ref Keys key, ref bool gameRunning, ref bool menu)
        {
            this.gameRunning = gameRunning;
            int max;
            if (selectedMenu == 1)
            {
                max = 3;
            }
            else if (selectedMenu == 2)
            {
                max = 4;
            }
            else
            {
                max = 5;
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
                            //Audio.PlaySoundFX("audio/laser.wav");
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
                            //Audio.PlaySoundFX("audio/laser.wav");
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