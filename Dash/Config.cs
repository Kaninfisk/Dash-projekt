using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace Dash
{
    /// <summary>
    /// Class that handles input/output to/from config.xml file
    /// </summary>
    static class Config
    {
        private static int sound; //Sound-fx Volume
        private static int music; //Music Volume
        private static int master; //Master Volume
        private static Keys leftKey; //Left input key
        private static Keys rightKey; //Right input key
        private static Keys upKey; //Up input key
        private static Keys downKey; //Down input key
        private static Keys shootKey; //shoot input key

        /// <summary>
        /// Gets or sets ShootKey
        /// </summary>
        public static Keys ShootKey
        {
            get { return shootKey; }
            set { shootKey = value; }
        }

        /// <summary>
        /// Gets or sets DownKey
        /// </summary>
        public static Keys DownKey
        {
            get { return downKey; }
            set { downKey = value; }
        }

        /// <summary>
        /// Gets or sets UpKey
        /// </summary>
        public static Keys UpKey
        {
            get { return upKey; }
            set { upKey = value; }
        }

        /// <summary>
        /// Gets or sets RightKey
        /// </summary>
        public static Keys RightKey
        {
            get { return rightKey; }
            set { rightKey = value; }
        }

        /// <summary>
        /// Gets or sets LeftKey
        /// </summary>
        public static Keys LeftKey
        {
            get { return leftKey; }
            set { leftKey = value; }
        }

        /// <summary>
        /// Gets Master Volume
        /// </summary>
        public static int Master
        {
            get { return master; }
        }

        /// <summary>
        /// Gets Music Volume
        /// </summary>
        public static int Music
        {
            get { return music; }
        }

        /// <summary>
        /// Gets Sound-fx Volume
        /// </summary>
        public static int Sound
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
        public static void UpdateConfig()
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
