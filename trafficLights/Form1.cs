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
            try
            {
                //GET user input
                int radius = 0;
                radius = int.Parse(textBoxUserInput.Text);
                Console.WriteLine(radius);

                //Make draw surface
                Graphics canvas = pictureBoxArea.CreateGraphics();

                //Pen for the border
                Pen blackPen = new Pen(Color.Black, 5);

                //Fill shape with color
                SolidBrush brush1 = new SolidBrush(Color.Red);

                //Setting up the rectangle with coordinates
                Rectangle bar = new Rectangle(10, 10, 100, 100);

                //Fill rectangle with a circle and fill with color
                canvas.FillEllipse(brush1, bar);

                //Draw the border of the shape
                canvas.DrawEllipse(blackPen, bar);

                //GET input value and set it as the size property 
                bar.Width = radius;
                bar.Height = radius;

                radius = bar.Width;
                radius = bar.Height; 
                Console.WriteLine(radius);

                bar.Y += 110;
                brush1.Color = Color.Orange;
                canvas.FillEllipse(brush1, bar);
                canvas.DrawEllipse(blackPen, bar);

                bar.Y += 120;
                brush1.Color = Color.Green;
                canvas.FillEllipse(brush1, bar);
                canvas.DrawEllipse(blackPen, bar);
            }
            catch
            {
                MessageBox.Show("Please enter a number");
                textBoxUserInput.Focus();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
