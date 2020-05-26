﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace trafficLights
{
    // Cameron Nepe - Student ID: 1262199
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Set variables
        const int GAP_DISTANCE = 20; //(Y) Vertical distance variable

        private void buttonDrawTrafficLights_Click(object sender, EventArgs e)
        {
            

            // GET user input                            
            int radius = 0;
            radius = int.Parse(textBoxUserInput.Text); 
            Console.WriteLine(radius); // Check value from GUI

            // Make draw surface
            Graphics canvas = pictureBoxArea.CreateGraphics();

            // Pen for the border
            Pen blackPen = new Pen(Color.Black, 3);

            // Fill shape with color
            SolidBrush brush1 = new SolidBrush(Color.Red);

            // Setting up the rectangle with coordinates
            Rectangle bar = new Rectangle(10, 10, 100, 100);

            // GET input value and set it as the size property 
            bar.Width = radius;
            bar.Height = radius;

            try
            {              
                //if (radius < 101)
                {
                    // I wasn't too sure on how to get the radius
                    radius = bar.Width / 2;
                    radius = bar.Height / 2;
                    Console.WriteLine(radius); //Check value
            
                    bar.Y += GAP_DISTANCE;
                    brush1.Color = Color.Red;
                    canvas.FillEllipse(brush1, bar);
                    canvas.DrawEllipse(blackPen, bar);

                    bar.Y += bar.Height + GAP_DISTANCE;
                    brush1.Color = Color.Orange;
                    canvas.FillEllipse(brush1, bar);
                    canvas.DrawEllipse(blackPen, bar);

                    bar.Y += bar.Height + GAP_DISTANCE;
                    brush1.Color = Color.Green;
                    canvas.FillEllipse(brush1, bar);
                    canvas.DrawEllipse(blackPen, bar);
                }
                //else
                {
                    //MessageBox.Show("Number is too big!!");
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
            //Clear the textBox and set focus
            textBoxUserInput.Text = "";
            textBoxUserInput.Focus();
            //Clear the picture box
            pictureBoxArea.Refresh();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
