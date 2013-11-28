using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IrrKlang;

namespace Dash
{
    static class Audio
    {
        static private int masterVolume;
        static private int soundVolume;
        static private int musicVolume;

        private static ISoundEngine musicEngine = new ISoundEngine();
        private static ISoundEngine soundFXEngine = new ISoundEngine();


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
                    musicEngine.SoundVolume = (((float)(musicVolume) / (float)100) / 100) * masterVolume;
                    soundFXEngine.SoundVolume = (((float)(soundVolume) / (float)100) / 100) * masterVolume;
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
                    soundFXEngine.SoundVolume = (((float)(value) / (float)100)/100)*masterVolume;
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
                    musicEngine.SoundVolume =  (((float)(value) /(float)100)/100)*masterVolume;
                }
            }
            get { return musicVolume; }
        }


        static Audio()
        {
            masterVolume = Config.Master;
            soundVolume = Config.Sound;
            musicVolume = Config.Music;
            musicEngine.SoundVolume = musicVolume;
        }

        static public void PlayMusic(string filePath)
        {
            musicEngine.SoundVolume = (((float) musicVolume/100)/100)*masterVolume;
            musicEngine.Play2D(filePath, true);
        }

        static public void PlaySoundFX(string FilePath)
        {
            soundFXEngine.SoundVolume = (((float)soundVolume / 100)/100)*masterVolume;
            soundFXEngine.Play2D(FilePath, false);
        }
    }
}
