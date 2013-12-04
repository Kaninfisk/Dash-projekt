using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IrrKlang;

namespace Dash
{
    /// <summary>
    /// Class that handless playing of sounds/music
    /// </summary>
    static class Audio
    {
        static private int masterVolume;  //field som indeholder master volume
        static private int soundVolume;  //field som indeholder sound-fx volume
        static private int musicVolume;  //field som indeholder musik volume

        private static ISoundEngine musicEngine = new ISoundEngine();  //irrKlang lydengine til at afspille baggrundsmusik
        private static ISoundEngine soundFXEngine = new ISoundEngine(); //irrKlang lydengine til at afspille sound-fx

        /// <summary>
        /// gets or sets the master volume
        /// </summary>
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

        /// <summary>
        /// gets or sets Sound-fx volume
        /// </summary>
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
                    soundFXEngine.SoundVolume = (((float)(value) / (float)100) / 100) * masterVolume;
                }
            }
            get { return soundVolume; }
        }

        /// <summary>
        /// Gets or Sets Music volume
        /// </summary>
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
                    musicEngine.SoundVolume = (((float)(value) / (float)100) / 100) * masterVolume;
                }
            }
            get { return musicVolume; }
        }


        /// <summary>
        /// Constructor that gets volumes from Config class
        /// </summary>
        static Audio()
        {
            SoundVolume = Config.Sound;
            MusicVolume = Config.Music;
            MasterVolume = Config.Master;
        }

        /// <summary>
        /// Method that plays music thru the music engine with loop
        /// </summary>
        /// <param name="filePath">Path to audio file</param>
        static public void PlayMusic(string filePath)
        {
            musicEngine.Play2D(filePath, true);
        }

        /// <summary>
        /// Method that plays sound-fx thru the sound-fx engine
        /// </summary>
        /// <param name="FilePath">Path to audio file</param>
        static public void PlaySoundFX(string FilePath)
        {
            soundFXEngine.Play2D(FilePath, false);
        }
    }
}
