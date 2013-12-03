using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dash
{
    class Level
    {
        private int type;
        public GameObject[,] levelMap;
        private GameObject[,] backgroundMap;
        private int time;
        private int gravity;

        public int Type
        {
            get { return type; }
        }

        public void CreateLevel(int level)
        {
            string lm = "";
            string bm = "";

            switch (level)
            {
                case 1:
                    time = 999;
                    #region Level1
                    lm = "R5;R5;R5;R5;R5;R5;R5;R5;R5;R5;R5;R5;R5;R5;R5;R5;R5;R5" + "_" +
                         "R5;R5;N7;E2;E2;E2;E2;E2;E2;E2;E2;E2;E2;E2;E2;E2;E2;E2" + "_" +
                         "R5;R5;E6;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "R5;R5;E6;NN;NN;NN;NN;NN;PL;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "R5;R5;E6;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "R5;R5;E6;NN;NN;NN;W7;W8;W8;W8;W8;W8;W8;W9;NN;NN;NN;SR" + "_" +
                         "R5;R5;E6;NN;NN;NN;E4;R5;R5;R5;R5;R5;R5;E6;NN;NN;NN;SR" + "_" +
                         "R5;R5;E6;NN;NN;NN;E4;R5;N7;E2;E2;E2;E2;E3;NN;NN;NN;SR" + "_" +
                         "R5;R5;E6;NN;NN;NN;E4;R5;E6;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "R5;R5;E6;NN;NN;NN;E4;R5;E6;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "E2;E2;E3;NN;NN;NN;E4;R5;E6;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "NN;NN;NN;NN;NN;NN;E4;R5;E6;NN;NN;NN;NN;W7;W8;W8;W8;W8" + "_" +
                         "NN;NN;NN;NN;NN;NN;E4;R5;E6;NN;NN;NN;NN;E4;R5;R5;R5;R5" + "_" +
                         "WB;WB;WB;WB;WB;WB;E4;R5;E6;NN;NN;NN;NN;E4;R5;R5;R5;R5";

                    bm = "NN;NN;NN;NN;BB;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;BB" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN";
                    #endregion
                    break;
                case 2:
                    time = 999;
                    #region Level2
                    lm = "ST;ST;ST;ST;ST;ST;E4;R5;E6;NN;NN;NN;NN;E4;R5;R5;R5;R5" + "_" +
                         "NN;NN;NN;NN;NN;NN;E4;R5;E6;NN;NN;NN;NN;E4;R5;R5;R5;R5" + "_" +
                         "NN;NN;NN;NN;NN;NN;E4;R5;E6;NN;NN;NN;NN;E1;E2;E2;E2;E2" + "_" +
                         "W7;W8;W9;NN;NN;NN;E4;R5;E6;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "R5;R5;E6;NN;NN;NN;E4;R5;E6;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "E2;E2;E3;NN;NN;NN;E4;R5;E6;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;E4;R5;E6;W8;W8;W8;W8;W9;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;E4;R5;R5;R5;R5;R5;R5;E6;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;E1;E2;E2;E2;E2;E2;E2;E3;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;H12;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;E7;E8;E8;E8" + "_" +
                         "SL;F7;F8;F8;F8;F8;F8;F8;F8;F8;F8;F8;F8;F9;E4;R5;R5;R5";

                    bm = "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN";
                    #endregion
                    break;
                case 3:
                    time = 999;
                    #region Level3
                    lm = "S7;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;W7;W8;W8;W8;W8;W9" + "_" +
                         "SL;NN;NN;NN;F7;F8;F8;F8;F9;NN;NN;NN;E4;R5;R5;R5;R5;E6" + "_" +
                         "SL;NN;NN;NN;E4;R5;R5;R5;E6;NN;NN;NN;E1;E2;E2;E2;E2;E3" + "_" +
                         "SL;NN;NN;NN;E4;R5;R5;R5;E6;NN;NN;NN;NN;NN;NN;NN;NN;SL" + "_" +
                         "SL;NN;NN;NN;E4;R5;R5;R5;E6;NN;NN;NN;NN;NN;NN;NN;NN;SL" + "_" +
                         "SL;NN;NN;NN;E4;R5;R5;R5;E6;NN;NN;NN;NN;NN;NN;NN;NN;SL" + "_" +
                         "SL;NN;NN;NN;E1;E2;E2;E2;E3;NN;NN;NN;NN;NN;NN;NN;NN;SL" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SL" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SL" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;H9;NN;NN;NN;NN;NN;NN;NN;NN;SL" + "_" +
                         "F7;F8;F8;F8;F8;F8;F8;F8;F8;F8;F8;F8;F8;F8;F8;F8;F8;F9";

                    bm = "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN";
                    #endregion
                    break;
                case 4:
                    time = 999;
                    #region Level4
                    lm = "S7;ST;ST;F1;F2;F3;R5;R5;M9;NN;NN;ST;ST;ST;ST;ST;ST;S9" + "_" +
                         "SL;NN;NN;NN;NN;NN;R5;R5;M6;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;R5;R5;M3;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;R5;R5;R5;R5;R5;R5;R5;R5;R5;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;R5;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;R5;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;R5;R5;R5;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;HT;HT;HT;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;WT;WT;SF" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;E7;E9;NN;NN;NN;NN;NN;NN" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;E4;E6;NN;NN;NN;NN;NN;NN" + "_" +
                         "W7;W8;W8;W8;W8;W9;NN;NN;NN;NN;E4;E6;NN;NN;NN;NN;NN;NN" + "_" +
                         "E1;E2;E2;E2;E2;E3;F7;F8;F8;F9;E1;E3;R5;R5;R5;R5;R5;R5";

                    bm = "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN";
                    #endregion
                    break;
                case 5:
                    time = 999;
                    #region Level5
                    lm = "S5;ST;ST;HT;HT;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;HR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;HR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;HR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;HR" + "_" +
                         "SL;NN;NN;HB;HB;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;HR" + "_" +
                         "SL;NN;NN;R5;R5;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;R5;R5;NN;NN;NN;NN;6U;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;R5;R5;NN;NN;NN;NN;PM;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;R5;R5;NN;NN;NN;NN;5D;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;R5;R5;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "NN;NN;NN;R5;R5;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "NN;NN;NN;R5;R5;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "NN;NN;NN;R5;R5;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "R5;R5;R5;R5;R5;R5;R5;R5;R5;R5;R5;R5;R5;R5;R5;R5;R5;R5";

                    bm = "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN";
                    #endregion
                    break;
                case 6:
                    time = 999;
                    #region Level6
                    lm = "ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;S6" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;2U;NN;NN;NN;NN;NN;SR" + "_" +
                         "R5;R5;R5;R5;R5;R5;R5;R5;NN;NN;NN;PM;NN;NN;NN;HH;HH;HH" + "_" +
                         "R5;R5;R5;R5;R5;R5;R5;R5;NN;NN;NN;2D;NN;NN;NN;NN;NN;SR" + "_" +
                         "R5;R5;R5;R5;R5;R5;R5;R5;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;HV;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;HV;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;HV;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;R5;R5;R5;R5;R5;R5;R5;R5;R5;R5;R5;R5;NN;NN;SR" + "_" +
                         "SL;NN;NN;R5;R5;R5;R5;R5;R5;R5;R5;R5;R5;R5;R5;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "S8;SB;SB;SB;SB;SB;SB;SB;SB;SB;SB;SB;SB;SB;SB;SB;SB;SB";

                    bm = "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN";

                    #endregion
                    break;
                case 7:
                    time = 999;
                    #region Level7
                    lm = "ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;S6" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "R5;R5;R5;R5;R5;R5;R5;R5;R5;R5;R5;R5;R5;R5;R5;NN;NN;SR" + "_" +
                         "R5;R5;R5;R5;R5;R5;R5;R5;R5;R5;R5;R5;R5;R5;R5;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "SL;NN;NN;NN;HH;HH;HH;HH;HH;R5;R5;R5;R5;R5;R5;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;DV;NN;NN;NN;NN;NN;NN;BR;R5;R5;R5;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;R5;R5;R5;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;3L;PM;3R;NN;NN;R5;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "HB;HB;HB;HB;HB;HB;HB;HB;R5;SB;SB;SB;SB;SB;SB;SB;SB;S7";

                    bm = "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN";
                    #endregion
                    break;
                case 8:
                    time = 999;
                    #region Level8
                    lm = "HL;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;R5;ST;ST;ST;S6" + "_" +
                         "HL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;DV;NN;NN;NN;SR" + "_" +
                         "HL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;DV;NN;NN;BR;SR" + "_" +
                         "HL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;DV;NN;NN;NN;SR" + "_" +
                         "HL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;R5;R5;R5;R5;R5" + "_" +
                         "NN;NN;NN;NN;5U;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "NN;NN;NN;NN;PM;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;BR;SR" + "_" +
                         "NN;NN;NN;NN;5D;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "R5;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "HL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;R5;R5;R5;R5;R5" + "_" +
                         "HL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;DV;NN;NN;NN;SR" + "_" +
                         "HL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;DV;NN;NN;NN;SR" + "_" +
                         "HL;NN;NN;NN;NN;5L;PM;6R;NN;NN;NN;NN;NN;DV;NN;NN;NN;SR" + "_" +
                         "HH;HB;HB;HB;HB;HB;HB;HB;HB;HB;HB;HB;HB;R5;NN;NN;NN;SR";

                    bm = "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN";
                    #endregion
                    break;
                case 9:
                    time = 999;
                    #region Level9
                    lm = "S5;ST;ST;ST;ST;ST;ST;ST;ST;ST;NN;NN;NN;R5;ST;ST;ST;ST" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;R5;NN;NN;NN;NN" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;R5;NN;NN;NN;NN" + "_" +
                         "SL;NN;NN;NN;HB;HB;HB;HB;HB;HB;HB;R5;R5;R5;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;R5;R5;R5;R5;R5;R5;R5;R5;R5;R5;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;R5;R5;R5;R5;R5;R5;R5;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;R5;R5;R5;R5;R5;R5;R5;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;R5;R5;R5;R5;R5;R5;R5;NN;NN;NN;SR" + "_" +
                         "HB;HB;HB;NN;NN;NN;NN;R5;R5;R5;R5;R5;R5;R5;3U;NN;NN;SR" + "_" +
                         "R5;R5;R5;NN;NN;NN;NN;R5;R5;R5;R5;R5;R5;R5;PM;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;3D;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "R5;R5;HB;HB;HB;HB;HB;HB;HB;HB;HB;HB;HB;HB;HB;HB;R5;R5";

                    bm = "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN";
                    #endregion
                    break;
                case 10:
                    time = 999;
                    #region Level10
                    lm = "R5;R5;R5;R5;R5;R5;ST;ST;ST;ST;ST;R5;R5;R5;R5;R5;R5;R5" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "R5;R5;R5;R5;R5;R5;R5;NN;NN;NN;NN;R5;R5;R5;R5;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;3L;PM;3R;NN;NN;HV;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;HV;2U;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;HV;PM;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;HV;2D;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "NN;NN;NN;3L;PM;3R;NN;NN;HV;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "HB;HB;HB;HB;HB;HB;HB;HB;HV;SB;SB;SB;SB;SB;SB;SB;SB;S7";

                    bm = "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN";
                    #endregion
                    break;
                case 11:
                    time = 999;
                    #region Level11
                    lm = "ST;ST;ST;ST;ST;ST;R5;R5;ST;ST;ST;ST;ST;ST;ST;ST;ST;S6" + "_" +
                         "NN;NN;NN;NN;NN;NN;R5;R5;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "NN;NN;NN;NN;NN;NN;R5;R5;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "R5;R5;R5;NN;NN;NN;R5;R5;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "R5;R5;R5;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;HH;HH;HH;NN;NN;NN;NN" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;7L;PM;8R;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "HB;HB;HB;HB;HB;HB;HB;HB;HB;HB;HB;HB;HB;HB;HB;HB;HB;HB";

                    bm = "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN";
                    #endregion
                    break;
                case 12:
                    time = 999;
                    #region Level12
                    lm = "S5;ST;ST;ST;ST;ST;ST;ST;ST;ST;NN;NN;NN;ST;ST;ST;ST;HR" + "_" +
                         "SL;BT;NN;NN;NN;NN;NN;NN;NN;NN;DH;DH;DH;NN;NN;NN;NN;HR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;DH;DH;DH;NN;NN;NN;NN;HR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;HR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;HR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;5U;HR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;PM;HR" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;5D;HR" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;HR" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;HR" + "_" +
                         "R5;R5;R5;R5;R5;R5;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;HR" + "_" +
                         "R5;R5;R5;R5;R5;R5;BL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;HR" + "_" +
                         "R5;R5;R5;R5;R5;R5;NN;NN;NN;NN;5L;PM;5R;NN;NN;NN;NN;HR" + "_" +
                         "R5;R5;R5;R5;R5;R5;HB;HB;HB;HB;HB;HB;HB;HB;HB;HB;HB;HB";

                    bm = "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN";
                    #endregion
                    break;
                case 13:
                    time = 999;
                    #region Level13
                    lm = "S5;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;NN;NN;NN;S6" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;8L;PM;7R;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;HB;HB;HB;HB;HB;HB;HB;HB;HB;HB;HB;HB;HB;SR" + "_" +
                         "SL;NN;NN;NN;R5;R5;R5;R5;R5;R5;R5;R5;R5;R5;R5;R5;R5;R5" + "_" +
                         "SL;NN;NN;NN;R5;R5;R5;R5;R5;R5;R5;R5;R5;R5;R5;R5;R5;R5" + "_" +
                         "SL;NN;NN;NN;R5;R5;NN;NN;NN;NN;NN;NN;NN;NN;R5;R5;R5;R5" + "_" +
                         "SL;NN;NN;NN;R5;R5;NN;NN;NN;NN;NN;NN;NN;NN;R5;R5;R5;R5" + "_" +
                         "SL;NN;NN;NN;R5;R5;NN;NN;NN;NN;NN;NN;NN;NN;R5;R5;R5;R5" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;R5;R5;NN;NN;NN;R5;R5;R5;R5" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;R5;R5;NN;NN;NN;R5;R5;R5;R5" + "_" +
                         "S8;SB;SB;SB;SB;SB;SB;SB;SB;R5;R5;NN;NN;NN;R5;R5;R5;R5";

                    bm = "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN";
                    #endregion
                    break;
                case 14:
                    time = 999;
                    #region Level14
                    lm = "S5;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;S6" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;R5;R5;R5;R5;NN;NN;NN;NN;NN;NN;R5;R5;NN;NN;SR" + "_" +
                         "SL;NN;NN;R5;R5;R5;R5;NN;NN;NN;NN;NN;NN;R5;R5;NN;NN;SR" + "_" +
                         "SL;NN;NN;R5;R5;R5;R5;NN;NN;NN;NN;NN;NN;R5;R5;NN;NN;SR" + "_" +
                         "SL;NN;NN;HT;HT;HT;HT;NN;NN;NN;NN;NN;NN;R5;R5;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;3U;NN;NN;NN;NN;NN;R5;R5;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;PM;NN;NN;NN;NN;NN;R5;R5;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;3D;NN;NN;NN;NN;NN;R5;R5;NN;NN;SR" + "_" +
                         "SL;NN;NN;HB;HB;HB;HB;NN;NN;NN;NN;NN;NN;R5;R5;NN;NN;SR" + "_" +
                         "SL;NN;NN;R5;R5;R5;R5;NN;NN;NN;NN;NN;NN;R5;R5;NN;NN;SR" + "_" +
                         "HB;HB;HB;R5;R5;R5;R5;SB;SB;SB;NN;NN;NN;R5;R5;NN;NN;SR";

                    bm = "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN";
                    #endregion
                    break;
                case 15:
                    time = 999;
                    #region Level15
                    lm = "HT;HT;HT;ST;ST;ST;HT;HT;HT;HT;NN;NN;NN;ST;ST;ST;ST;S6" + "_" +
                         "HL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "HL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "HL;NN;NN;NN;NN;NN;NN;NN;NN;NN;R5;R5;R5;R5;NN;NN;NN;SR" + "_" +
                         "HL;NN;NN;NN;NN;NN;NN;NN;NN;NN;R5;R5;R5;R5;NN;NN;NN;SR" + "_" +
                         "HB;HB;HB;NN;NN;NN;NN;NN;NN;NN;HT;HT;HT;HT;NN;NN;NN;SR" + "_" +
                         "R5;R5;R5;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;R5;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;R5;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;R5;R5;R5;R5" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;HR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;HR" + "_" +
                         "SL;NN;2L;PM;2R;NN;R5;R5;NN;NN;NN;NN;NN;NN;NN;NN;NN;HR" + "_" +
                         "HB;HB;HB;HB;HB;HB;R5;R5;NN;NN;NN;HB;HB;HB;HB;HB;HB;HB";

                    bm = "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN";
                    #endregion
                    break;
                case 16:
                    time = 999;
                    #region Level16
                    lm = "S5;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;S6" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;R5;R5;R5" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;4U;NN;NN;NN;NN;NN;NN;R5;R5;R5" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;PM;NN;NN;NN;NN;NN;NN;R5;R5;R5" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;4D;NN;NN;NN;NN;NN;NN;NN;NN;HR" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;HR" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;HR" + "_" +
                         "R5;R5;R5;R5;R5;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;HR" + "_" +
                         "R5;R5;R5;R5;R5;NN;NN;NN;NN;NN;6L;PM;5R;NN;NN;NN;NN;SR" + "_" +
                         "R5;R5;R5;R5;R5;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "R5;R5;R5;R5;R5;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "R5;R5;R5;R5;R5;HB;HB;HB;HB;HB;HB;HB;HB;NN;NN;NN;NN;S7";

                    bm = "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN";
                    #endregion
                    break;
                case 17:
                    time = 999;
                    #region Level17
                    lm = "S5;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;S6" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR;NN;NN;SR" + "_" +
                         "SL;NN;NN;S5;ST;ST;HT;HT;ST;ST;ST;S4;NN;NN;SR;NN;NN;SR" + "_" +
                         "SL;NN;NN;SL;NN;NN;NN;NN;NN;NN;NN;SL;NN;NN;SR;NN;NN;DV" + "_" +
                         "SL;NN;NN;SL;NN;NN;NN;NN;NN;NN;BR;SL;NN;NN;SR;NN;NN;DV" + "_" +
                         "SL;NN;NN;SL;NN;NN;NN;NN;NN;NN;NN;SL;NN;NN;SR;NN;NN;DV" + "_" +
                         "SL;NN;NN;SL;NN;NN;HB;HB;SB;SB;SB;S1;NN;NN;SR;NN;NN;SR" + "_" +
                         "SL;NN;NN;SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR;NN;NN;SR" + "_" +
                         "SL;NN;NN;SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR;NN;NN;SR" + "_" +
                         "SL;NN;NN;S8;SB;SB;SB;SB;SB;SB;SB;SB;SB;SB;S7;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "S8;SB;SB;SB;SB;SB;SB;SB;SB;SB;SB;SB;SB;SB;SB;SB;SB;S7";

                    bm = "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN";
                    #endregion
                    break;
                case 18:
                    time = 999;
                    #region Level18
                    lm = "S5;ST;ST;ST;ST;R5;ST;ST;ST;ST;ST;R5;ST;ST;ST;ST;ST;S6" + "_" +
                         "SL;NN;NN;NN;NN;SR;NN;NN;NN;NN;NN;SR;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;SR;NN;NN;NN;NN;NN;SR;BL;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;SR;NN;NN;NN;NN;NN;SR;NN;NN;NN;NN;NN;SR" + "_" +
                         "NN;NN;SR;NN;NN;NN;NN;NN;SR;NN;NN;NN;NN;NN;SR;NN;NN;SR" + "_" +
                         "NN;NN;SR;NN;NN;NN;NN;NN;SR;NN;NN;NN;NN;NN;SR;NN;NN;SR" + "_" +
                         "NN;NN;SR;NN;NN;NN;NN;NN;SR;NN;NN;NN;NN;NN;SR;NN;NN;SR" + "_" +
                         "DH;DH;DH;R5;R5;R5;R5;R5;R5;R5;R5;R5;R5;R5;R5;NN;NN;SR" + "_" +
                         "SL;NN;SR;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR;NN;NN;SR" + "_" +
                         "SL;NN;SR;NN;NN;2U;NN;2U;NN;2U;NN;NN;NN;NN;SR;NN;NN;SR" + "_" +
                         "NN;NN;NN;NN;NN;PM;NN;PM;NN;PM;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "NN;NN;NN;NN;NN;2D;NN;2D;NN;2D;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "HB;HB;HB;HB;HB;HB;HB;HB;HB;HB;HB;HB;HB;HB;HB;HB;HB;HB";

                    bm = "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN";
                    #endregion
                    break;
                case 19:
                    time = 999;
                    #region Level19
                    lm = "HL;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;S6" + "_" +
                         "HL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "HL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "HL;3U;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;R5;R5;NN;NN;SR" + "_" +
                         "HL;PM;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;R5;R5;NN;NN;SR" + "_" +
                         "HL;3D;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;3U;R5;R5;NN;NN;SR" + "_" +
                         "HL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;PM;R5;R5;NN;NN;SR" + "_" +
                         "HL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;3D;R5;R5;NN;NN;SR" + "_" +
                         "R5;R5;R5;R5;R5;NN;NN;NN;NN;NN;NN;NN;NN;R5;R5;NN;NN;SR" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;PC;PC;PC;NN;R5;R5;NN;NN;SR" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR;NN;NN;NN" + "_" +
                         "SL;NN;NN;PC;PC;PC;NN;NN;NN;NN;NN;NN;NN;NN;SR;NN;NN;NN" + "_" +
                         "HB;HB;HB;HB;HB;HB;HB;HB;HB;HB;HB;HB;R5;R5;R5;SB;SB;SB";

                    bm = "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN";
                    #endregion
                    break;
                case 20:
                    time = 999;
                    #region Level20
                    lm = "S5;ST;ST;ST;ST;ST;R5;ST;ST;R5;ST;ST;ST;ST;ST;ST;ST;S6" + "_" +
                         "SL;NN;NN;NN;NN;BT;SR;NN;NN;DV;NN;NN;SR;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;2L;PM;2R;NN;SR;NN;NN;DV;NN;NN;SR;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;2L;PM;2R;NN;SR;NN;NN;DV;NN;NN;NN;NN;NN;SL;NN;SR" + "_" +
                         "SL;NN;NN;HB;R5;R5;R5;NN;NN;DV;NN;NN;NN;NN;NN;SL;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;PC;PC;R5;ST;ST;ST;ST;ST;S1;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;SR;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;SR;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "DH;DH;DH;ST;ST;ST;ST;ST;ST;R5;NN;NN;S5;ST;ST;ST;ST;ST" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;HR;R5;NN;NN;SL;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;2U;HR;R5;NN;NN;SL;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;PM;HR;R5;NN;NN;NN;NN;NN;R5;R5;R5" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;1D;HR;R5;NN;NN;NN;NN;NN;R5;R5;R5" + "_" +
                         "S8;SB;SB;SB;SB;SB;SB;SB;SB;R5;SB;SB;SB;SB;SB;R5;R5;R5";

                    bm = "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN";
                    #endregion
                    break;
            }

            this.levelMap = CreateMap(lm);
            this.backgroundMap = CreateMap(bm);

        }

        public GameObject[,] LevelMap
        {
            get { return levelMap; }
            set { levelMap = value; }
        }

        public GameObject[,] BackgroundMap
        {
            get { return backgroundMap; }
        }

        public int Time
        {
            get { return time; }
        }

        public int Gravity
        {
            get { return gravity; }
        }

        public Level(int level)
        {
            CreateLevel(level);
        }

        public GameObject[,] CreateMap(string map)
        {
            string[] temp = map.Split('_');

            GameObject[,] lvlMap = new GameObject[temp.Length, temp[0].Split(';').Length];

            int y = 0;
            foreach (string s1 in temp)
            {
                int x = 0;
                foreach (string s2 in s1.Split(';'))
                {
                    List<RectangleF> collisionBoxes = new List<RectangleF>();
                    switch (s2)
                    {
                        case "OO":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "img2.jpg", collisionBoxes);
                            break;
                        #region Buttons
                        case "B1":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48,48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\B1.gif",collisionBoxes);
                            break;
                        case "B2":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48,48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\B2.gif",collisionBoxes);
                            break;
                        case "B3":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48,48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\B3.gif", collisionBoxes);
                            break;
                        case "B4":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48,48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\B4.gif", collisionBoxes);
                            break;
                        case "BB":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48,48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\BB.gif", collisionBoxes);
                            break;
                        case "BL":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48,48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\BL.gif", collisionBoxes);
                            break;
                        case "BR":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48,48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\BR.gif", collisionBoxes);
                            break;
                        case "BT":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48,48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\BT.gif", collisionBoxes);
                            break;
                        #endregion
                        #region Corners (half-tile)
                        case "C1":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\C1.gif", collisionBoxes);
                            break;
                        case "C3":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\C3.gif", collisionBoxes);
                            break;
                        case "C7":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\C7.gif", collisionBoxes);
                            break;
                        case "C9":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\C9.gif", collisionBoxes);
                            break;
                        #endregion
                        #region Doors
                        case "D1":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\D1.gif", collisionBoxes);
                            break;
                        case "D2":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\D2.gif", collisionBoxes);
                            break;
                        case "DH":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\DH.gif", collisionBoxes);
                            break;
                        case "DV":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\DV.gif", collisionBoxes);
                            break;
                        #endregion
                        #region Edges
                        case "E1":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48,48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\E1.gif", collisionBoxes);
                            break;
                        case "E2":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48,48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\E2.gif", collisionBoxes);
                            break;
                        case "E3":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48,48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\E3.gif", collisionBoxes);
                            break;
                        case "E4":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48,48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\E4.gif", collisionBoxes);
                            break;
                        case "E6":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48,48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\E6.gif", collisionBoxes);
                            break;
                        case "E7":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48,48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\E7.gif", collisionBoxes);
                            break;
                        case "E8":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48,48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\E8.gif", collisionBoxes);
                            break;
                        case "E9":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48,48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\E9.gif", collisionBoxes);
                            break;
                        #endregion
                        #region Floor/Ceiling spikes (hor. surf.)
                        case "F1":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\F1.gif", collisionBoxes);
                            break;
                        case "F2":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\F2.gif", collisionBoxes);
                            break;
                        case "F3":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\F3.gif", collisionBoxes);
                            break;
                        case "F7":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\F7.gif", collisionBoxes);
                            break;
                        case "F8":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\F8.gif", collisionBoxes);
                            break;
                        case "F9":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\F9.gif", collisionBoxes);
                            break;
                        #endregion
                        #region Background tiles
                        case "G1":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\G1.gif", collisionBoxes);
                            break;
                        case "G2":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\G2.gif", collisionBoxes);
                            break;
                        case "G3":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\G3.gif", collisionBoxes);
                            break;
                        case "G4":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\G4.gif", collisionBoxes);
                            break;
                        case "G5":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\G5.gif", collisionBoxes);
                            break;
                        #endregion
                        #region Hole blocks
                        case "H1":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\H1.gif", collisionBoxes);
                            break;
                        case "H3":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\H3.gif", collisionBoxes);
                            break;
                        case "H7":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\H7.gif", collisionBoxes);
                            break;
                        case "H9":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\H9.gif", collisionBoxes);
                            break;
                        #endregion
                        #region Indented blocks
                        case "I1":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\I1.gif", collisionBoxes);
                            break;
                        case "I3":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\I3.gif", collisionBoxes);
                            break;
                        case "I7":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\I7.gif", collisionBoxes);
                            break;
                        case "I9":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\I9.gif", collisionBoxes);
                            break;
                        case "IH":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\IH.gif", collisionBoxes);
                            break;
                        case "IV":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\IH.gif", collisionBoxes);
                            break;
                        #endregion
                        #region Mounted spikes (vert. surf.)
                        case "M1":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\M1.gif", collisionBoxes);
                            break;
                        case "M3":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\M3.gif", collisionBoxes);
                            break;
                        case "M4":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\M4.gif", collisionBoxes);
                            break;
                        case "M6":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\M6.gif", collisionBoxes);
                            break;
                        case "M7":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\M7.gif", collisionBoxes);
                            break;
                        case "M9":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\M9.gif", collisionBoxes);
                            break;
                        #endregion
                        #region Nub-corners
                        case "N1":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\N1.gif", collisionBoxes);
                            break;
                        case "N3":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\N3.gif", collisionBoxes);
                            break;
                        case "N7":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\N7.gif", collisionBoxes);
                            break;
                        case "N9":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\N9.gif", collisionBoxes);
                            break;
                        #endregion
                        #region Player
                        case "PL":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 96, 96));
                            lvlMap[y, x] = new Dash(400, 100, 200, "Captain Dash", new PointF(x * 48, y * 48), "Graphics\\PL.gif", collisionBoxes);
                            break;
                        #endregion
                        #region Rivet-blocks
                        case "R1":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\R1.gif", collisionBoxes);
                            break;
                        case "R2":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\R2.gif", collisionBoxes);
                            break;
                        case "R3":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\R3.gif", collisionBoxes);
                            break;
                        case "R4":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\R4.gif", collisionBoxes);
                            break;
                        case "R5":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48,48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\R5.gif", collisionBoxes);
                            break;
                        case "R6":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\R6.gif", collisionBoxes);
                            break;
                        case "R7":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\R7.gif", collisionBoxes);
                            break;
                        case "R8":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\R8.gif", collisionBoxes);
                            break;
                        case "R9":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\R9.gif", collisionBoxes);
                            break;
                        #endregion
                        #region Solid half-tiles and dec. full-tiles
                        case "S1":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\S1.gif", collisionBoxes);
                            break;
                        case "S3":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\S3.gif", collisionBoxes);
                            break;
                        case "S7":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\S7.gif", collisionBoxes);
                            break;
                        case "S9":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\S9.gif", collisionBoxes);
                            break;
                        case "SB":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\SB.gif", collisionBoxes);
                            break;
                        case "SG":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\SG.gif", collisionBoxes);
                            break;
                        case "SH":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\SH.gif", collisionBoxes);
                            break;
                        case "SL":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\SL.gif", collisionBoxes);
                            break;
                        case "SP":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\SP.gif", collisionBoxes);
                            break;
                        case "SR":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\SR.gif", collisionBoxes);
                            break;
                        case "ST":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48,48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\ST.gif", collisionBoxes);
                            break;
                        case "SV":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\SV.gif", collisionBoxes);
                            break;
                        #endregion
                        #region U-shaped blocks
                        case "U2":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\U2.gif", collisionBoxes);
                            break;
                        case "U4":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\U4.gif", collisionBoxes);
                            break;
                        case "U6":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\U6.gif", collisionBoxes);
                            break;
                        case "U8":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\U8.gif", collisionBoxes);
                            break;
                        #endregion
                        #region Walkways
                        case "W7":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48,48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\W7.gif", collisionBoxes);
                            break;
                        case "W8":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48,48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\W8.gif", collisionBoxes);
                            break;
                        case "W9":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48,48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\W9.gif", collisionBoxes);
                            break;
                        case "WB":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48,48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\WB.gif", collisionBoxes);
                            break;
                        #endregion
                        #region X-marked blocks
                        case "X1":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\X1.gif", collisionBoxes);
                            break;
                        case "X3":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\X3.gif", collisionBoxes);
                            break;
                        case "X7":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\X7.gif", collisionBoxes);
                            break;
                        case "X9":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(x * 48, y * 48, 48, 48));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\X9.gif", collisionBoxes);
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
