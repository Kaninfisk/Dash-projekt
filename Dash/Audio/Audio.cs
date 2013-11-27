using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dash
{
    class Audio
    {
        protected int masterVolume;
        protected int soundVolume;
        protected int musicVolume;

        public int MasterVolume
        {
            set { masterVolume = value; }
        }

        public int SoundVolume
        {
            set { soundVolume = value; }
        }

        public int MusicVolume
        {
            set { musicVolume = value; }
        }
        

        public Audio()
        {
            masterVolume = Config.Master;
            soundVolume = Config.Sound;
            musicVolume = Config.Music;
        }
    }
}
