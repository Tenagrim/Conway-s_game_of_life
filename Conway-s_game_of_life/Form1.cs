using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conway_s_game_of_life
{
    public partial class Form1 : Form
    {

        private Graphics graphics;
        World world;
        public Form1()
        {
            InitializeComponent();
        }





        private void DisplayWorld(World world)
        {

            int resolution = 5;
            int off_x = (pictureBox1.Width / 2) - (world.Width * resolution / 2) ;
            int off_y = (pictureBox1.Height / 2)  - (world.Height * resolution / 2);
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(pictureBox1.Image);

            graphics.Clear(Color.Black);
            for (int i = 0; i < world.Height; i++)
            {
                for (int j = 0; j < world.Width; j++)
                {
                    if (world.Field[i,j])
                        graphics.FillRectangle(Brushes.White, j * resolution + off_x, i * resolution + off_y, resolution, resolution);
                }
            }
        }

        private void bStart_Click(object sender, EventArgs e)
        {


        }

        private void bStop_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            world = new World(30, 50, true);
            world.FillRandom(5);
            DisplayWorld(world);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            world = new World(70, 70, true);
            world.FillRandom(10);
            DisplayWorld(world);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            world.Step();
            DisplayWorld(world);
        }
    }
}
