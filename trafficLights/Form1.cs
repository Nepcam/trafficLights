﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trafficLights
{
    public partial class Form1 : Form
    {
        const double GAP_DISTANCE = 0; // vertical distance between lights
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxUserInput.Text = "";
        }

        private void buttonDrawTrafficLights_Click(object sender, EventArgs e)
        {
            //Make draw surface
            Graphics canvas = pictureBoxArea.CreateGraphics();

            //Fill shape with color
            SolidBrush brush1 = new SolidBrush(Color.Red);

            //Setting up the rectangle with coordinates
            Rectangle bar = new Rectangle(10, 10, 100, 100);

            //Fill rectangle with a circle and fill with color
            canvas.FillEllipse(brush1, bar);

            bar.Y += 110;
            brush1.Color = Color.Orange;
            canvas.FillEllipse(brush1, bar);

            bar.Y += 120;
            brush1.Color = Color.Green;
            canvas.FillEllipse(brush1, bar);

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
