using IrrKlang;

namespace Dash
{
    /// <summary>
    /// Class that handless playing of sounds/music
    /// </summary>
    static class Audio
    {
        private static int masterVolume;  //field som indeholder master volume
        private static int soundVolume;  //field som indeholder sound-fx volume
        private static int musicVolume;  //field som indeholder musik volume

        private static ISoundEngine musicEngine = new ISoundEngine();  //irrKlang lydengine til at afspille baggrundsmusik
        private static ISoundEngine soundFXEngine = new ISoundEngine(); //irrKlang lydengine til at afspille sound-fx

        /// <summary>
        /// Gets or sets the master volume
        /// </summary>
        public static int MasterVolume
        {
            get { return masterVolume; }
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
                    musicEngine.SoundVolume = (musicVolume / (float)100 / 100) * masterVolume;
                    soundFXEngine.SoundVolume = ((soundVolume / (float)100) / 100) * masterVolume;
                }
            }
        }

        /// <summary>
        /// Gets or sets Sound-fx volume
        /// </summary>
        public static int SoundVolume
        {
            get { return soundVolume; }
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
                    soundFXEngine.SoundVolume = ((value / (float)100) / 100) * masterVolume;
                }
            }
        }

        /// <summary>
        /// Gets or sets Music volume
        /// </summary>
        public static int MusicVolume
        {
            get { return musicVolume; }
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
                    musicEngine.SoundVolume = ((value / (float)100) / 100) * masterVolume;
                }
            }
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
        public static void PlayMusic(string filePath)
        {
            musicEngine.StopAllSounds();
            musicEngine.Play2D(filePath, true);
        }

        /// <summary>
        /// Method that plays sound-fx thru the sound-fx engine
        /// </summary>
        /// <param name="filePath">Path to audio file</param>
        public static void PlaySoundFX(string filePath)
        {
            soundFXEngine.Play2D(filePath, false);
        }
        
        /// <summary>
        /// Method that stops all sounds
        /// </summary>
        public static void StopAllSounds()
        {
            soundFXEngine.StopAllSounds();
            musicEngine.StopAllSounds();
        }
    }
}
