using System.Collections.Generic;
using System.Drawing;

namespace Dash
{
    /// <summary>
    /// Class for levels
    /// </summary>
    internal class Level
    {
        private int type; //type of level
        public GameObject[,] LevelMap; //Foreground map of level with collidable objects
        private GameObject[,] backgroundMap; //background map of level
        private int time; //timer for level

        /// <summary>
        /// Gets Type
        /// </summary>
        public int Type
        {
            get { return type; }
        }

        /// <summary>
        /// Gets BackgroundMap
        /// </summary>
        public GameObject[,] BackgroundMap
        {
            get { return backgroundMap; }
        }

        /// <summary>
        /// Gets Time
        /// </summary>
        public int Time
        {
            get { return time; }
        }

        /// <summary>
        /// Method that Creates levels based on pre determined data
        /// </summary>
        /// <param name="level">Level to create (1-20)</param>
        private void CreateLevel(int level)
        {
            string lm = "";
            string bm = "";

            switch (level)
            {
                case 1:
                    time = 15;

                    #region Level1

                    lm = "H7;H9;R5;R5;SV;R5;R5;R1;R2;R2;R3;R5;SH;R5;R5;R5;R5;R5" + "_" +
                         "H1;H3;N7;E2;E2;E2;E2;E2;E2;E2;E2;E2;E2;E2;E2;E2;E2;N9" + "_" +
                         "SV;R5;E6;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;E4" + "_" +
                         "R5;R5;E6;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;E4" + "_" +
                         "X7;X9;E6;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;E4" + "_" +
                         "X1;X3;E6;NN;NN;NN;W7;W8;W8;W8;W8;W8;W8;W9;NN;NN;NN;E4" + "_" +
                         "R5;R5;E6;NN;NN;NN;E4;R5;R5;R5;R5;X7;X9;E6;NN;NN;NN;E4" + "_" +
                         "R5;SP;E6;NN;NN;NN;E4;X7;X9;R5;SH;X1;X3;E6;NN;NN;NN;E4" + "_" +
                         "E2;E2;E3;NN;NN;NN;E4;X1;X3;N7;E2;E2;E2;E3;NN;NN;NN;E4" + "_" +
                         "NN;NN;NN;NN;NN;NN;E4;R5;R5;E6;NN;NN;NN;NN;NN;NN;NN;E4" + "_" +
                         "PL;NN;NN;NN;NN;NN;E4;H7;H9;E6;NN;NN;NN;NN;NN;NN;NN;E4" + "_" +
                         "NN;NN;NN;NN;NN;NN;E4;H1;H3;E6;NN;NN;NN;W7;W8;W8;W8;N3" + "_" +
                         "W8;W8;W8;W8;W8;W8;N3;R5;R5;E6;NN;NN;NN;E4;H7;H9;R5;R5" + "_" +
                         "R5;SV;R5;R5;SH;R5;R5;SG;SG;E6;BHB;BHB;BHB;E4;H1;H3;R5;R5";

                    bm = "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G4;G4;G4;G4;G4;G4;G4;G4;G4;G4;G4;G4;G4;G4;G4" + "_" +
                         "G1;G1;G1;G4;G4;G4;G3;G3;G3;G3;G3;G3;G3;G3;G3;G3;G3;G4" + "_" +
                         "G1;G1;G1;G4;G4;G4;G3;G3;G3;G3;G3;G3;G3;G3;G3;G3;G3;G4" + "_" +
                         "G1;G1;G1;G4;G4;G4;G3;G3;G3;G3;G3;G3;G3;G3;G3;G3;G3;G4" + "_" +
                         "G1;G1;G1;G4;G4;G4;G1;G1;G1;G1;G1;G1;G1;G1;G3;G3;G3;G4" + "_" +
                         "G1;G1;G1;G4;G4;G4;G1;G1;G1;G1;G1;G1;G1;G1;G3;G3;G3;G4" + "_" +
                         "G1;G1;G1;G4;G4;G4;G1;G1;G1;G1;G1;G1;G1;G1;G3;G3;G3;G4" + "_" +
                         "G1;G1;G1;G4;G4;G4;G1;G1;G1;G1;G1;G1;G1;G3;G3;G3;G3;G4" + "_" +
                         "G4;G4;G4;G4;G4;G4;G1;G1;G1;G1;G1;G1;G1;G3;G3;G3;G3;G4" + "_" +
                         "G4;G4;G4;G4;G4;G4;G1;G1;G1;G1;G1;G1;G1;G3;G3;G3;G3;G4" + "_" +
                         "G4;G4;G4;G4;G4;G4;G1;G1;G1;G1;G1;G1;G1;G1;G4;G4;G4;G4" + "_" +
                         "G1;G1;G1;G1;G3;G4;G1;G1;G1;G1;G1;G1;G1;G1;G4;G4;G4;G4" + "_" +
                         "G1;G1;G1;G1;G1;G3;G1;G1;G1;G1;G1;G1;G1;G1;G4;G4;G4;G4";

                    #endregion

                    break;
                case 2:
                    time = 25;

                    #region Level2

                    lm = "E2;E2;E2;E2;E2;E2;N9;SV;E6;NN;NN;NN;NN;E4;X7;X9;R5;R5" + "_" +
                         "BVL;NN;NN;NN;NN;NN;E4;R5;E6;NN;NN;NN;NN;E4;X1;X3;R5;SV" + "_" +
                         "BVL;NN;NN;NN;NN;NN;E4;SH;E6;NN;NN;NN;NN;E1;E2;E2;E2;N9" + "_" +
                         "BVL;NN;NN;NN;NN;NN;E4;R5;E6;NN;PL;NN;NN;NN;NN;NN;NN;E4" + "_" +
                         "W8;W8;W9;NN;NN;NN;E4;R5;E6;NN;NN;NN;NN;NN;NN;NN;NN;E4" + "_" +
                         "R5;SV;E6;NN;NN;NN;E4;SP;E6;NN;NN;NN;NN;NN;NN;NN;NN;E4" + "_" +
                         "N7;E2;E3;NN;NN;NN;E4;R5;N1;W8;W8;W8;W8;W9;NN;NN;NN;E4" + "_" +
                         "E6;NN;NN;NN;NN;NN;E4;R5;SH;R5;SG;SG;SP;E6;NN;NN;NN;E4" + "_" +
                         "E6;NN;NN;NN;NN;NN;E1;E2;E2;E2;E2;E2;E2;E3;NN;NN;NN;E4" + "_" +
                         "E6;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;E4" + "_" +
                         "E6;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;E4" + "_" +
                         "E6;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;E4" + "_" +
                         "E6;HB12;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;W7;W8;W8;N3" + "_" +
                         "E6;F7;F8;F8;F8;F8;F8;F8;F8;F8;F8;F8;F8;F9;E4;R5;SH;R5";

                    bm = "G1;G1;G1;G1;G1;G1;G1;G1;G1;G4;G4;G4;G4;G1;G1;G1;G1;G1" + "_" +
                         "G3;G3;G3;G1;G1;G1;G1;G1;G1;G4;G4;G4;G4;G1;G1;G1;G1;G1" + "_" +
                         "G3;G3;G3;G1;G1;G1;G1;G1;G1;G4;G4;G4;G4;G1;G1;G1;G1;G1" + "_" +
                         "G3;G3;G3;G1;G1;G1;G1;G1;G1;G4;G4;G4;G4;G3;G3;G3;G3;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G4;G4;G4;G4;G3;G3;G3;G3;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G4;G4;G4;G4;G3;G3;G3;G3;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G3;G3;G3;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G3;G3;G3;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G3;G3;G3;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G3;G3;G3;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G3;G3;G3;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G3;G3;G3;G1" + "_" +
                         "G1;L1;L2;L2;L2;L2;L2;L2;L2;L2;L2;L2;L2;L3;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1";

                    #endregion

                    break;
                case 3:
                    time = 22;

                    #region Level3

                    lm = "S7;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;PL;NN" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;W7;W8;W8;W8;W8;W9" + "_" +
                         "SL;NN;NN;NN;F7;F8;F8;F8;F9;NN;NN;NN;E4;R5;R5;R5;R5;E6" + "_" +
                         "SL;NN;NN;NN;E4;R5;R5;R5;E6;NN;NN;NN;E1;E2;E2;E2;E2;E3" + "_" +
                         "SL;NN;NN;NN;E4;R5;R5;R5;E6;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;E4;R5;R5;R5;E6;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;E1;E2;E2;E2;E3;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;HB9;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "F7;F8;F8;F8;F8;F8;F8;F8;F8;BHB;BHB;BHB;F8;F8;F8;F8;F8;F9";

                    bm = "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1";

                    #endregion

                    break;
                case 4:
                    time = 15;

                    #region Level4

                    lm = "S7;ST;ST;F1;F2;F3;E4;E6;M9;PL;NN;ST;ST;ST;ST;ST;ST;S9" + "_" +
                         "SL;NN;NN;NN;NN;NN;E4;E6;M6;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;E4;E6;M3;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;E1;E3;WB;WB;WB;WB;WB;WB;WB;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;W7;W8;W9;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;F1;F2;F3;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;U4;U6;R5" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;E7;E9;NN;NN;NN;NN;NN;BVR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;E4;E6;NN;NN;NN;NN;NN;BVR" + "_" +
                         "W7;W8;W8;W8;W8;W9;NN;NN;NN;NN;E4;E6;NN;NN;NN;NN;NN;BVR" + "_" +
                         "E1;E2;E2;E2;E2;E3;F7;F8;F8;F9;E1;E3;W7;W8;W8;W8;W8;W9";

                    bm = "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1";

                    #endregion

                    break;
                case 5:
                    time = 13;

                    #region Level5

                    lm = "S7;ST;ST;F1;F3;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;M7" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;VB5;NN;NN;NN;NN;NN;NN;NN;M4" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;M4" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;M4" + "_" +
                         "SL;NN;NN;F7;F9;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;M1" + "_" +
                         "SL;NN;NN;R7;R9;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;R4;R6;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;R4;R9;R8;R8;R8;R9;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;R4;R5;R5;R5;R5;R6;NN;NN;NN;R7;R8;R8;R8;R8;R9" + "_" +
                         "SL;NN;NN;R4;R5;R5;R5;R5;R6;NN;NN;NN;R1;R2;R2;R2;R2;R3" + "_" +
                         "PL;NN;NN;R4;R5;R5;R5;R5;R6;NN;NN;NN;NN;NN;NN;NN;NN;BVR" + "_" +
                         "NN;NN;NN;R4;R5;R5;R5;R5;R6;NN;NN;NN;NN;NN;NN;NN;NN;BVR" + "_" +
                         "NN;NN;NN;R1;R2;R2;R2;R2;R3;NN;NN;NN;NN;NN;NN;NN;NN;BVR" + "_" +
                         "W7;W8;W8;W8;W8;W8;W8;W8;W8;W8;W8;W8;W8;W8;W8;W8;W8;W9";

                    bm = "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1";

                    #endregion

                    break;
                case 6:
                    time = 12;

                    #region Level6

                    lm = "ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;S9" + "_" +
                         "PL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;VM5;NN;NN;NN;NN;NN;SR" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "W7;W8;W8;W8;W8;W8;W8;W9;NN;NN;NN;NN;NN;NN;NN;F7;F8;F9" + "_" +
                         "E4;SV;SV;R5;R5;SH;R5;E6;NN;NN;NN;NN;NN;NN;NN;E1;E2;E3" + "_" +
                         "E1;E2;E2;E2;E2;E2;E2;E3;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;M7;U8;M9;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;M4;IV;M6;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;M1;U2;M3;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;W7;W8;W8;W8;W8;W8;W8;W8;W8;W8;W8;W9;NN;NN;SR" + "_" +
                         "SL;NN;NN;E1;E2;E2;E2;E2;E2;E2;E2;E2;E2;E2;E3;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;BVR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;BVR" + "_" +
                         "W7;W8;W8;W8;W8;W8;W8;W8;W8;W8;W8;W8;W8;W8;W8;W8;W8;W8";

                    bm = "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1";

                    #endregion

                    break;
                case 7:
                    time = 15;

                    #region Level7

                    lm = "ST;ST;ST;ST;ST;ST;R8;ST;ST;ST;ST;ST;ST;ST;ST;R7;R8;R9" + "_" +
                         "PL;NN;NN;NN;NN;NN;R5;NN;NN;NN;NN;NN;NN;NN;NN;R4;R5;R6" + "_" +
                         "NN;NN;NN;NN;NN;NN;R5;NN;NN;NN;NN;NN;NN;NN;NN;R4;R5;R6" + "_" +
                         "R7;R8;R8;R9;NN;NN;R5;NN;NN;NN;NN;NN;NN;NN;NN;R4;R5;R6" + "_" +
                         "R1;R2;R2;R3;NN;NN;R5;NN;NN;NN;R7;R9;NN;NN;NN;R1;R2;R3" + "_" +
                         "SL;NN;NN;NN;NN;NN;R5;NN;NN;NN;R4;R6;NN;NN;NN;NN;NN;BVR" + "_" +
                         "SL;NN;NN;NN;NN;NN;R2;DH;NN;NN;R4;R6;NN;NN;NN;NN;NN;BVR" + "_" +
                         "SL;NN;NN;CP;NN;NN;NN;NN;NN;NN;R4;R6;NN;NN;NN;NN;NN;BVR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;R4;R5;R8;R8;R8;R8;R8;R9" + "_" +
                         "SL;NN;BB1;NN;NN;NN;NN;NN;NN;NN;R4;R5;R5;R5;R5;R5;R5;R6" + "_" +
                         "R7;R8;R9;NN;NN;NN;NN;NN;NN;NN;R4;R5;R5;R5;R5;R5;R5;R6" + "_" +
                         "R4;R5;R6;NN;NN;NN;NN;R7;R8;R8;R5;R5;R5;R5;R5;R5;R5;R6" + "_" +
                         "R4;R5;R6;F7;F8;F8;F9;R4;R5;R5;R5;R5;R5;R5;R5;R5;R5;R6" + "_" +
                         "R1;R2;R2;R2;R2;R2;R2;R2;R2;R2;R2;R2;R2;R2;R2;R2;R2;R3";

                    bm = "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1";

                    #endregion

                    break;
                case 8:
                    time = 23;

                    #region Level8

                    lm = "M9;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;DV;ST;ST;ST;S9" + "_" +
                         "M6;NN;NN;NN;VB11;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;BR2" + "_" +
                         "M6;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "M6;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;U4;IH;IH;IH;U6" + "_" +
                         "M3;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "PL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;BR1" + "_" +
                         "WB;WB;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "M6;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "M3;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;U4;IH;IH;IH;U6" + "_" +
                         "M6;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;DV;NN;NN;NN;SR" + "_" +
                         "M6;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "M9;NN;NN;NN;NN;HB5;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "F7;F8;F8;F8;F8;F8;F8;F8;F8;F8;F8;F8;F9;U4;U6;BHB;BHB;SR";

                    bm = "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1";

                    #endregion

                    break;
                case 9:
                    time = 13;

                    #region Level9

                    lm = "S7;ST;ST;ST;ST;ST;ST;ST;ST;ST;NN;NN;NN;U8;ST;ST;ST;ST" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;PL;NN;IV;NN;NN;NN;BVR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;IV;NN;NN;NN;BVR" + "_" +
                         "SL;NN;NN;NN;F7;F8;F8;F8;F8;F8;F9;W7;W9;U2;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;E1;E2;E2;N9;R5;R5;SV;SV;SV;E6;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;E4;H7;H9;R5;R5;R5;E6;VB7;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;E4;H1;H3;R5;R5;SP;E6;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;E4;R5;R5;R5;R5;SP;E6;NN;NN;NN;SR" + "_" +
                         "F7;F8;F9;NN;NN;NN;NN;E4;R5;R5;SH;R5;R5;E6;NN;NN;NN;SR" + "_" +
                         "E1;E2;E3;NN;NN;NN;NN;E1;E2;E2;E2;E2;E2;E3;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "W7;W9;F7;F8;F8;F8;F8;F8;F8;F8;F8;F8;F8;F8;F8;F9;W7;W9";

                    bm = "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1";

                    #endregion

                    break;
                case 10:
                    time = 16;

                    #region Level10

                    lm = "R5;R5;R5;R5;R5;E6;ST;ST;ST;ST;ST;ST;ST;E1;E2;E2;E2;E2" + "_" +
                         "E2;E2;E2;E2;E2;E3;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "PL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "WB;WB;WB;WB;WB;WB;NN;NN;NN;NN;NN;NN;NN;WB;WB;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;E1;E3;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;HM7;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;E7;M9;VM5;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;E4;M3;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "BVL;NN;NN;NN;NN;NN;NN;NN;E4;M3;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "BVL;NN;NN;NN;NN;NN;NN;NN;E4;M3;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "BVL;HM7;NN;NN;NN;NN;NN;NN;E4;M6;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "F7;F8;F8;F8;F8;F8;F8;F9;E1;SB;SB;SB;SB;SB;SB;SB;SB;S3";

                    bm = "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1";

                    #endregion

                    break;
                case 11:
                    time = 13;

                    #region Level11

                    lm = "ST;ST;ST;ST;ST;ST;R7;R9;ST;ST;ST;ST;ST;ST;ST;ST;ST;S9" + "_" +
                         "PL;NN;NN;NN;NN;NN;R4;R6;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "NN;NN;NN;NN;NN;NN;R4;R6;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "WB;WB;WB;NN;NN;NN;R1;R3;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "E1;E2;E3;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;BVR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;F7;F8;F9;NN;NN;NN;BVR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;F1;F2;F3;NN;NN;NN;BVR" + "_" +
                         "SL;HB16;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "F7;F8;F8;F8;F8;F8;F8;F8;F8;F8;F8;F8;F8;F8;F8;F8;F8;F9";

                    bm = "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1";

                    #endregion

                    break;
                case 12:
                    time = 16;

                    #region Level12

                    lm = "S7;BT1;ST;ST;ST;ST;ST;ST;ST;S9;BHT;BHT;BHT;S7;ST;ST;ST;M7" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;SR;DH;NN;NN;SL;NN;NN;VB11;M4" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;SR;DH;NN;NN;SL;NN;NN;NN;M4" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;M4" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;M4" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;M4" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;M4" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;M4" + "_" +
                         "NN;PL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;M4" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;M4" + "_" +
                         "WB;WB;WB;WB;WB;WB;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;M4" + "_" +
                         "R7;R8;R8;R8;R8;R9;BL1;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;M4" + "_" +
                         "R4;R5;R5;H7;H9;R6;HB11;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;M1" + "_" +
                         "R1;R2;R2;H1;H3;R3;F7;F8;F8;F8;F8;F8;F8;F8;F8;F8;F8;F9";

                    bm = "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1";

                    #endregion

                    break;
                case 13:
                    time = 13;

                    #region Level13

                    lm = "S7;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;BHT;BHT;BHT;S9" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;HB16;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;F7;F8;F8;F8;F8;F8;F8;F8;F8;F8;F8;F8;F9;SR" + "_" +
                         "SL;NN;NN;NN;R7;R8;R8;R8;R8;R8;R9;E7;E8;E8;E8;E8;E8;E8" + "_" +
                         "SL;NN;NN;NN;R4;R3;R2;SG;SG;SG;R3;E1;E2;E2;N9;SH;R5;R5" + "_" +
                         "SL;NN;NN;NN;R4;R6;NN;NN;NN;PL;NN;NN;NN;NN;E4;R5;R5;R5" + "_" +
                         "SL;NN;NN;NN;R4;R6;NN;NN;NN;NN;NN;NN;NN;NN;E4;R5;R5;R5" + "_" +
                         "SL;NN;NN;NN;R1;R3;NN;NN;NN;NN;NN;NN;NN;NN;E4;R5;R5;R5" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;W7;W9;NN;NN;NN;E4;R5;H7;H9" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;E4;E6;NN;NN;NN;E4;R5;H1;H3" + "_" +
                         "S1;SB;SB;SB;SB;SB;SB;SB;SB;E4;E6;DH;NN;NN;E4;R5;R5;R5";

                    bm = "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1";

                    #endregion

                    break;
                case 14:
                    time = 13;

                    #region Level14

                    lm = "S7;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;S9" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;R7;R8;R8;R9;NN;NN;NN;NN;NN;NN;E7;E9;NN;NN;SR" + "_" +
                         "SL;NN;NN;R4;SV;SV;R6;NN;NN;NN;NN;NN;NN;E4;E6;NN;NN;SR" + "_" +
                         "SL;NN;NN;R1;R2;R2;R3;VB7;NN;NN;NN;NN;NN;E4;E6;NN;NN;SR" + "_" +
                         "SL;NN;NN;F1;F2;F2;F3;NN;NN;NN;NN;NN;NN;E4;E6;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;E4;E6;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;E4;E6;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;E4;E6;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;E4;E6;NN;NN;SR" + "_" +
                         "SL;NN;NN;F7;F8;F8;F9;NN;NN;NN;NN;NN;NN;E4;E6;NN;NN;SR" + "_" +
                         "SL;NN;NN;R7;R8;R8;R9;NN;NN;NN;NN;NN;NN;E4;E6;PL;NN;SR" + "_" +
                         "F7;F8;F9;R1;R2;R2;R3;SB;SB;SB;BHB;BHB;BHB;E1;E3;NN;NN;SR";

                    bm = "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1";

                    #endregion

                    break;
                case 15:
                    time = 21;

                    #region Level15

                    lm = "F1;F2;F3;ST;ST;ST;F1;F2;F2;F3;NN;NN;NN;ST;ST;ST;ST;S9" + "_" +
                         "M9;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;PL;NN;NN;NN;NN;NN;SR" + "_" +
                         "M6;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "M6;NN;NN;NN;NN;NN;NN;NN;NN;NN;E7;E8;E8;E9;NN;NN;NN;SR" + "_" +
                         "M3;NN;NN;NN;NN;NN;NN;NN;NN;NN;E1;E2;E2;E3;NN;NN;NN;SR" + "_" +
                         "F7;F8;F9;NN;NN;NN;NN;NN;NN;NN;HT;HT;HT;HT;NN;NN;NN;SR" + "_" +
                         "R1;R2;R3;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;U8;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;U2;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;U4;IH;IH;U6" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;M7" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;M4" + "_" +
                         "SL;HM4;NN;NN;NN;NN;R7;R9;NN;NN;NN;NN;NN;NN;NN;NN;NN;M1" + "_" +
                         "F7;F8;F8;F8;F8;F9;R1;R3;BHB;BHB;BHB;F7;F8;F8;F8;F8;F8;F9";

                    bm = "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1";

                    #endregion

                    break;
                case 16:
                    time = 21;

                    #region Level16

                    lm = "S7;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;S9" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;VB9;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;R7;R8;R8;R8;R9" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;R4;SH;R5;SH;R6" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;R1;R2;R2;R2;R3" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;M7" + "_" +
                         "NN;PL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;M4" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;M4" + "_" +
                         "W8;W8;W8;W8;W9;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;M1" + "_" +
                         "E4;X7;X9;R5;E6;NN;NN;NN;HB9;NN;NN;NN;NN;NN;NN;NN;NN;E7" + "_" +
                         "E4;X1;X3;R5;E6;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;E4" + "_" +
                         "E1;E2;E2;E2;E3;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;E4" + "_" +
                         "SV;SV;SP;SP;E6;F7;F8;F8;F8;F8;F8;F8;F9;BHB;BHB;BHB;BHB;E1";

                    bm = "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1";

                    #endregion

                    break;
                case 17:
                    time = 21;

                    #region Level17

                    lm = "S7;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;NN;NN;E7" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;PL;NN;E4" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;E4" + "_" +
                         "SL;NN;NN;E7;E8;E8;E8;E8;E8;E8;E8;E8;E8;E8;E8;E8;E8;R3" + "_" +
                         "SL;NN;NN;E4;NN;BT2;NN;R5;NN;NN;NN;NN;NN;R5;NN;NN;NN;DV" + "_" +
                         "SL;NN;NN;E4;NN;NN;NN;F1;NN;NN;NN;NN;NN;R5;NN;NN;NN;BVR" + "_" +
                         "SL;NN;NN;E4;NN;NN;NN;NN;NN;NN;NN;NN;NN;R5;NN;NN;NN;BVR" + "_" +
                         "SL;NN;NN;E4;NN;NN;NN;NN;NN;NN;NN;NN;NN;R5;NN;NN;NN;E7" + "_" +
                         "SL;NN;NN;E4;NN;NN;NN;KU;NN;NN;E8;NN;NN;R5;NN;NN;NN;E4" + "_" +
                         "SL;NN;NN;E4;NN;NN;NN;E6;NN;NN;R5;NN;NN;R5;NN;NN;NN;E4" + "_" +
                         "SL;NN;NN;E1;E2;E2;E2;E3;NN;NN;R5;NN;NN;E2;NN;NN;NN;E4" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;R5;NN;NN;NN;NN;NN;NN;E4" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;R5;NN;NN;NN;NN;NN;NN;E4" + "_" +
                         "S1;SB;SB;SB;SB;SB;SB;SB;SB;SB;R5;SB;SB;SB;SB;SB;SB;E1";

                    bm = "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1";

                    #endregion

                    break;
                case 18:
                    time = 14;

                    #region Level18

                    lm = "S7;ST;ST;ST;ST;R5;ST;ST;ST;ST;ST;R5;ST;ST;ST;ST;ST;S9" + "_" +
                         "SL;NN;NN;NN;NN;SG;NN;NN;NN;NN;NN;SG;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;SG;NN;NN;NN;NN;NN;SG;BL2;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;SG;NN;NN;NN;NN;NN;SG;NN;NN;NN;NN;NN;SR" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;SG;NN;NN;NN;NN;NN;SG;NN;NN;SR" + "_" +
                         "PL;NN;NN;NN;NN;NN;NN;NN;SG;NN;NN;NN;NN;NN;SG;NN;NN;SR" + "_" +
                         "NN;NN;NN;R5;NN;NN;NN;NN;SG;NN;NN;NN;NN;NN;SG;NN;NN;SR" + "_" +
                         "DH;NN;NN;W8;W8;W8;W8;W8;W8;W8;W8;W8;W8;W8;R3;NN;NN;SR" + "_" +
                         "SL;NN;NN;R5;NN;VM5;NN;VM5;NN;VM5;NN;VM5;NN;NN;SG;NN;NN;SR" + "_" +
                         "SL;NN;NN;R5;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SG;NN;NN;SR" + "_" +
                         "BVL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "BVL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "BVL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "F7;F8;F8;F8;F8;F8;F8;F8;F8;F8;F8;F8;F8;F8;F8;F8;F8;F9";

                    bm = "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1";

                    #endregion

                    break;
                case 19:
                    time = 15;

                    #region Level19

                    lm = "M9;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;S9" + "_" +
                         "M6;VM6;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "M6;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "M6;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;VM7;W7;W9;NN;NN;SR" + "_" +
                         "M6;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;X7;X9;NN;NN;SR" + "_" +
                         "M6;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;X1;X3;NN;NN;SR" + "_" +
                         "M6;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;E7;E9;NN;NN;SR" + "_" +
                         "M3;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;E4;E6;NN;NN;SR" + "_" +
                         "U4;IH;IH;IH;U6;NN;NN;NN;NN;NN;NN;NN;NN;E4;E6;NN;NN;SR" + "_" +
                         "BVL;NN;NN;NN;NN;NN;NN;NN;NN;CP;NN;NN;NN;E4;E6;NN;NN;SR" + "_" +
                         "BVL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;E4;E6;NN;PL;NN" + "_" +
                         "BVL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;E4;E6;NN;NN;NN" + "_" +
                         "SL;NN;NN;NN;NN;CP;NN;NN;NN;NN;NN;NN;NN;E1;E3;NN;NN;NN" + "_" +
                         "F7;F8;F8;F8;F8;F8;F8;F8;F8;F8;F8;F9;W7;W8;W8;W8;W8;W9";

                    bm = "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1";

                    #endregion

                    break;
                case 20:
                    time = 19;

                    #region Level20

                    lm = "S7;ST;ST;BT4;ST;R5;ST;ST;R5;ST;ST;R5;ST;ST;BT3;ST;ST;S9" + "_" +
                         "SL;NN;NN;NN;NN;R5;NN;NN;DV;NN;NN;R5;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;R5;NN;NN;NN;NN;NN;R5;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;R5;NN;NN;NN;NN;NN;NN;NN;NN;R5;NN;NN;SR" + "_" +
                         "SL;NN;NN;F7;F9;R5;NN;NN;R5;NN;NN;NN;NN;NN;R5;NN;NN;SR" + "_" +
                         "SL;NN;NN;R5;R5;CP;NN;NN;R5;R5;R5;R5;R5;R5;R5;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;R5;R5;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;R5;R5;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "DH;NN;NN;R5;R5;R5;R5;R5;R5;E9;NN;NN;R5;R5;R5;R5;R5;R5" + "_" +
                         "BVL;NN;NN;NN;NN;NN;NN;PS4;M7;E6;NN;NN;R5;NN;NN;NN;PL;NN" + "_" +
                         "BVL;NN;NN;NN;NN;NN;NN;NN;M4;E6;NN;NN;R5;NN;NN;NN;NN;NN" + "_" +
                         "BVL;NN;NN;NN;NN;NN;NN;NN;M4;E6;NN;NN;NN;NN;NN;E7;E8;E8" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;M1;E6;NN;NN;NN;NN;NN;R4;H7;H9" + "_" +
                         "S1;SB;SB;SB;SB;SB;SB;SB;SB;E3;SB;SB;SB;SB;SB;E4;H1;H3";

                    bm = "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1" + "_" +
                         "G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1;G1";

                    #endregion

                    break;
            }

            LevelMap = CreateMap(lm);
            backgroundMap = CreateMap(bm);
        }

