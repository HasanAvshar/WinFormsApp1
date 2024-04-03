using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Point mouseDownLocation;

        public Form1()
        {
            InitializeComponent();
            this.MouseDown += Form1_MouseDown;
            this.MouseUp += Form1_MouseUp;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDownLocation = e.Location;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mouseUpLocation = e.Location;

                int buttonWidth = Math.Abs(mouseUpLocation.X - mouseDownLocation.X);
                int buttonHeight = Math.Abs(mouseUpLocation.Y - mouseDownLocation.Y);

                Button button = new Button
                {
                    Location = new Point(
                        Math.Min(mouseDownLocation.X, mouseUpLocation.X),
                        Math.Min(mouseDownLocation.Y, mouseUpLocation.Y)
                    ),
                    Size = new Size(buttonWidth, buttonHeight),
                    Text = "New Button"
                };

                this.Controls.Add(button);
            }
        }
    }
}
