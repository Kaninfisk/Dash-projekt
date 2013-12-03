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
                         "NN;NN;NN;R5;NN;NN;E4;R5;E6;NN;NN;NN;NN;E4;R5;R5;R5;R5" + "_" +
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

        public Level(int level, int time)
        {
            this.time = time;
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
                    switch (s2)
                    {
                        case "B1":
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\B1.gif");
                            break;
                        case "B2":
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\B2.gif");
                            break;
                        case "B3":
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\B3.gif");
                            break;
                        case "B4":
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\B4.gif");
                            break;
                        case "BB":
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\BB.gif");
                            break;
                        case "BL":
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\BL.gif");
                            break;
                        case "BR":
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\BR.gif");
                            break;
                        case "BT":
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\BT.gif");
                            break;
                        case "E1":
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\E1.gif");
                            break;
                        case "E2":
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\E2.gif");
                            break;
                        case "E3":
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\E3.gif");
                            break;
                        case "E4":
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\E4.gif");
                            break;
                        case "E6":
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\E6.gif");
                            break;
                        case "E7":
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\E7.gif");
                            break;
                        case "E8":
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\E8.gif");
                            break;
                        case "E9":
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\E9.gif");
                            break;
                        case "R5":
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\R5.gif");
                            break;
                        case "PL":
                            lvlMap[y, x] = new Dash(400, 100, 200, "Captain Dash", new PointF(x * 48, y * 48), "Graphics\\PL.gif");
                            break;
                        case "ST":
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\ST.gif");
                            break;
                        case "SF":
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "img2.jpg");
                            break;
                        case "SB":
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\SB.gif");
                            break;
                        case "SL":
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\SL.gif");
                            break;
                        case "SR":
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\SR.gif");
                            break;
                        case "W7":
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\W7.gif");
                            break;
                        case "W8":
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\W8.gif");
                            break;
                        case "W9":
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\W9.gif");
                            break;
                        case "WB":
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "Graphics\\WB.gif");
                            break;
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
