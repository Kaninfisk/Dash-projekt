using System.Data.Odbc;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace Dash
{
    /// <summary>
    /// Config
    /// </summary>
    static class Config
    {
        static private int sound;
        static private int music;
        static private int master;
        static private Keys leftKey;
        static private Keys rightKey;
        static private Keys upKey;
        static private Keys downKey;
        static private Keys shootKey;


        static public Keys ShootKey
        {
            get { return shootKey; }
            set { shootKey = value; }
        }

        static public Keys DownKey
        {
            get { return downKey; }
            set { downKey = value; }
        }

        static public Keys UpKey
        {
            get { return upKey; }
            set { upKey = value; }
        }

        static public Keys RightKey
        {
            get { return rightKey; }
            set { rightKey = value; }
        }


        static public Keys LeftKey
        {
            get { return leftKey; }
            set { leftKey = value; }
        }

        static public int Master
        {
            get { return master; }
            set { master = value; }
        }

        static public int Music
        {
            get { return music; }
            set { music = value; }
        }

        static public int Sound
        {
            get { return sound; }
            set { sound = value; }
        }

        /// <summary>
        /// Constructor til klassen
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
                UpdateConfig();
            }
            else
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("config.xml");
                if (doc.DocumentElement == null)
                {
                    UpdateConfig();
                }
                ReadConfig();
            }
        }

        /// <summary>
        /// Funktion som bygger xml config fil på baggrund af data i fields
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
        /// funktion som henter config data og indsætter i fields
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
