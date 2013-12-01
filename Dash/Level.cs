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

        private GameObject[,] bla = new GameObject[14, 18]
                                    
        {
                                        {null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null},{null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null},
                                        {null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null},{null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null},
                                        {null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null},{null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null},
                                        {null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null},{null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null},
                                        {null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null},{null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null},
                                        {null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null},{null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null},
                                        {null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null},{null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null},
                                    };


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

        public Level(GameObject[,] levelMap, GameObject[,]backgroundMap, int time)
        {
            this.levelMap = levelMap;
            this.backgroundMap = backgroundMap;
            this.time = time;
        }
    }
}
