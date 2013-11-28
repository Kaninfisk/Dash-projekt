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
            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;
            TopMost = true;

            Timer timer1 = new Timer();
            timer1.Interval = 40;
            timer1.Tick += Timer1_Tick;
            timer1.Start();

            KeyPreview = true;
            PreviewKeyDown += Input;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void Timer1_Tick(object sender, EventArgs e)
        {
            if (g == null)
            {
                g = new GameWorld(CreateGraphics(), DisplayRectangle);
            }
            g.GameLoop();
        }

        public void Input(object sender, PreviewKeyDownEventArgs e)
        {
            g.Input = e.KeyCode;
        }

    }
}