        /// <summary>
        /// Constructor that creates a level based on input
        /// </summary>
        /// <param name="level">Which level to create int between 1-20</param>
        public Level(int level)
        {
            CreateLevel(level);
        }

        /// <summary>
        /// Builds the map arrays
        /// </summary>
        /// <param name="map">Map field to output to</param>
        /// <returns>Array based of the input string</returns>
        private GameObject[,] CreateMap(string map)
        {
            string[] temp = map.Split('_');

            GameObject[,] lvlMap = new GameObject[temp.Length, temp[0].Split(';').Length];

            int y = 0;
            foreach (string s1 in temp)
            {
                int x = 0;
                foreach (string s2 in s1.Split(';'))
                {
                    List<Rect> collisionBoxes;
                    switch (s2)
                    {
                        case "OO":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 48));
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "", collisionBoxes);
                            break;

                        #region Buttons
                        case "BB":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 48));
                            lvlMap[y, x] = new TriggerBlock(1, new Point(14, 7), new PointF(x * 48, y * 48), "Graphics\\BB.gif;Graphics\\B3.gif", collisionBoxes);
                            break;
                        case "BB1":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 48));
                            lvlMap[y, x] = new TriggerBlock(1, new Point(7, 6), new PointF(x * 48, y * 48), "Graphics\\BB.gif;Graphics\\B3.gif", collisionBoxes);
                            break;
                        case "BL":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 48));
                            lvlMap[y, x] = new TriggerBlock(1, new PointF(x * 48, y * 48), "Graphics\\BL.gif;Graphics\\B2.gif", collisionBoxes);
                            break;
                        case "BL1":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0,0), 48, 48));
                            lvlMap[y, x] = new TriggerBlock(1,new Point(10,2),  new PointF(x * 48, y * 48), "Graphics\\BL.gif;Graphics\\B2.gif", collisionBoxes);
                            break;
                        case "BL2":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 48));
                            lvlMap[y, x] = new TriggerBlock(1, new Point(0, 7), new PointF(x * 48, y * 48), "Graphics\\BL.gif;Graphics\\B2.gif", collisionBoxes);
                            break;
                        case "BR":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 48));
                            lvlMap[y, x] = new TriggerBlock(1, new PointF(x * 48, y * 48), "Graphics\\BR.gif;Graphics\\B1.gif", collisionBoxes);
                            break;
                        case "BR1":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 48));
                            lvlMap[y, x] = new TriggerBlock(1,new Point(13,0),  new PointF(x * 48, y * 48), "Graphics\\BR.gif;Graphics\\B1.gif", collisionBoxes);
                            break;
                        case "BR2":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 48));
                            lvlMap[y, x] = new TriggerBlock(1,new Point(13,10),  new PointF(x * 48, y * 48), "Graphics\\BR.gif;Graphics\\B1.gif", collisionBoxes);
                            break;
                        case "BT":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 48));
                            lvlMap[y, x] = new TriggerBlock(1, new PointF(x * 48, y * 48), "Graphics\\BT.gif;Graphics\\B4.gif", collisionBoxes);
                            break;
                        case "BT1":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0,0), 48, 48));
                            lvlMap[y, x] = new TriggerBlock(1,new Point(10,1),  new PointF(x * 48, y * 48), "Graphics\\BT.gif;Graphics\\B4.gif", collisionBoxes);
                            break;
                        case "BT2":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 48));
                            lvlMap[y, x] = new TriggerBlock(1, new Point(17, 4), new PointF(x * 48, y * 48), "Graphics\\BT.gif;Graphics\\B4.gif", collisionBoxes);
                            break;
                        case "BT3":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 48));
                            lvlMap[y, x] = new TriggerBlock(1, new Point(8, 1), new PointF(x * 48, y * 48), "Graphics\\BT.gif;Graphics\\B4.gif", collisionBoxes);
                            break;
                        case "BT4":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 48));
                            lvlMap[y, x] = new TriggerBlock(1, new Point(0, 8), new PointF(x * 48, y * 48), "Graphics\\BT.gif;Graphics\\B4.gif", collisionBoxes);
                            break;
                        case "BHT":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 24));
                            lvlMap[y, x] = new TriggerBlock(2, new PointF(x * 48, y * 48), "", collisionBoxes);
                            break;
                        case "BHB":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 24), 48, 24));
                            lvlMap[y, x] = new TriggerBlock(2, new PointF(x * 48, y * 48), "", collisionBoxes);
                            break;
                        case "BVL":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 24, 48));
                            lvlMap[y, x] = new TriggerBlock(2, new PointF(x * 48, y * 48), "", collisionBoxes);
                            break;
                        case "BVR":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(24, 0), 24, 48));
                            lvlMap[y, x] = new TriggerBlock(2, new PointF(x * 48, y * 48), "", collisionBoxes);
                            break;


                        #endregion

                        #region Corners (half-tile)

                        case "C1":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(24, 0), 24, 24));
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\C1.gif", collisionBoxes);
                            break;
                        case "C3":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 24, 24));
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\C3.gif", collisionBoxes);
                            break;
                        case "C7":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(24, 24), 24, 24));
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\C7.gif", collisionBoxes);
                            break;
                        case "C9":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 24), 24, 24));
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\C9.gif", collisionBoxes);
                            break;

                        #endregion

                        #region Doors

                        case "DH":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 144, 48));
                            lvlMap[y, x] = new GateBlock(new PointF(x * 48, y * 48), "Graphics\\DH.gif;Graphics\\D2.gif", collisionBoxes);
                            break;
                        case "DV":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 144));
                            lvlMap[y, x] = new GateBlock(new PointF(x * 48, y * 48), "Graphics\\DV.gif;Graphics\\D1.gif", collisionBoxes);
                            break;

                        #endregion

                        #region Edges

                        case "E1":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 48));
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\E1.gif", collisionBoxes);
                            break;
                        case "E2":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 48));
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\E2.gif", collisionBoxes);
                            break;
                        case "E3":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 48));
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\E3.gif", collisionBoxes);
                            break;
                        case "E4":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 48));
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\E4.gif", collisionBoxes);
                            break;
                        case "E6":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 48));
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\E6.gif", collisionBoxes);
                            break;
                        case "E7":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 48));
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\E7.gif", collisionBoxes);
                            break;
                        case "E8":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 48));
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\E8.gif", collisionBoxes);
                            break;
                        case "E9":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 48));
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\E9.gif", collisionBoxes);
                            break;

                        #endregion

                        #region Floor/Ceiling spikes (hor. surf.)

                        case "F1":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 24));
                            lvlMap[y, x] = new Enemy(new PointF(x * 48, y * 48), "Graphics\\F1.gif", collisionBoxes);
                            break;
                        case "F2":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 24));
                            lvlMap[y, x] = new Enemy(new PointF(x * 48, y * 48), "Graphics\\F2.gif", collisionBoxes);
                            break;
                        case "F3":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 24));
                            lvlMap[y, x] = new Enemy(new PointF(x * 48, y * 48), "Graphics\\F3.gif", collisionBoxes);
                            break;
                        case "F7":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 24), 48, 24));
                            lvlMap[y, x] = new Enemy(new PointF(x * 48, y * 48), "Graphics\\F7.gif", collisionBoxes);
                            break;
                        case "F8":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 24), 48, 24));
                            lvlMap[y, x] = new Enemy(new PointF(x * 48, y * 48), "Graphics\\F8.gif", collisionBoxes);
                            break;
                        case "F9":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 24), 48, 24));
                            lvlMap[y, x] = new Enemy(new PointF(x * 48, y * 48), "Graphics\\F9.gif", collisionBoxes);
                            break;
                        case "KU":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 24), 48, 24));
                            lvlMap[y, x] = new Enemy(new PointF(x * 48, y * 48), "Graphics\\KU.gif", collisionBoxes);
                            break;
                        case "KD":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(24, 0), 48, 24));
                            lvlMap[y, x] = new Enemy(new PointF(x * 48, y * 48), "Graphics\\KD.gif", collisionBoxes);
                            break;

                        #endregion

                        #region Background tiles

                        case "G1":
                            collisionBoxes = new List<Rect>();
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\G1.gif", collisionBoxes);
                            break;
                        case "G2":
                            collisionBoxes = new List<Rect>();
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\G2.gif", collisionBoxes);
                            break;
                        case "G3":
                            collisionBoxes = new List<Rect>();
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\G3.gif", collisionBoxes);
                            break;
                        case "G4":
                            collisionBoxes = new List<Rect>();
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\G4.gif", collisionBoxes);
                            break;
                        case "G5":
                            collisionBoxes = new List<Rect>();
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\G5.gif", collisionBoxes);
                            break;
                        case "L1":
                            collisionBoxes = new List<Rect>();
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\L1.gif", collisionBoxes);
                            break;
                        case "L2":
                            collisionBoxes = new List<Rect>();
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\L2.gif", collisionBoxes);
                            break;
                        case "L3":
                            collisionBoxes = new List<Rect>();
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\L3.gif", collisionBoxes);
                            break;
                        case "L4":
                            collisionBoxes = new List<Rect>();
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\L4.gif", collisionBoxes);
                            break;
                        case "L5":
                            collisionBoxes = new List<Rect>();
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\L5.gif", collisionBoxes);
                            break;
                        case "Q1":
                            collisionBoxes = new List<Rect>();
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\Q1.gif", collisionBoxes);
                            break;
                        case "Q2":
                            collisionBoxes = new List<Rect>();
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\Q2.gif", collisionBoxes);
                            break;
                        case "Q3":
                            collisionBoxes = new List<Rect>();
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\Q3.gif", collisionBoxes);
                            break;
                        case "Q4":
                            collisionBoxes = new List<Rect>();
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\Q4.gif", collisionBoxes);
                            break;
                        case "Q5":
                            collisionBoxes = new List<Rect>();
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\Q5.gif", collisionBoxes);
                            break;

                        #endregion

                        #region Hole blocks

                        case "H1":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 48));
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\H1.gif", collisionBoxes);
                            break;
                        case "H3":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 48));
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\H3.gif", collisionBoxes);
                            break;
                        case "H7":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 48));
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\H7.gif", collisionBoxes);
                            break;
                        case "H9":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 48));
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\H9.gif", collisionBoxes);
                            break;

                        #endregion

                        #region Indented blocks

                        case "I1":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 48));
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\I1.gif", collisionBoxes);
                            break;
                        case "I3":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 48));
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\I3.gif", collisionBoxes);
                            break;
                        case "I7":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 48));
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\I7.gif", collisionBoxes);
                            break;
                        case "I9":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 48));
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\I9.gif", collisionBoxes);
                            break;
                        case "IH":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 48));
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\IH.gif", collisionBoxes);
                            break;
                        case "IV":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 48));
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\IV.gif", collisionBoxes);
                            break;

                        #endregion

                        #region Mounted spikes (vert. surf.)

                        case "M1":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(24, 0), 24, 48));
                            lvlMap[y, x] = new Enemy(new PointF(x * 48, y * 48), "Graphics\\M1.gif", collisionBoxes);
                            break;
                        case "M3":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 24, 48));
                            lvlMap[y, x] = new Enemy(new PointF(x * 48, y * 48), "Graphics\\M3.gif", collisionBoxes);
                            break;
                        case "M4":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(24, 0), 24, 48));
                            lvlMap[y, x] = new Enemy(new PointF(x * 48, y * 48), "Graphics\\M4.gif", collisionBoxes);
                            break;
                        case "M6":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 24, 48));
                            lvlMap[y, x] = new Enemy(new PointF(x * 48, y * 48), "Graphics\\M6.gif", collisionBoxes);
                            break;
                        case "M7":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(24, 0), 24, 48));
                            lvlMap[y, x] = new Enemy(new PointF(x * 48, y * 48), "Graphics\\M7.gif", collisionBoxes);
                            break;
                        case "M9":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 24, 48));
                            lvlMap[y, x] = new Enemy(new PointF(x * 48, y * 48), "Graphics\\M9.gif", collisionBoxes);
                            break;
                        case "KL":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(24, 0), 24, 48));
                            lvlMap[y, x] = new Enemy(new PointF(x * 48, y * 48), "Graphics\\KL.gif", collisionBoxes);
                            break;
                        case "KR":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 24), 24, 48));
                            lvlMap[y, x] = new Enemy(new PointF(x * 48, y * 48), "Graphics\\KR.gif", collisionBoxes);
                            break;

                        #endregion

                        #region Nub-corners

                        case "N1":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 48));
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\N1.gif", collisionBoxes);
                            break;
                        case "N3":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 48));
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\N3.gif", collisionBoxes);
                            break;
                        case "N7":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 48));
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\N7.gif", collisionBoxes);
                            break;
                        case "N9":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 48));
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\N9.gif", collisionBoxes);
                            break;

                        #endregion

                        #region Platforms

                        case "VB5":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 144));
                            lvlMap[y, x] = new MovableBlock(100, 2, 3, new PointF(x * 48, y * 48), "Graphics\\VB.gif", collisionBoxes);
                            break;
                        case "VB7":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 144));
                            lvlMap[y, x] = new MovableBlock(100, 2, 5, new PointF(x * 48, y * 48), "Graphics\\VB.gif", collisionBoxes);
                            break;
                        case "VB9":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 144));
                            lvlMap[y, x] = new MovableBlock(100, 2, 6, new PointF(x * 48, y * 48), "Graphics\\VB.gif", collisionBoxes);
                            break;
                        case "VB11":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 144));
                            lvlMap[y, x] = new MovableBlock(100, 2, 8, new PointF(x * 48, y * 48), "Graphics\\VB.gif", collisionBoxes);
                            break;
                        case "HB5":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 144, 48));
                            lvlMap[y, x] = new MovableBlock(100, 4, 5, new PointF(x * 48, y * 48), "Graphics\\HB.gif", collisionBoxes);
                            break;
                        case "HB9":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 144, 48));
                            lvlMap[y, x] = new MovableBlock(100, 4, 6, new PointF(x * 48, y * 48), "Graphics\\HB.gif", collisionBoxes);
                            break;
                        case "HB11":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 144, 48));
                            lvlMap[y, x] = new MovableBlock(100, 4, 8, new PointF(x * 48, y * 48), "Graphics\\HB.gif", collisionBoxes);
                            break;
                        case "HB12":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 144, 48));
                            lvlMap[y, x] = new MovableBlock(100, 4, 10, new PointF(x * 48, y * 48), "Graphics\\HB.gif", collisionBoxes);
                            break;
                        case "HB16":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 144, 48));
                            lvlMap[y, x] = new MovableBlock(100, 4, 13, new PointF(x * 48, y * 48), "Graphics\\HB.gif", collisionBoxes);
                            break;
                        case "VM5":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 96));
                            lvlMap[y, x] = new MovableBlock(80, 2, 3, new PointF(x * 48, y * 48), "Graphics\\VM.gif", collisionBoxes);
                            break;
                        case "VM6":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 96));
                            lvlMap[y, x] = new MovableBlock(100, 2, 5, new PointF(x * 48, y * 48), "Graphics\\VM.gif", collisionBoxes);
                            break;
                        case "VM7":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 96));
                            lvlMap[y, x] = new MovableBlock(100, 2, 6, new PointF(x * 48, y * 48), "Graphics\\VM.gif", collisionBoxes);
                            break;
                        case "HM3":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 96, 48));
                            lvlMap[y, x] = new MovableBlock(100, 4, 2, new PointF(x * 48, y * 48), "Graphics\\HM.gif", collisionBoxes);
                            break;
                        case "HM4":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 96, 48));
                            lvlMap[y, x] = new MovableBlock(100, 4, 3, new PointF(x * 48, y * 48), "Graphics\\HM.gif", collisionBoxes);
                            break;
                        case "HM5":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 96, 48));
                            lvlMap[y, x] = new MovableBlock(100, 4, 4, new PointF(x * 48, y * 48), "Graphics\\HM.gif", collisionBoxes);
                            break;
                        case "HM7":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 96, 48));
                            lvlMap[y, x] = new MovableBlock(100, 4, 5, new PointF(x * 48, y * 48), "Graphics\\HM.gif", collisionBoxes);
                            break;
                        case "PS4":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 48));
                            lvlMap[y, x] = new MovableBlock(100, 2, 3, new PointF(x * 48, y * 48), "Graphics\\PS.gif", collisionBoxes);
                            break;
                        case "CP":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 144, 48));
                            lvlMap[y, x] = new CrumblingBlock(new PointF(x * 48, y * 48), "Graphics\\CP.gif;Graphics\\CC.gif", collisionBoxes);
                            break;

                        #endregion

                        #region Player

                        case "PL":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 96, 96));
                            lvlMap[y, x] = new Dash(400, new PointF(x * 48, y * 48), "Graphics\\PL.gif;Graphics\\PL.gif;Graphics\\PD.gif;Graphics\\PB.gif;Graphics\\PB.gif", collisionBoxes);
                            break;
                        #endregion

                        #region Rivet-blocks

                        case "R1":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 48));
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\R1.gif", collisionBoxes);
                            break;
                        case "R2":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 48));
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\R2.gif", collisionBoxes);
                            break;
                        case "R3":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 48));
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\R3.gif", collisionBoxes);
                            break;
                        case "R4":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 48));
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\R4.gif", collisionBoxes);
                            break;
                        case "R5":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 48));
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\R5.gif", collisionBoxes);
                            break;
                        case "R6":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 48));
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\R6.gif", collisionBoxes);
                            break;
                        case "R7":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 48));
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\R7.gif", collisionBoxes);
                            break;
                        case "R8":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 48));
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\R8.gif", collisionBoxes);
                            break;
                        case "R9":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 48));
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\R9.gif", collisionBoxes);
                            break;

                        #endregion

                        #region Solid half-tiles and dec. full-tiles

                        case "S1":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 24, 48));
                            collisionBoxes.Add(new Rect(new PointF(0, 24), 48, 24));
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\S1.gif", collisionBoxes);
                            break;
                        case "S3":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(24, 0), 24, 48));
                            collisionBoxes.Add(new Rect(new PointF(0, 24), 48, 24));
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\S3.gif", collisionBoxes);
                            break;
                        case "S7":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 24));
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 24, 48));
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\S7.gif", collisionBoxes);
                            break;
                        case "S9":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 24));
                            collisionBoxes.Add(new Rect(new PointF(24, 0), 24, 48));
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\S9.gif", collisionBoxes);
                            break;
                        case "SB":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 24), 48, 24));
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\SB.gif", collisionBoxes);
                            break;
                        case "SG":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 48));
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\SG.gif", collisionBoxes);
                            break;
                        case "SH":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 48));
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\SH.gif", collisionBoxes);
                            break;
                        case "SL":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 24, 48));
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\SL.gif", collisionBoxes);
                            break;
                        case "SP":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 48));
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\SP.gif", collisionBoxes);
                            break;
                        case "SR":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(24, 0), 24, 48));
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\SR.gif", collisionBoxes);
                            break;
                        case "ST":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 24));
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\ST.gif", collisionBoxes);
                            break;
                        case "SV":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 48));
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\SV.gif", collisionBoxes);
                            break;

                        #endregion

                        #region U-shaped blocks

                        case "U2":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 48));
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\U2.gif", collisionBoxes);
                            break;
                        case "U4":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 48));
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\U4.gif", collisionBoxes);
                            break;
                        case "U6":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 48));
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\U6.gif", collisionBoxes);
                            break;
                        case "U8":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 48));
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\U8.gif", collisionBoxes);
                            break;

                        #endregion

                        #region Walkways

                        case "W7":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 48));
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\W7.gif", collisionBoxes);
                            break;
                        case "W8":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 48));
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\W8.gif", collisionBoxes);
                            break;
                        case "W9":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 48));
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\W9.gif", collisionBoxes);
                            break;
                        case "WB":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 24), 48, 24));
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\WB.gif", collisionBoxes);
                            break;

                        #endregion

                        #region X-marked blocks

                        case "X1":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 48));
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\X1.gif", collisionBoxes);
                            break;
                        case "X3":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 48));
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\X3.gif", collisionBoxes);
                            break;
                        case "X7":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 48));
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\X7.gif", collisionBoxes);
                            break;
                        case "X9":
                            collisionBoxes = new List<Rect>();
                            collisionBoxes.Add(new Rect(new PointF(0, 0), 48, 48));
                            lvlMap[y, x] = new GridBlock(new PointF(x * 48, y * 48), "Graphics\\X9.gif", collisionBoxes);
                            break;

                        #endregion

                        default:
                            lvlMap[y, x] = null;
                            break;
                    }
                    x++;
                }
                y++;
            }

            return lvlMap;
        }
    }
}
