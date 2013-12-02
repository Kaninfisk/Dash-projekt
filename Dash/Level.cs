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

        private string s = "NNNNNNNNNNNNNNNNNN" + "_" +
                           "NNNNNNNNNNNNNNNNNN" + "_" +
                           "NNNNNNNNNNNNNNNNNN" + "_" +
                           "NNNNNNNNNNNNNNNNNN" + "_" +
                           "NNNNNNNNNNNNNNNNNN" + "_" +
                           "NNNNNNNNNNNNNNNNNN" + "_" +
                           "NNNNNNNNNNNNNNNNNN" + "_" +
                           "NNNNNNNNNNNNNNNNNN" + "_" +
                           "NNNNNNNNNNNNNNNNNN" + "_" +
                           "NNNNNNNNNNNNNNNNNN" + "_" +
                           "NNNNNNNNNNNNNNNNNN" + "_" +
                           "NNNNNNNNNNNNNNNNNN" + "_" +
                           "NNNNNNNNNNNNNNNNNN" + "_" +
                           "NNNNNNNNNNNNNNNNNN";

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
            this.levelMap = new GameObject[temp.Length,temp[0].Length];
            for (int y = 0; y < this.levelMap.GetLength(0); y++)
            {
                for (int x = 0; x < this.levelMap.GetLength(1); x++)
                {
                    switch (temp[y][x])
                    {
                        case 'N':
                            this.levelMap[y, x] = null;
                            break;
                        case 'B':
                            this.levelMap[y, x] = new SolidBlock(new PointF(x * 48, y * 48), "img2.png");
                            break;
                    }
                }
            }


            temp = backgroundMap.Split('_');
            this.backgroundMap = new GameObject[temp.Length, temp[0].Length];
            for (int y = 0; y < this.backgroundMap.GetLength(0); y++)
            {
                for (int x = 0; x < this.backgroundMap.GetLength(1); x++)
                {
                    switch (temp[y][x])
                    {
                        case 'N':
                            this.backgroundMap[y, x] = null;
                            break;
                        case 'B':
                            this.backgroundMap[y, x] = new SolidBlock(new PointF(x*48, y*48),"img2.png" );
                            break;
                    }
                }
            }

        }
    }
}
