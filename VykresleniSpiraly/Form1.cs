using System.Numerics;

namespace VykresleniSpiraly
{
    public partial class Form1 : Form
    {
        Spirala spirala;
        float odstup;
        int rotation;

        public Form1()
        {
            InitializeComponent();
            
        }

        public void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (spirala != null)
                spirala.Vykresli(e.Graphics);
            
            
        }

        private void button1_click(object sender, MouseEventArgs e)
        {
            odstup = float.Parse(textBox1.Text);
            spirala = new Spirala(odstup, pictureBox1.Width / 2, pictureBox1.Height / 2);
            Refresh();
        }

        private void Rotation_Button(object sender, EventArgs e)
        {
            if (rotation == 2)
                rotation = 0;

            switch (rotation)
            {
                case 0:
                    button2.BackColor = Color.Green;
                    timer1.Enabled = true;
                    rotation++;
                    break;

                case 1:
                    button2.BackColor = Color.Red;
                    timer1.Enabled = false;
                    rotation++;
                    break;

                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            spirala.Rotation();
            Refresh();
        }
    }
}