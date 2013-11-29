using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dash
{
    class Menu : UI
    {
        private int selectedMenu;
        private int highlightedMenuItem;
        private int selectedMenuItem;
        private Graphics dc;
        private DateTime lastClick;
        public DateTime LastClick
        {
            set { lastClick = value; }
            get { return lastClick; }
        }


        Font f = new Font("Arial", 36);
        Font headLine = new Font("Arial", 72);
        Font headLine2 = new Font("Arial", 48);
        Brush b = new SolidBrush(Color.Black);
        Brush b2 = new SolidBrush(Color.Red);

        public Menu(Graphics dc)
        {
            this.dc = dc;
            selectedMenu = 1;
            highlightedMenuItem = 1;
        }
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

        public void DrawMainMenu()
        {
            if (highlightedMenuItem == 1)
            {
                dc.DrawString("New Game", f, b2, 0, 0);
            }
            else
            {
                dc.DrawString("New Game", f, b, 0, 0);
            }
            if (highlightedMenuItem == 2)
            {
                dc.DrawString("Options", f, b2, 0, 50);
            }
            else
            {
                dc.DrawString("Options", f, b, 0, 50);
            }
            if (highlightedMenuItem == 3)
            {
                dc.DrawString("How to Play", f, b2, 0, 100);
            }
            else
            {
                dc.DrawString("How to Play", f, b, 0, 100);
            }
            if (highlightedMenuItem == 4)
            {
                dc.DrawString("Quit", f, b2, 0, 150);
            }
            else
            {
                dc.DrawString("Quit", f, b, 0, 150);
            }
        }

        public void DrawOptionsMenu()
        {
            dc.DrawString("Options", headLine, b, 400, 0);
            dc.DrawString("Sound", headLine2, b, 500, 200);
            if (highlightedMenuItem == 1)
            {
                dc.DrawString("Master Volume: " + Audio.MasterVolume, f, b2, 600, 300);
            }
            else
            {
                dc.DrawString("Master Volume: " + Audio.MasterVolume, f, b, 600, 300);
            }

            if (highlightedMenuItem == 2)
            {
                dc.DrawString("Sound-FX Volume: " + Audio.SoundVolume, f, b2, 600, 400);
            }
            else
            {
                dc.DrawString("Sound-FX Volume: " + Audio.SoundVolume, f, b, 600, 400);
            }

            if (highlightedMenuItem == 3)
            {
                dc.DrawString("Music Volume: " + Audio.MusicVolume, f, b2, 600, 500);
            }
            else
            {
                dc.DrawString("Music Volume: " + Audio.MusicVolume, f, b, 600, 500);
            }
            if (highlightedMenuItem == 4)
            {
                dc.DrawString("Controls", f, b2, 600, 600);
            }
            else
            {
                dc.DrawString("Controls", f, b, 600, 600);
            }
            if (highlightedMenuItem == 5)
            {
                dc.DrawString("Back", f, b2, 600, 700);
            }
            else
            {
                dc.DrawString("Back", f, b, 600, 700);
            }
        }

        public void DrawControlMenu()
        {
            dc.DrawString("Controls", headLine, b, 400, 0);
            dc.DrawString("Movement keys", headLine2, b, 500, 200);
            if (highlightedMenuItem == 1)
            {
                if (selectedMenuItem == 1)
                {
                    dc.DrawString("Up: Enter new key", f, b2, 600, 300);
                }
                else
                {
                    dc.DrawString("Up: " + Config.UpKey, f, b2, 600, 300);
                }
                
            }
            else
            {
                dc.DrawString("Up: " + Config.UpKey, f, b, 600, 300);
            }
            if (highlightedMenuItem == 2)
            {
                if (selectedMenuItem == 2)
                {
                    dc.DrawString("Down: Enter new key", f, b2, 600, 400);
                }
                else
                {
                    dc.DrawString("Down: " + Config.DownKey, f, b2, 600, 400);    
                }
                
            }
            else
            {
                dc.DrawString("Down: " + Config.DownKey, f, b, 600, 400);
            }

            if (highlightedMenuItem == 3)
            {
                if (selectedMenuItem == 3)
                {
                    dc.DrawString("Left: Enter new key", f, b2, 600, 500);
                }
                else
                {
                    dc.DrawString("Left: " + Config.LeftKey, f, b2, 600, 500);
                }
            }
            else
            {
                dc.DrawString("Left: " + Config.LeftKey, f, b, 600, 500);
            }

            if (highlightedMenuItem == 4)
            {
                if (selectedMenuItem == 4)
                {
                    dc.DrawString("Right: Enter new key", f, b2, 600, 600);
                }
                else
                {
                    dc.DrawString("Right: " + Config.RightKey, f, b2, 600, 600);
                }
            }
            else
            {
                dc.DrawString("Right: " + Config.RightKey, f, b, 600, 600);
            }


            dc.DrawString("Ship Controls", headLine2, b, 500, 700);

            if (highlightedMenuItem == 5)
            {
                if (selectedMenuItem == 4)
                {
                    dc.DrawString("Shoot: Enter new key", f, b2, 600, 800);
                }
                else
                {
                    dc.DrawString("Shoot: " + Config.ShootKey, f, b2, 600, 800);
                }
            }
            else
            {
                dc.DrawString("Shoot: " + Config.ShootKey, f, b, 600, 800);
            }
            if (highlightedMenuItem == 6)
            {
                dc.DrawString("Back", f, b2, 600, 900);
            }
            else
            {
                dc.DrawString("Back", f, b, 600, 900);
            }
        }

        public void Update(ref Keys key)
        {
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
                if (selectedMenuItem == 0)
                {
                    highlightedMenuItem--;
                    lastClick = DateTime.Now;    
                }
            }
            else if (Keyboard.IsKeyDown(Keys.Down) && highlightedMenuItem <= max)
            {
                if (selectedMenuItem == 0)
                {
                    highlightedMenuItem++;
                    lastClick = DateTime.Now;
                }
                
            }
            else if (Keyboard.IsKeyDown(Keys.Enter))
            {
                switch (selectedMenu)
                {
                    case 1:
                        switch (highlightedMenuItem)
                        {
                            case 1:
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
            else if (Keyboard.IsKeyDown(Keys.Escape))
            {
                if (selectedMenu > 1)
                {
                    selectedMenu--;
                    selectedMenuItem = 0;
                    highlightedMenuItem = 1;
                    lastClick = DateTime.Now;
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
