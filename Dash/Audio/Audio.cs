using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dash
{
    static class Audio
    {
        static private int masterVolume;
        static private int soundVolume;
        static private int musicVolume;

        static public int MasterVolume
        {
            set { masterVolume = value; }
            get { return masterVolume; }
        }

        static public int SoundVolume
        {
            set { soundVolume = value; }
            get { return soundVolume; }
        }

        static public int MusicVolume
        {
            set { musicVolume = value; }
            get { return musicVolume; }
        }


        static Audio()
        {
            masterVolume = Config.Master;
            soundVolume = Config.Sound;
            musicVolume = Config.Music;
        }
    }
}
