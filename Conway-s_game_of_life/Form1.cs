using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Conway_s_game_of_life
{
    public partial class Form1 : Form
    {

        private Graphics graphics;
        World world = new World(2, 2, true);
        int resolution = 5;
        int off_x, off_y;
        bool drag = false;
        Coords drag_begin_coords = new Coords();
        Coords drag_offset = new Coords();
        bool is_running = false;


        public Form1()
        {
            InitializeComponent();
        }


        private void DisplayWorld(World world)
        {
            resolution = (int)numericUpDown1.Value;
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(pictureBox1.Image);

            graphics.Clear(Color.Black);
            for (int i = 0; i < world.Height; i++)
            {
                for (int j = 0; j < world.Width; j++)
                {
                    if (world.Field[i,j])
                        graphics.FillRectangle(Brushes.White, j * resolution + off_x + drag_offset.X, i * resolution + off_y + drag_offset.Y, resolution, resolution);
                }
            }
            pictureBox1.Refresh();
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            if (!is_running)
            {
                timer1.Start();
                is_running = true; 
                bStart.Text = "Stop";
            }
            else
            {
                timer1.Stop();
                bStart.Text = "Start";
                is_running = false;
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Step(world);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReloadWorld();
        }

        private void Step(World w)
        {
            w.Step();
            lGenCounter.Text = $"Generation: {world.Generation}";
            DisplayWorld(world);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Step(world);
        }

        private Coords ToWorldCoords(Coords mouse_coords)
        {
            Coords res = new Coords();

           // off_x = (pictureBox1.Width / 2) - (world.Width * resolution / 2);
           // off_y = (pictureBox1.Height / 2) - (world.Height * resolution / 2);

            res.X = (mouse_coords.X  - off_x - drag_offset.X) / resolution;
            res.Y = (mouse_coords.Y  - off_y - drag_offset.Y) / resolution;

            return res;
        }


        private void ReloadWorld()
        {
            world = new World((int)ndWidth.Value, (int)ndHeight.Value, cbBordered.Checked);
            world.FillRandom((int)numericUpDown2.Value);
            off_x = (pictureBox1.Width / 2) - (world.Width * resolution / 2);
            off_y = (pictureBox1.Height / 2) - (world.Height * resolution / 2);
            lGenCounter.Text = $"Generation: {world.Generation}";
            DisplayWorld(world);
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Coords mouse_coords = new Coords(e.Location.X, e.Location.Y);
                Debug.WriteLine($"Alive on  {ToWorldCoords(mouse_coords).X}  : {ToWorldCoords(mouse_coords).Y} ");
                world.Alive(ToWorldCoords(mouse_coords));

            }
            if (e.Button == MouseButtons.Right)
            {
                Coords mouse_coords = new Coords(e.Location.X, e.Location.Y);
                Debug.WriteLine($"Kill on  {ToWorldCoords(mouse_coords).X}  : {ToWorldCoords(mouse_coords).Y} ");
                world.Kill(ToWorldCoords(mouse_coords));

            }
            if (timer1.Enabled == false)
                DisplayWorld(world);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           // off_x = (pictureBox1.Width / 2) - (world.Width * resolution / 2);
          //  off_y = (pictureBox1.Height / 2) - (world.Height * resolution / 2);
            DisplayWorld(world);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
                drag = false;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle && !is_running)
                drag = true;
            drag_begin_coords.X = e.X;
            drag_begin_coords.Y = e.Y;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            drag_offset.X = 0;
            drag_offset.Y = 0;
            off_x = (pictureBox1.Width / 2) - (world.Width * resolution / 2);
            off_y = (pictureBox1.Height / 2) - (world.Height * resolution / 2);
            DisplayWorld(world);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            world = new World(70,70,true);
            DisplayWorld(world);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            ReloadWorld();
        }

        private void SaveWorld(string filename, World world)
        {
          //  FileStream fs = new FileStream(filename, FileMode.Truncate);
          //  fs.Close();

            FileStream fs = new FileStream(filename, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, world);
            fs.Close();
        }
        private World LoadWorld(string filename )
        {
            World res;
            FileStream fs = new FileStream(filename, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            res = (World)bf.Deserialize(fs);
            fs.Close();
            return res;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SaveWorld( "123.w", world);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            world = LoadWorld("123.w");
            DisplayWorld(world);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Debug.WriteLine("Dragging");
                drag_offset.X = drag_offset.X +( e.Location.X - drag_begin_coords.X);
                drag_offset.Y = drag_offset.Y + (e.Location.Y - drag_begin_coords.Y);
                drag_begin_coords.X = e.Location.X;
                drag_begin_coords.Y = e.Location.Y;
                if (timer1.Enabled == false)
                    DisplayWorld(world);
            }
            else if (e.Button == MouseButtons.Left)
            {
                Coords mouse_coords = new Coords(e.Location.X, e.Location.Y);
                Debug.WriteLine($"Alive on  {ToWorldCoords(mouse_coords).X}  : {ToWorldCoords(mouse_coords).Y} ");
                world.Alive(ToWorldCoords(mouse_coords));
                if (timer1.Enabled == false)
                    DisplayWorld(world);
            }
            else if (e.Button == MouseButtons.Right)
            {
                Coords mouse_coords = new Coords(e.Location.X, e.Location.Y);
                Debug.WriteLine($"Kill on  {ToWorldCoords(mouse_coords).X}  : {ToWorldCoords(mouse_coords).Y} ");
                world.Kill(ToWorldCoords(mouse_coords));
                if (timer1.Enabled == false)
                    DisplayWorld(world);
            }
            //else
               // Debug.WriteLine(e.Button);


        }
    }
}
