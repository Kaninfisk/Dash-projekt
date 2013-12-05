using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dash
{
    public partial class Form1 : Form
    {
        private GameWorld g;

        public Form1()
        {
            InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.None;
            Width = 880;
            Height = 710;
            //TopMost = true;
            
            Timer timer1 = new Timer();
            timer1.Interval = 40;
            timer1.Tick += Timer1_Tick;
            timer1.Start();

            KeyPreview = true;
            PreviewKeyDown += Input;
        }

        /// <summary>
        /// Metode som kører gameloopet når timeren ticker og opretter gameworlden hvis den ikke er oprettet endnu
        /// </summary>
        /// <param name="sender">Objektet som kørte metoden(timeren)</param>
        /// <param name="e">event informationer</param>
        public void Timer1_Tick(object sender, EventArgs e)
        {
            if (g == null)
            {
                g = new GameWorld(CreateGraphics(), DisplayRectangle);
            }
            g.GameLoop();
        }

        /// <summary>
        /// Metode som bliver kørt når der trykkes på en tast denne sender inputtet ind i gameworld
        /// </summary>
        /// <param name="sender">objektet som kørte metoden(formen)</param>
        /// <param name="e">Event informationer</param>
        public void Input(object sender, PreviewKeyDownEventArgs e)
        {
            g.Input = e.KeyCode;
        }

    }
}
