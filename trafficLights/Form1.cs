using System;
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
            Graphics canvas = pictureBoxArea.CreateGraphics();
            Pen pen1 = new Pen(Color.Black);

            //Draw traffic light
            canvas.DrawEllipse(pen1, 10, 10, 50, 50);




        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
