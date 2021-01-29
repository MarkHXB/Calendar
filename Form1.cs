using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using WinFormAnimation;

namespace Calendar
{
    public partial class Form1 : Form
    {
        class button
        {
            public int X { get; set; }
            public int Y { get; set; }
            public string Name { get; set; }
            public button(int x,int y,string name)
            {
                X = x;
                Y = y;
                Name = name;
            }
        }
        static List<button> myButtons;
        static Button buttonWasClicked;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[] buttons = this.Controls.OfType<Button>().ToArray();
            myButtons = new List<button>();

            foreach (var item in buttons)
            {
                myButtons.Add(new button(item.Location.X,item.Location.Y,item.Name));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            testMove.Start();
        }
        
        private void testMove_Tick(object sender, EventArgs e)
        {
            //this.Opacity -= 0.029;
            
            Point location =buttonWasClicked.Location;
            for (int i = 0; i < myButtons.Count; i++)
            {
                if (myButtons[i].Name == buttonWasClicked.Name)
                {
                    if (location.Y == myButtons[i].Y + 50)
                    {
                        testMove.Stop();
                    }
                }
            }
            
            location.Y += 1;
            buttonWasClicked.Location = location;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        //collective
        private void button8_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            buttonWasClicked = clickedButton;
            testMove.Start();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.BackColor = Color.Transparent;

        }

        private void button11_MouseMove(object sender, MouseEventArgs e)
        {
            button11.BackColor = Color.Gray;
        }
    }
}
