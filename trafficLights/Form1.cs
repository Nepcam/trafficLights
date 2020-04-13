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
        public Form1()
        {
            InitializeComponent();
        }
       
        private void buttonDrawTrafficLights_Click(object sender, EventArgs e)
        {
            const int GAP_DISTANCE = 20; //(Y) Vertical distance variable
                                        
            int radius = 0;
            radius = int.Parse(textBoxUserInput.Text);  //GET user input
            Console.WriteLine(radius); //Check value from GUI

            //Make draw surface
            Graphics canvas = pictureBoxArea.CreateGraphics();

            //Pen for the border
            Pen blackPen = new Pen(Color.Black, 5);

            //Fill shape with color
            SolidBrush brush1 = new SolidBrush(Color.Red);

            //Setting up the rectangle with coordinates
            Rectangle bar = new Rectangle(10, 10, 100, 100);

            //GET input value and set it as the size property 
            bar.Width = radius;
            bar.Height = radius;

            try
            {              
                if (radius < 100)
                {
                    radius = bar.Width / 2;
                    radius = bar.Height / 2;
                    Console.WriteLine(radius); //Check value

                    //bar.Y += 10;
                    bar.Y += 10 + GAP_DISTANCE;
                    brush1.Color = Color.Red;
                    canvas.FillEllipse(brush1, bar);
                    canvas.DrawEllipse(blackPen, bar);

                    //bar.Y += 110;
                    bar.Y += 110 + GAP_DISTANCE;
                    brush1.Color = Color.Orange;
                    canvas.FillEllipse(brush1, bar);
                    canvas.DrawEllipse(blackPen, bar);

                    //bar.Y += 120;
                    bar.Y += 120 + GAP_DISTANCE;
                    brush1.Color = Color.Green;
                    canvas.FillEllipse(brush1, bar);
                    canvas.DrawEllipse(blackPen, bar);
                }
                else
                {
                    MessageBox.Show("Number is too big!!");
                }
            }
            catch
            {
                MessageBox.Show("Please enter a number");
                textBoxUserInput.Focus();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            //Clear the textBox
            textBoxUserInput.Text = "";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
