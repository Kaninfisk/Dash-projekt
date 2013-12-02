using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IrrKlang;

namespace Dash
{
    /// <summary>
    /// Klasse som håndterer afspilning af lydfiler og volume
    /// </summary>
    static class Audio
    {
        static private int masterVolume;  //field som indeholder master volume
        static private int soundVolume;  //field som indeholder sound-fx volume
        static private int musicVolume;  //field som indeholder musik volume

        private static ISoundEngine musicEngine = new ISoundEngine();  //irrKlang lydengine til at afspille baggrundsmusik
        private static ISoundEngine soundFXEngine = new ISoundEngine(); //irrKlang lydengine til at afspille sound-fx

        /// <summary>
        /// property til at indstille mastervolume denne ændrer også volume på baggrundsmusik og sound-fx lydengines
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
        /// Property til at indstille sound-fx volume denne ændrer også volume på sound-fx lydenginen
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
        /// Property til at indstille musik volume denne ændrer også volume på musik lydenginen
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
        /// Konstruktorern henter volume fra Config klassen og indsætter disse i properties 
        /// </summary>
        static Audio()
        {
            SoundVolume = Config.Sound;
            MusicVolume = Config.Music;
            MasterVolume = Config.Master;
        }

        /// <summary>
        /// Metode som afspiller den angivne lydfil på musik enginen
        /// </summary>
        /// <param name="filePath">Sti til fil som skal loopes</param>
        static public void PlayMusic(string filePath)
        {
            musicEngine.Play2D(filePath, true);
        }

        /// <summary>
        /// Metode som afspiller den angivne lydfil på sound-fx enginen
        /// </summary>
        /// <param name="FilePath">Sti til fil som skal afspilles en enkelt gang</param>
        static public void PlaySoundFX(string FilePath)
        {
            soundFXEngine.Play2D(FilePath, false);
        }
    }
}
