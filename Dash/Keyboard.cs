using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace System
{
    static class Keyboard
    {
        private enum KeyStates
        {
            None = 0,
            Down = 1,
        }

        /// <summary>
        /// Use dll user32.dll to get state of key
        /// </summary>
        /// <param name="keyCode">Key code of key to check</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        private static extern short GetKeyState(int keyCode);

        /// <summary>
        /// Gets keystate of Key
        /// </summary>
        /// <param name="key">Key to look at</param>
        /// <returns>KeyStates of key</returns>
        private static KeyStates GetKeyState(Keys key)
        {
            KeyStates state = KeyStates.None;

            short retVal = GetKeyState((int)key);

            if ((retVal & 0x8000) == 0x8000)
                state = KeyStates.Down;

            return state;
        }
        
        /// <summary>
        /// Check to see if keystate is down
        /// </summary>
        /// <param name="key">Key to look at</param>
        /// <returns>Returns true if key is down</returns>
        public static bool IsKeyDown(Keys key)
        {
            return GetKeyState(key) == KeyStates.Down;
        }
    }
}
