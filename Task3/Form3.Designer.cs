﻿namespace Task3
{
    partial class Form3
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(616, 37);
            label1.Name = "label1";
            label1.Size = new Size(132, 28);
            label1.TabIndex = 0;
            label1.Text = "                        ";
            // 
            // button1
            // 
            button1.Location = new Point(12, 20);
            button1.Name = "button1";
            button1.Size = new Size(88, 45);
            button1.TabIndex = 1;
            button1.Text = "Baku";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Image = Properties.Resources.az_06;
            button2.Location = new Point(91, 71);
            button2.Name = "button2";
            button2.Size = new Size(624, 384);
            button2.TabIndex = 2;
            button2.Text = "                     ";
            button2.UseVisualStyleBackColor = true;

            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Image = Properties.Resources.london1;
            button2.Location = new Point(91, 71);
            button2.Name = "button2";
            button2.Size = new Size(624, 384);
            button2.TabIndex = 2;
            button2.Text = "                     ";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
    }
}