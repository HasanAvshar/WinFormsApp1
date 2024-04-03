using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        private Label label1;

        public Form2()
        {
            InitializeComponent();
            label1 = new Label
            {
                Location = new Point(50, 50),
                Size = new Size(100, 50),
                Text = "Label"
            };
            this.Controls.Add(label1);
            this.MouseMove += Form2_MouseMove;
        }

        private void InitializeComponent()
        {
            private void InitializeComponent()
            {
                this.label1 = new System.Windows.Forms.Label();
                this.SuspendLayout();
                // 
                // label1
                // 
                this.label1.Location = new System.Drawing.Point(50, 50);
                this.label1.Size = new System.Drawing.Size(100, 50);
                this.label1.Text = "Label";
                // 
                // Form2
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(800, 450);
                this.Controls.Add(this.label1);
                this.Name = "Form2";
                this.Text = "Form2";
                this.ResumeLayout(false);
            }

        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            Point mousePos = this.PointToClient(Cursor.Position);
            if (label1.Bounds.Contains(mousePos))
            {
                MessageBox.Show("Cursor is over the label.");
            }
        }
    }
}
