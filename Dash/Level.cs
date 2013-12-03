﻿using System;
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
                    time = 10;
                    lm = "SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF" + "_" +
                         "SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF" + "_" +
                         "SF;SF;SF;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SF;SF;SF;NN;NN;NN;NN;NN;PL;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SF;SF;SF;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SF;SF;SF;NN;NN;NN;SF;SF;SF;SF;SF;SF;SF;SF;NN;NN;NN;SR" + "_" +
                         "SF;SF;SF;NN;NN;NN;SF;SF;SF;SF;SF;SF;SF;SF;NN;NN;NN;SR" + "_" +
                         "SF;SF;SF;NN;NN;NN;SF;SF;SF;SF;SF;SF;SF;SF;NN;NN;NN;SR" + "_" +
                         "SF;SF;SF;NN;NN;NN;SF;SF;SF;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SF;SF;SF;NN;NN;NN;SF;SF;SF;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SF;SF;SF;NN;NN;NN;SF;SF;SF;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "NN;NN;NN;NN;NN;NN;SF;SF;SF;NN;NN;NN;NN;SF;SF;SF;SF;SF" + "_" +
                         "NN;NN;NN;SF;NN;NN;SF;SF;SF;NN;NN;NN;NN;SF;SF;SF;SF;SF" + "_" +
                         "SB;SB;SB;SB;SB;SB;SF;SF;SF;NN;NN;NN;NN;SF;SF;SF;SF;SF";

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
                    time = 10;
                    lm = "ST;ST;ST;ST;ST;ST;SF;SF;SF;NN;NN;NN;NN;SF;SF;SF;SF;SF" + "_" +
                         "NN;NN;NN;NN;NN;NN;SF;SF;SF;NN;NN;NN;NN;SF;SF;SF;SF;SF" + "_" +
                         "NN;NN;NN;NN;NN;NN;SF;SF;SF;NN;NN;NN;NN;SF;SF;SF;SF;SF" + "_" +
                         "SF;SF;SF;NN;NN;NN;SF;SF;SF;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SF;SF;SF;NN;NN;NN;SF;SF;SF;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SF;SF;SF;NN;NN;NN;SF;SF;SF;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;SF;SF;SF;SF;SF;SF;SF;SF;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;SF;SF;SF;SF;SF;SF;SF;SF;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;SF;SF;SF;SF;SF;SF;SF;SF;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;6L;PM;6R;NN;NN;NN;NN;NN;SF;SF;SF;SF" + "_" +
                         "SL;HB;HB;HB;HB;HB;HB;HB;HB;HB;HB;HB;HB;HB;SF;SF;SF;SF";

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
                    time = 10;
                    lm = "S5;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SF;SF;SF;SF;SF;SF" + "_" +
                         "SL;NN;NN;NN;HB;HB;HB;HB;HB;NN;NN;NN;SF;SF;SF;SF;SF;SF" + "_" +
                         "SL;NN;NN;NN;SF;SF;SF;SF;SF;NN;NN;NN;SF;SF;SF;SF;SF;SF" + "_" +
                         "SL;NN;NN;NN;SF;SF;SF;SF;SF;NN;NN;NN;NN;NN;NN;NN;NN;SL" + "_" +
                         "SL;NN;NN;NN;SF;SF;SF;SF;SF;NN;NN;NN;NN;NN;NN;NN;NN;SL" + "_" +
                         "SL;NN;NN;NN;SF;SF;SF;SF;SF;NN;NN;NN;NN;NN;NN;NN;NN;SL" + "_" +
                         "SL;NN;NN;NN;SF;SF;SF;SF;SF;NN;NN;NN;NN;NN;NN;NN;NN;SL" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SL" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SL" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;4L;PM;4R;NN;NN;NN;SL" + "_" +
                         "HB;HB;HB;HB;HB;HB;HB;HB;HB;NN;NN;NN;HB;HB;HB;HB;HB;HB";

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
                    time = 10;
                    lm = "S5;ST;ST;HT;HT;HT;SF;SF;HL;NN;NN;ST;ST;ST;ST;ST;ST;S6" + "_" +
                         "SL;NN;NN;NN;NN;NN;SF;SF;HL;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;SF;SF;HL;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;SF;SF;SF;SF;SF;SF;SF;SF;SF;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SF;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SF;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;SF;SF;SF;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;HT;HT;HT;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SF;SF;SF" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;SF;SF;NN;NN;NN;NN;NN;NN" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;SF;SF;NN;NN;NN;NN;NN;NN" + "_" +
                         "SF;SF;SF;SF;SF;SF;NN;NN;NN;NN;SF;SF;NN;NN;NN;NN;NN;NN" + "_" +
                         "SF;SF;SF;SF;SF;SF;HB;HB;HB;HB;SF;SF;SF;SF;SF;SF;SF;SF";

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
                    time = 10;
                    lm = "S5;ST;ST;HT;HT;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;HR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;HR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;HR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;HR" + "_" +
                         "SL;NN;NN;HB;HB;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;HR" + "_" +
                         "SL;NN;NN;SF;SF;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;SF;SF;NN;NN;NN;NN;6U;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;SF;SF;NN;NN;NN;NN;PM;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;SF;SF;NN;NN;NN;NN;5D;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;SF;SF;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "NN;NN;NN;SF;SF;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "NN;NN;NN;SF;SF;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "NN;NN;NN;SF;SF;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF";

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
                    time = 10;
                    lm = "ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;S6" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;2U;NN;NN;NN;NN;NN;SR" + "_" +
                         "SF;SF;SF;SF;SF;SF;SF;SF;NN;NN;NN;PM;NN;NN;NN;HH;HH;HH" + "_" +
                         "SF;SF;SF;SF;SF;SF;SF;SF;NN;NN;NN;2D;NN;NN;NN;NN;NN;SR" + "_" +
                         "SF;SF;SF;SF;SF;SF;SF;SF;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;HV;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;HV;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;HV;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;NN;NN;SR" + "_" +
                         "SL;NN;NN;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;NN;NN;SR" + "_" +
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
                    time = 10;
                    lm = "ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;S6" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;NN;NN;SR" + "_" +
                         "SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" +
                         "SL;NN;NN;NN;HH;HH;HH;HH;HH;SF;SF;SF;SF;SF;SF;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;DV;NN;NN;NN;NN;NN;NN;BR;SF;SF;SF;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;DV;NN;NN;NN;NN;NN;NN;NN;SF;SF;SF;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;3L;PM;3R;NN;NN;SF;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "HB;HB;HB;HB;HB;HB;HB;HB;SF;SB;SB;SB;SB;SB;SB;SB;SB;S7";

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
                    time = 10;
                    lm = "HL;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;SF;ST;ST;ST;S6" + "_" +
                         "HL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;DV;NN;NN;NN;SR" + "_" +
                         "HL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;DV;NN;NN;BR;SR" + "_" +
                         "HL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;DV;NN;NN;NN;SR" + "_" +
                         "HL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SF;SF;SF;SF;SF" + "_" +
                         "NN;NN;NN;NN;5U;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "NN;NN;NN;NN;PM;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;BR;SR" + "_" +
                         "NN;NN;NN;NN;5D;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SF;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "HL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SF;SF;SF;SF;SF" + "_" +
                         "HL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;DV;NN;NN;NN;SR" + "_" +
                         "HL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;DV;NN;NN;NN;SR" + "_" +
                         "HL;NN;NN;NN;NN;5L;PM;6R;NN;NN;NN;NN;NN;DV;NN;NN;NN;SR" + "_" +
                         "HH;HB;HB;HB;HB;HB;HB;HB;HB;HB;HB;HB;HB;SF;NN;NN;NN;SR";

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
                    time = 10;
                    lm = "S5;ST;ST;ST;ST;ST;ST;ST;ST;ST;NN;NN;NN;SF;ST;ST;ST;ST" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SF;NN;NN;NN;NN" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SF;NN;NN;NN;NN" + "_" +
                         "SL;NN;NN;NN;HB;HB;HB;HB;HB;HB;HB;SF;SF;SF;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;SF;SF;SF;SF;SF;SF;SF;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;SF;SF;SF;SF;SF;SF;SF;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;SF;SF;SF;SF;SF;SF;SF;NN;NN;NN;SR" + "_" +
                         "HB;HB;HB;NN;NN;NN;NN;SF;SF;SF;SF;SF;SF;SF;3U;NN;NN;SR" + "_" +
                         "SF;SF;SF;NN;NN;NN;NN;SF;SF;SF;SF;SF;SF;SF;PM;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;3D;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SF;SF;HB;HB;HB;HB;HB;HB;HB;HB;HB;HB;HB;HB;HB;HB;SF;SF";

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
                    time = 10;
                    lm = "SF;SF;SF;SF;SF;SF;ST;ST;ST;ST;ST;SF;SF;SF;SF;SF;SF;SF" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SF;SF;SF;SF;SF;SF;SF;NN;NN;NN;NN;SF;SF;SF;SF;NN;NN;SR" + "_" +
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
                    time = 10;
                    lm = "ST;ST;ST;ST;ST;ST;SF;SF;ST;ST;ST;ST;ST;ST;ST;ST;ST;S6" + "_" +
                         "NN;NN;NN;NN;NN;NN;SF;SF;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "NN;NN;NN;NN;NN;NN;SF;SF;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SF;SF;SF;NN;NN;NN;SF;SF;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SF;SF;SF;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
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
                    time = 10;
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
                         "SF;SF;SF;SF;SF;SF;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;HR" + "_" +
                         "SF;SF;SF;SF;SF;SF;BL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;HR" + "_" +
                         "SF;SF;SF;SF;SF;SF;NN;NN;NN;NN;5L;PM;5R;NN;NN;NN;NN;HR" + "_" +
                         "SF;SF;SF;SF;SF;SF;HB;HB;HB;HB;HB;HB;HB;HB;HB;HB;HB;HB";

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
                    time = 10;
                    lm = "S5;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;NN;NN;NN;S6" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;8L;PM;7R;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;HB;HB;HB;HB;HB;HB;HB;HB;HB;HB;HB;HB;HB;SR" + "_" +
                         "SL;NN;NN;NN;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF" + "_" +
                         "SL;NN;NN;NN;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF" + "_" +
                         "SL;NN;NN;NN;SF;SF;NN;NN;NN;NN;NN;NN;NN;NN;SF;SF;SF;SF" + "_" +
                         "SL;NN;NN;NN;SF;SF;NN;NN;NN;NN;NN;NN;NN;NN;SF;SF;SF;SF" + "_" +
                         "SL;NN;NN;NN;SF;SF;NN;NN;NN;NN;NN;NN;NN;NN;SF;SF;SF;SF" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;SF;SF;NN;NN;NN;SF;SF;SF;SF" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;SF;SF;NN;NN;NN;SF;SF;SF;SF" + "_" +
                         "S8;SB;SB;SB;SB;SB;SB;SB;SB;SF;SF;NN;NN;NN;SF;SF;SF;SF";

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
                    time = 10;
                    lm = "S5;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;S6" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;SF;SF;SF;SF;NN;NN;NN;NN;NN;NN;SF;SF;NN;NN;SR" + "_" +
                         "SL;NN;NN;SF;SF;SF;SF;NN;NN;NN;NN;NN;NN;SF;SF;NN;NN;SR" + "_" +
                         "SL;NN;NN;SF;SF;SF;SF;NN;NN;NN;NN;NN;NN;SF;SF;NN;NN;SR" + "_" +
                         "SL;NN;NN;HT;HT;HT;HT;NN;NN;NN;NN;NN;NN;SF;SF;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;3U;NN;NN;NN;NN;NN;SF;SF;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;PM;NN;NN;NN;NN;NN;SF;SF;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;3D;NN;NN;NN;NN;NN;SF;SF;NN;NN;SR" + "_" +
                         "SL;NN;NN;HB;HB;HB;HB;NN;NN;NN;NN;NN;NN;SF;SF;NN;NN;SR" + "_" +
                         "SL;NN;NN;SF;SF;SF;SF;NN;NN;NN;NN;NN;NN;SF;SF;NN;NN;SR" + "_" +
                         "HB;HB;HB;SF;SF;SF;SF;SB;SB;SB;NN;NN;NN;SF;SF;NN;NN;SR";

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
                    time = 10;
                    lm = "HT;HT;HT;ST;ST;ST;HT;HT;HT;HT;NN;NN;NN;ST;ST;ST;ST;S6" + "_" +
                         "HL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "HL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "HL;NN;NN;NN;NN;NN;NN;NN;NN;NN;SF;SF;SF;SF;NN;NN;NN;SR" + "_" +
                         "HL;NN;NN;NN;NN;NN;NN;NN;NN;NN;SF;SF;SF;SF;NN;NN;NN;SR" + "_" +
                         "HB;HB;HB;NN;NN;NN;NN;NN;NN;NN;HT;HT;HT;HT;NN;NN;NN;SR" + "_" +
                         "SF;SF;SF;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;SF;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;SF;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SF;SF;SF;SF" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;HR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;HR" + "_" +
                         "SL;NN;2L;PM;2R;NN;SF;SF;NN;NN;NN;NN;NN;NN;NN;NN;NN;HR" + "_" +
                         "HB;HB;HB;HB;HB;HB;SF;SF;NN;NN;NN;HB;HB;HB;HB;HB;HB;HB";

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
                    time = 10;
                    lm = "S5;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;S6" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SF;SF;SF" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;4U;NN;NN;NN;NN;NN;NN;SF;SF;SF" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;PM;NN;NN;NN;NN;NN;NN;SF;SF;SF" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;4D;NN;NN;NN;NN;NN;NN;NN;NN;HR" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;HR" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;HR" + "_" +
                         "SF;SF;SF;SF;SF;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;HR" + "_" +
                         "SF;SF;SF;SF;SF;NN;NN;NN;NN;NN;6L;PM;5R;NN;NN;NN;NN;SR" + "_" +
                         "SF;SF;SF;SF;SF;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SF;SF;SF;SF;SF;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SF;SF;SF;SF;SF;HB;HB;HB;HB;HB;HB;HB;HB;NN;NN;NN;NN;S7";

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
                    time = 10;
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
                    time = 10;
                    lm = "S5;ST;ST;ST;ST;SF;ST;ST;ST;ST;ST;SF;ST;ST;ST;ST;ST;S6" + "_" +
                         "SL;NN;NN;NN;NN;SR;NN;NN;NN;NN;NN;SR;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;SR;NN;NN;NN;NN;NN;SR;BL;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;SR;NN;NN;NN;NN;NN;SR;NN;NN;NN;NN;NN;SR" + "_" +
                         "NN;NN;SR;NN;NN;NN;NN;NN;SR;NN;NN;NN;NN;NN;SR;NN;NN;SR" + "_" +
                         "NN;NN;SR;NN;NN;NN;NN;NN;SR;NN;NN;NN;NN;NN;SR;NN;NN;SR" + "_" +
                         "NN;NN;SR;NN;NN;NN;NN;NN;SR;NN;NN;NN;NN;NN;SR;NN;NN;SR" + "_" +
                         "DH;DH;DH;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;NN;NN;SR" + "_" +
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
                    time = 10;
                    lm = "HL;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;ST;S6" + "_" +
                         "HL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "HL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "HL;3U;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SF;SF;NN;NN;SR" + "_" +
                         "HL;PM;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SF;SF;NN;NN;SR" + "_" +
                         "HL;3D;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;3U;SF;SF;NN;NN;SR" + "_" +
                         "HL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;PM;SF;SF;NN;NN;SR" + "_" +
                         "HL;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;3D;SF;SF;NN;NN;SR" + "_" +
                         "SF;SF;SF;SF;SF;NN;NN;NN;NN;NN;NN;NN;NN;SF;SF;NN;NN;SR" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;PC;PC;PC;NN;SF;SF;NN;NN;SR" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR;NN;NN;NN" + "_" +
                         "SL;NN;NN;PC;PC;PC;NN;NN;NN;NN;NN;NN;NN;NN;SR;NN;NN;NN" + "_" +
                         "HB;HB;HB;HB;HB;HB;HB;HB;HB;HB;HB;HB;SF;SF;SF;SB;SB;SB";

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
                    time = 10;
                    lm = "S5;ST;ST;ST;ST;ST;SF;ST;ST;SF;ST;ST;ST;ST;ST;ST;ST;S6" + "_" +
                         "SL;NN;NN;NN;NN;BT;SR;NN;NN;DV;NN;NN;SR;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;2L;PM;2R;NN;SR;NN;NN;DV;NN;NN;SR;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;2L;PM;2R;NN;SR;NN;NN;DV;NN;NN;NN;NN;NN;SL;NN;SR" + "_" +
                         "SL;NN;NN;HB;SF;SF;SF;NN;NN;DV;NN;NN;NN;NN;NN;SL;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;PC;PC;SF;ST;ST;ST;ST;ST;S1;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;SR;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;NN;NN;SR;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                         "DH;DH;DH;ST;ST;ST;ST;ST;ST;SF;NN;NN;S5;ST;ST;ST;ST;ST" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;NN;HR;SF;NN;NN;SL;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;2U;HR;SF;NN;NN;SL;NN;NN;NN;NN;NN" + "_" +
                         "NN;NN;NN;NN;NN;NN;NN;PM;HR;SF;NN;NN;NN;NN;NN;SF;SF;SF" + "_" +
                         "SL;NN;NN;NN;NN;NN;NN;1D;HR;SF;NN;NN;NN;NN;NN;SF;SF;SF" + "_" +
                         "S8;SB;SB;SB;SB;SB;SB;SB;SB;SF;SB;SB;SB;SB;SB;SF;SF;SF";

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
                    List<RectangleF> collisionBoxes;
                    switch (s2)
                    {
                        case "SF":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(new PointF(x * 48, y * 48),new SizeF(48,48)));
                            lvlMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "img2.jpg", collisionBoxes);
                            break;
                        case "PL":
                            collisionBoxes = new List<RectangleF>();
                            collisionBoxes.Add(new RectangleF(new PointF(x * 48, y * 48), new SizeF(48, 96)));
                            lvlMap[y, x] = new Dash(500, 100, 200, "Captain Dash", new PointF(x * 48, y * 48), "player.jpg",collisionBoxes);
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
