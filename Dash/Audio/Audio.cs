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
            set
            {
                if (value > 100)
                {
                    masterVolume = 100;
                }
                else if (value < 0)
                {
                    masterVolume = 0;
                }
                else
                {
                    masterVolume = value;    
                }
            }
            get { return masterVolume; }
        }

        static public int SoundVolume
        {
            set
            {
                if (value > 100)
                {
                    soundVolume = 100;
                }
                else if (value < 0)
                {
                    soundVolume = 0;
                }
                else
                {
                    soundVolume = value;
                }
            }
            get { return soundVolume; }
        }

        static public int MusicVolume
        {
            set
            {
                if (value > 100)
                {
                    musicVolume = 100;
                }
                else if (value < 0)
                {
                    musicVolume = 0;
                }
                else
                {
                    musicVolume = value;
                }
            }
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
