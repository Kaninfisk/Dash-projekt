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
        private GameObject[,] levelMap;
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
                       lm = "SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF" + "_" +
                            "SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF;SF" + "_" +
                            "SF;SF;SF;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                            "SF;SF;SF;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                            "SF;SF;SF;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                            "SF;SF;SF;NN;NN;NN;SF;SF;SF;SF;SF;SF;SF;SF;NN;NN;NN;SR" + "_" +
                            "SF;SF;SF;NN;NN;NN;SF;SF;SF;SF;SF;SF;SF;SF;NN;NN;NN;SR" + "_" +
                            "SF;SF;SF;NN;NN;NN;SF;SF;SF;SF;SF;SF;SF;SF;NN;NN;NN;SR" + "_" +
                            "SF;SF;SF;NN;NN;NN;SF;SF;SF;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                            "SF;SF;SF;NN;NN;NN;SF;SF;SF;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                            "SF;SF;SF;NN;NN;NN;SF;SF;SF;NN;NN;NN;NN;NN;NN;NN;NN;SR" + "_" +
                            "NN;NN;NN;NN;NN;NN;SF;SF;SF;NN;NN;NN;NN;SF;SF;SF;SF;SF" + "_" +
                            "NN;NN;NN;NN;NN;NN;SF;SF;SF;NN;NN;NN;NN;SF;SF;SF;SF;SF" + "_" +
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
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                    break;
                case 11:
                    break;
                case 12:
                    break;
                case 13:
                    break;
                case 14:
                    break;
                case 15:
                    break;
                case 16:
                    break;
                case 17:
                    break;
                case 18:
                    break;
                case 19:
                    break;
                case 20:
                    break;
                default:
                    lm = "";
                    bm = "";
                    break;
            }
            string[] temp = lm.Split('_');

            this.levelMap = new GameObject[temp.Length, temp[0].Split(';').Length];

            int y = 0;
            foreach (string s1 in temp)
            {
                int x = 0;
                foreach (string s2 in s1.Split(';'))
                {
                    switch (s2)
                    {
                        case "BB":
                            this.levelMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "img2.png");
                            break;
                        default:
                            this.levelMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "img2.png");
                            break;
                    }
                    x++;
                }
                y++;
            }


            temp = bm.Split('_');
            this.backgroundMap = new GameObject[temp.Length, temp[0].Split(';').Length];
            y = 0;
            foreach (string s1 in temp)
            {
                int x = 0;
                foreach (string s2 in s1.Split(';'))
                {
                    switch (s2)
                    {
                        case "BB":
                            this.backgroundMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "img2.png");
                            break;
                        default:
                            this.backgroundMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "img2.png");
                            break;
                    }
                    x++;
                }
                y++;
            }
        }

        public GameObject[,] LevelMap
        {
            get { return levelMap; }
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

        public Level(string levelMap, string backgroundMap, int time)
        {
            this.time = time;

            string[] temp = levelMap.Split('_');

            this.levelMap = new GameObject[temp.Length, temp[0].Split(';').Length];




            int y = 0;
            foreach (string s1 in temp)
            {
                int x = 0;
                foreach (string s2 in s1.Split(';'))
                {
                    switch (s2)
                    {
                        case "BB":
                            this.levelMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "img2.png");
                            break;
                        default:
                            this.levelMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "img2.png");
                            break;
                    }
                    x++;
                }
                y++;
            }


            temp = backgroundMap.Split('_');
            this.backgroundMap = new GameObject[temp.Length, temp[0].Split(';').Length];
            y = 0;
            foreach (string s1 in temp)
            {
                int x = 0;
                foreach (string s2 in s1.Split(';'))
                {
                    switch (s2)
                    {
                        case "BB":
                            this.backgroundMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "img2.png");
                            break;
                        default:
                            this.backgroundMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "img2.png");
                            break;
                    }
                    x++;
                }
                y++;
            }
        }
    }
}
