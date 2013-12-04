using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace Dash
{
    /// <summary>
    /// Klasse som håndterer konfigurations xml filen
    /// </summary>
    static class Config
    {
        static private int sound; //Sound-fx Volume
        static private int music; //Music Volume
        static private int master; //Master Volume
        static private Keys leftKey; //Left input key
        static private Keys rightKey; //Right input key
        static private Keys upKey; //Up input key
        static private Keys downKey; //Down input key
        static private Keys shootKey; //shoot input key


        /// <summary>
        /// Gets or Sets ShootKey
        /// </summary>
        static public Keys ShootKey
        {
            get { return shootKey; }
            set { shootKey = value; }
        }

        /// <summary>
        /// Gets or Sets DownKey
        /// </summary>
        static public Keys DownKey
        {
            get { return downKey; }
            set { downKey = value; }
        }

        /// <summary>
        /// Gets or Sets UpKey
        /// </summary>
        static public Keys UpKey
        {
            get { return upKey; }
            set { upKey = value; }
        }

        /// <summary>
        /// Gets or Sets RightKey
        /// </summary>
        static public Keys RightKey
        {
            get { return rightKey; }
            set { rightKey = value; }
        }

        /// <summary>
        /// Gets or Sets LeftKey
        /// </summary>
        static public Keys LeftKey
        {
            get { return leftKey; }
            set { leftKey = value; }
        }

        /// <summary>
        /// Gets or Sets Master Volume
        /// </summary>
        static public int Master
        {
            get { return master; }
        }

        /// <summary>
        /// Gets or Sets Music Volume
        /// </summary>
        static public int Music
        {
            get { return music; }
        }

        /// <summary>
        /// Gets or Sets Sound-fx Volume
        /// </summary>
        static public int Sound
        {
            get { return sound; }
        }

        /// <summary>
        /// Constructor that sets standard values for sound and input keys then either creates or reads from config.xml
        /// </summary>
        static Config()
        {
            sound = 100;
            master = 100;
            music = 100;
            leftKey = Keys.A;
            rightKey = Keys.D;
            upKey = Keys.W;
            downKey = Keys.S;
            shootKey = Keys.Space;

            if (!File.Exists("config.xml"))
            {
                Audio.MasterVolume = 100;
                Audio.SoundVolume = 100;
                Audio.MusicVolume = 100;
                UpdateConfig();
            }
            else
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("config.xml");
                if (doc.DocumentElement == null)
                {
                    Audio.MasterVolume = 100;
                    Audio.SoundVolume = 100;
                    Audio.MusicVolume = 100;
                    UpdateConfig();
                }
                ReadConfig();
            }
        }

        /// <summary>
        /// Method that builds Config.xml based on the info in volume/inputkey fields
        /// </summary>
        static public void UpdateConfig()
        {
            XmlDocument doc = new XmlDocument();
            XmlNode node = doc.CreateElement("Config");
            XmlNode subNode;
            doc.AppendChild(node);
            node = doc.CreateElement("Sound");
            subNode = doc.CreateElement("Music");
            subNode.InnerText = Audio.MusicVolume.ToString();
            node.AppendChild(subNode);
            subNode = doc.CreateElement("Soundfx");
            subNode.InnerText = Audio.SoundVolume.ToString();
            node.AppendChild(subNode);
            subNode = doc.CreateElement("Master");
            subNode.InnerText = Audio.MasterVolume.ToString();
            node.AppendChild(subNode);
            doc.DocumentElement.AppendChild(node);
            node = doc.CreateElement("Keys");
            subNode = doc.CreateElement("Left");
            subNode.InnerText = ((int)leftKey).ToString();
            node.AppendChild(subNode);
            subNode = doc.CreateElement("Right");
            subNode.InnerText = ((int)rightKey).ToString();
            node.AppendChild(subNode);
            subNode = doc.CreateElement("Up");
            subNode.InnerText = ((int)upKey).ToString();
            node.AppendChild(subNode);
            subNode = doc.CreateElement("Down");
            subNode.InnerText = ((int)downKey).ToString();
            node.AppendChild(subNode);
            subNode = doc.CreateElement("Dash");
            subNode.InnerText = ((int)shootKey).ToString();
            node.AppendChild(subNode);
            doc.DocumentElement.AppendChild(node);
            doc.Save("config.xml");
        }

        /// <summary>
        /// Method that reads Config data from config.xml
        /// </summary>
        static void ReadConfig()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("config.xml");
            foreach (XmlElement element in doc.DocumentElement)
            {
                switch (element.Name)
                {
                    case "Sound":

                        foreach (XmlElement e in element)
                        {
                            switch (e.Name)
                            {
                                case "Music":
                                    int.TryParse(e.InnerText, out music);
                                    Audio.MusicVolume = music;
                                    break;


                                case "Soundfx":
                                    int.TryParse(e.InnerText, out sound);
                                    Audio.SoundVolume = sound;
                                    break;


                                case "Master":
                                    int.TryParse(e.InnerText, out master);
                                    Audio.MasterVolume = master;
                                    break;
                            }
                        }
                        break;

                    case "Keys":
                        foreach (XmlElement e in element)
                        {
                            switch (e.Name)
                            {
                                case "Left":
                                    leftKey = (Keys)int.Parse(e.InnerText);
                                    break;

                                case "Right":
                                    rightKey = (Keys)int.Parse(e.InnerText);
                                    break;

                                case "Up":
                                    upKey = (Keys)int.Parse(e.InnerText);
                                    break;

                                case "Down":
                                    downKey = (Keys)int.Parse(e.InnerText);
                                    break;

                                case "Dash":
                                    shootKey = (Keys)int.Parse(e.InnerText);
                                    break;
                            }
                        }
                        break;
                }
            }
        }
    }
}
