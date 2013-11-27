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
        public Form1()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;
            TopMost = true;

            //KeyDown += OnKeyDown;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            Label lbl = new Label();
            lbl.Text += e.KeyCode;
            Controls.Clear();
            Controls.Add(lbl);
            KeyDown -= OnKeyDown;
        }
    }
}
