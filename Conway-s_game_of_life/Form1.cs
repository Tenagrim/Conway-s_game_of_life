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
        private Graphics brush_graphics;
        World world = new World(2, 2, true);
        Brush brush = new Brush();
        int brush_resolution = 5;
        int resolution = 5;
        int off_x, off_y;
        bool drag = false;
        bool select = false;
        Coords drag_begin_coords = new Coords();
        Coords drag_offset = new Coords();
        Pen selectPen = new Pen(Brushes.Red);
        Pen borderPen = new Pen(Brushes.White);
        Rectangle selectRect = new Rectangle();
        bool is_running = false;

        public Form1()
        {
            InitializeComponent();
            selectPen.Width = 1.0F;
            borderPen.Width = 1.0F;
        }


        private void DisplayWorld(World world)
        {
            graphics.Clear(Color.Black);
            for (int i = 0; i < world.Height; i++)
            {
                for (int j = 0; j < world.Width; j++)
                {
                    if (world.Field[i,j])
                        graphics.FillRectangle(Brushes.White, j * resolution + off_x + drag_offset.X, i * resolution + off_y + drag_offset.Y, resolution, resolution);
                }
            }
           // graphics.DrawRectangle(borderPen, pictureBox1.Width/2 + off_x + drag_offset.X, pictureBox1.Height/2 + off_y + drag_offset.Y, resolution * world.Width, resolution * world.Height);
            graphics.DrawRectangle(borderPen, pictureBox1.Width / 2 - resolution * world.Width / 2+ drag_offset.X, pictureBox1.Height / 2 - resolution * world.Height / 2+ drag_offset.Y, resolution * world.Width, resolution * world.Height);
            pictureBox1.Refresh();
        }

        private void DisplayBrush(Brush brush)
        {
            int max_side = Math.Max(brush.Height, brush.Width);

            brush_resolution = 2;

            int off_x = (pictureBox2.Width / 2) - (brush.Width * brush_resolution / 2);
            int off_y = (pictureBox2.Height / 2) - (brush.Height * brush_resolution / 2);


            lSelectedBrush.Text = $"Selected brush:\n\"{brush.Name}\"";

            brush_graphics.Clear(Color.Black);
            for (int i = 0; i < brush.Height; i++)
            {
                for (int j = 0; j < brush.Width; j++)
                {
                    if(brush.Field[i,j])
                    brush_graphics.FillRectangle(Brushes.White, j * brush_resolution + off_x, i * brush_resolution + off_y, brush_resolution, brush_resolution);
                }
            }
            pictureBox2.Refresh();
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
            ReloadWorld(1);
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


        private void ReloadWorld(int mode)
        { 
            world = new World((int)ndWidth.Value, (int)ndHeight.Value, cbBordered.Checked);
           if (mode == 1)
                world.FillRandom((int)numericUpDown2.Value);
            off_x = (pictureBox1.Width / 2) - (world.Width * resolution / 2);
            off_y = (pictureBox1.Height / 2) - (world.Height * resolution / 2);
            lGenCounter.Text = $"Generation: {world.Generation}";
            DisplayWorld(world);
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (drag || select)
                return;

            if (e.Button == MouseButtons.Left)
            {
                Coords mouse_coords = new Coords(e.Location.X, e.Location.Y);
                //Debug.WriteLine($"Alive on  {ToWorldCoords(mouse_coords).X}  : {ToWorldCoords(mouse_coords).Y} ");
                //world.Alive(ToWorldCoords(mouse_coords));
                world.BrushStamp(brush, ToWorldCoords(mouse_coords));

            }
            if (e.Button == MouseButtons.Right)
            {
                Coords mouse_coords = new Coords(e.Location.X, e.Location.Y);
                Debug.WriteLine($"Kill on  {ToWorldCoords(mouse_coords).X}  : {ToWorldCoords(mouse_coords).Y} ");
                world.Kill(ToWorldCoords(mouse_coords));

            }
            if (timer1.Enabled == false)
                DisplayWorld(world);

            Debug.WriteLine(e.Button);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           // off_x = (pictureBox1.Width / 2) - (world.Width * resolution / 2);
           // off_y = (pictureBox1.Height / 2) - (world.Height * resolution / 2);
            resolution = (int)numericUpDown1.Value;
            off_x = (pictureBox1.Width / 2) - (world.Width * resolution / 2) ;
            off_y = (pictureBox1.Height / 2) - (world.Height * resolution / 2);
            DisplayWorld(world);
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
            ReloadWorld(0);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            resolution = (int)numericUpDown1.Value;
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(pictureBox1.Image);

            pictureBox2.Image = new Bitmap(pictureBox2.Width, pictureBox2.Height);
            brush_graphics = Graphics.FromImage(pictureBox2.Image);
            ReloadWorld(1);
            DisplayBrush(brush);
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

        private void SaveBrush(string filename, Brush brush)
        {
            //  FileStream fs = new FileStream(filename, FileMode.Truncate);
            //  fs.Close();

            FileStream fs = new FileStream(filename, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, brush);
            fs.Close();
        }
        private Brush LoadBrush(string filename)
        {
            Brush res;
            FileStream fs = new FileStream(filename, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            res = (Brush)bf.Deserialize(fs);
            fs.Close();
            return res;
        }

        private World LoadTxt(string filename, bool bordered)
        {
            World res;
            int H, W;
            bool[,] new_field;

            using (StreamReader sr = new StreamReader(filename, System.Text.Encoding.Default))
            {
                string line = sr.ReadLine();
                H = Convert.ToInt32(line);
                line = sr.ReadLine();
                W = line.Length;
                new_field = new bool[H, W];
                for (int i = 0; i < W; i++)
                    new_field[0,i] = (line[i] == '_' || line[i] == '.') ? false : true;
                for (int i = 1; i < H; i++)
                {
                    line = sr.ReadLine();
                    for (int j = 0; j < W; j++)
                    {
                        new_field[i, j] = (line[j] == '_' || line[j] == '.') ? false : true;
                    }
                }
            }
            res = new World(new_field, bordered);    
            return res;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SaveWorld( tbSaveLoad.Text, world);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try 
            { 
            world = LoadWorld(tbSaveLoad.Text);
            DisplayWorld(world);
            }
            catch
            {
                ShowMsg("Нет такого файла");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Coords rect_pos = new Coords(selectRect.X, selectRect.Y);
            

            brush = new Brush(world.GetArea(ToWorldCoords(rect_pos), selectRect.Width / resolution, selectRect.Height / resolution), "Custom brush");

            //world.Kill(ToWorldCoords(rect_pos), selectRect.Width / resolution , selectRect.Height / resolution);
            // DisplayWorld(world);
            DisplayBrush(brush);
        }

        private void cbSelecting_CheckedChanged(object sender, EventArgs e)
        {
            select = cbSelecting.Checked;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try 
            { 
            brush = LoadBrush(tbBrushSaveLoad.Text);
            DisplayBrush(brush);
            }
            catch
            {
                ShowMsg("Нет такого файла");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SaveBrush(tbBrushSaveLoad.Text, brush);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle || e.Button == MouseButtons.Left)
                drag = false;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
                drag = true;
            else if (select == true && e.Button == MouseButtons.Left && !is_running)
                drag = true;
            drag_begin_coords.X = e.X;
            drag_begin_coords.Y = e.Y;
        }
        private void ShowMsg(string msg)
        {
            //msg_label.Text = msg;
            //msg_label.Visible = true;
            MessageBox.Show(
             msg,
              "Ошибка",
            MessageBoxButtons.OK,
      MessageBoxIcon.Information);
        }
        private void bLoadTxt_Click(object sender, EventArgs e)
        {
            try
            {
                world = LoadTxt(tbLoadTxt.Text, cbBordered.Checked);
                DisplayWorld(world);
            }
            catch
            {
                ShowMsg("Нет такого файла");
            }
        }

        private void bTurnLeft_Click(object sender, EventArgs e)
        {
            brush.TurnLeft();
            DisplayBrush(brush);
        }

        private void bTurnRight_Click(object sender, EventArgs e)
        {
            brush.TurnRight();
            DisplayBrush(brush);
        }

        private void bMirrorHorizontal_Click(object sender, EventArgs e)
        {
            brush.MirrorHorizontal();
            DisplayBrush(brush);
        }

        private void bMirrorVertical_Click(object sender, EventArgs e)
        {
            brush.MirrorVertical();
            DisplayBrush(brush);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag && !select)
            {
                Debug.WriteLine("Dragging");
                drag_offset.X = drag_offset.X + (e.Location.X - drag_begin_coords.X);
                drag_offset.Y = drag_offset.Y + (e.Location.Y - drag_begin_coords.Y);
                drag_begin_coords.X = e.Location.X;
                drag_begin_coords.Y = e.Location.Y;
                if (timer1.Enabled == false)
                    DisplayWorld(world);
            }
            else if (select && drag)
            {
                DisplayWorld(world);
                int W, H, X, Y;
                X = drag_begin_coords.X - (drag_begin_coords.X % resolution) + ((off_x + drag_offset.X) % resolution);
                Y = drag_begin_coords.Y - (drag_begin_coords.Y % resolution) + ((off_y + drag_offset.Y) % resolution);
                W = (e.Location.X - drag_begin_coords.X) - (e.Location.X - drag_begin_coords.X) % resolution;
                H = (e.Location.Y - drag_begin_coords.Y) - (e.Location.Y - drag_begin_coords.Y) % resolution;
                if (W < 0)
                {
                    W = -W;
                    X = X - W;
                        }
                if (H < 0)
                {
                    H = -H;
                    Y = Y - H + resolution;
                }
                selectRect = new Rectangle(X, Y, W, H);
                graphics.DrawRectangle(selectPen, selectRect);
                Debug.WriteLine($"Selecting ");
                pictureBox1.Refresh();
                
            }
            else if (e.Button == MouseButtons.Left)
            {
                Coords mouse_coords = new Coords(e.Location.X, e.Location.Y);
                Debug.WriteLine($"Alive on  {ToWorldCoords(mouse_coords).X}  : {ToWorldCoords(mouse_coords).Y} ");
                Debug.WriteLine($"Selecting {select}");
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
