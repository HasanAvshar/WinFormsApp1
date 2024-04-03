using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form2 : Form
    {
        private Label label;

        public Form2()
        {
            InitializeComponent();
            InitializeLabel();
        }

        private void InitializeLabel()
        {
            label = new Label();
            label.Text = "Gotta catch";
            label.AutoSize = true;
            label.Location = new Point(100, 100);
            label.MouseEnter += Label_MouseEnter;
            Controls.Add(label);
        }

        private void Label_MouseEnter(object sender, EventArgs e)
        {
            Point newLocation = GetRandomLocation();
            label.Location = newLocation;
        }

        private Point GetRandomLocation()
        {
            Random random = new Random();
            int newX = random.Next(0, ClientSize.Width - label.Width);
            int newY = random.Next(0, ClientSize.Height - label.Height);
            return new Point(newX, newY);
        }
    }
}
