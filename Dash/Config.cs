using System.Data.Odbc;
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
        static private int sound; //bruges til at indeholde Sound-FX volume
        static private int music; //bruges til at indeholde musik volume
        static private int master; //bruges til at indeholde master volume
        static private Keys leftKey; //bruges til at indeholde tasten som bruges til at gå til venstre
        static private Keys rightKey; //bruges til at indeholde tasten som bruges til at gå til højre
        static private Keys upKey; //bruges til at indeholde tasten som bruges til at gå op
        static private Keys downKey; //bruges til at indeholde tasten som bruges til at gå ned
        static private Keys shootKey; //bruges til at indeholde tasten som bruges til at skyde


        /// <summary>
        /// Property til at hente eller sætte input key til at skyde
        /// </summary>
        static public Keys ShootKey
        {
            get { return shootKey; }
            set { shootKey = value; }
        }

        /// <summary>
        /// Property til at hente eller sætte input key til at gå nedaf
        /// </summary>
        static public Keys DownKey
        {
            get { return downKey; }
            set { downKey = value; }
        }

        /// <summary>
        /// Property til at hente eller sætte input key til at gå opaf
        /// </summary>
        static public Keys UpKey
        {
            get { return upKey; }
            set { upKey = value; }
        }

        /// <summary>
        /// Property til at hente eller sætte input key til at gå til højre
        /// </summary>
        static public Keys RightKey
        {
            get { return rightKey; }
            set { rightKey = value; }
        }

        /// <summary>
        /// Property til at hente eller sætte input key til at gå til venstre
        /// </summary>
        static public Keys LeftKey
        {
            get { return leftKey; }
            set { leftKey = value; }
        }

        /// <summary>
        /// Property til at hente eller sætte master volume
        /// </summary>
        static public int Master
        {
            get { return master; }
            set { master = value; }
        }

        /// <summary>
        /// Property til at hente eller sætte musik volume
        /// </summary>
        static public int Music
        {
            get { return music; }
            set { music = value; }
        }

        /// <summary>
        /// Property til at hente eller sætte sound-fx volume
        /// </summary>
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
        /// funktion som henter config data fra xml fil og indsætter i fields
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
