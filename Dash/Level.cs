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

        private string s = "NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN;NN" + "_" + 
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

        public int Type
        {
            get { return type; }
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
            
            this.levelMap = new GameObject[temp.Length,temp[0].Split(';').Length];



            
            int y = 0;
            foreach (string s1 in temp)
            {
                int x = 0;
                foreach (string s2 in s1.Split(';'))
                {
                    switch (s2)
                    {
                        case "NN":
                            this.levelMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "img2.png");
                            break;
                        case "BB":
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
                        case "NN":
                            this.backgroundMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "img2.png");
                            break;
                        case "BB":
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
