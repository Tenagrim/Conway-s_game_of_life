using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Conway_s_game_of_life
{
    [Serializable]
    class World
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public bool[,] Field { get { return field; } }
        public bool[,] init_state { get; }
        public bool Bordered { get; set; }
        public int Generation { get { return generation; } }

        private int generation;
        private bool[,] field;
        public World(int width, int height, bool bordered)
        {
            field = new bool[height, width];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    field[i, j] = false;
                }
            }
            Width = width;
            Height = height;
            Bordered = bordered;
            this.generation = 0;
        }

        public World(bool[,] new_field, bool bordered)
        {
            field = new_field;
            Width = new_field.GetLength(1);
            Height = new_field.GetLength(0);
            Bordered = bordered;
            this.generation = 0;
        }

        public void SetField(bool[,] new_field)
        {
            field = new_field;
        }
        public void FillRandom(int density)
        {
            Random rand = new Random();
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    if (rand.Next() % density == 0)
                    {
                        field[i, j] = true;
                       // Debug.Write("1 ");
                    }//else
                     //   Debug.Write("0 ");
                }
               // Debug.Write("\n ");
            }
        }

        private bool GetStateTorus(int x, int y)
        {
            int neighbours;
            int i,j,i_c,j_c;

            i = y - 1 >= 0 ? y - 1 : Height- 1;
            j = x - 1 >= 0 ? x - 1 : Width - 1;
            i_c = 0;
            neighbours = 0;
            while (i_c < 3)
            {
                j_c = 0;
                j = x - 1 >= 0 ? x - 1 : Width - 1;
                while (j_c < 3)
                {
                    if (!(i_c == 1 && j_c == 1))
                    {
                        //printf("%d %d %d\n",i, j, cells[i][j] );
                        if (field[i,j])
                            neighbours++;
                    }
                    j = j + 1 == Width ? 0 : j + 1;
                    j_c++;
                }
                i = i + 1 == Height ? 0 : i + 1;
                i_c++;
            }
            //printf("x: %d y: %d neigh: %d\n", x, y, neighbours);
            if (field[y,x])
            {
                if (neighbours == 2 || neighbours == 3)
                    return (true);
                else
                    return (false);
            }
            else
            {
                if (neighbours == 3)
                    return (true);
                else
                    return (false);
            }

        }

        private bool GetStateBordered(int x, int y)
        {
            int neighbours;
            int up, down, left, right;
            up = y - 1 < 0 ? 0 : y - 1;

            down = y + 1 == Height ? Height - 1 : y + 1;
            left = x - 1 < 0 ? 0 : x - 1;
            right = x + 1 == Width ? Width - 1 : x + 1;
            neighbours = 0;
            while (up <= down)
            {
                left = x - 1 < 0 ? 0 : x - 1;
                while (left <= right)
                {
                    if (!(left == x && up == y))
                    {
                        //printf("%d %d %d\n",i, j, cells[i][j] );
                        if (field[up,left])
                            neighbours++;
                    }
                    left++;
                }
                up++;
            }
            //printf("x: %d y: %d neigh: %d\n", x, y, neighbours);
            if (field[y,x] )
            {
                if (neighbours == 2 || neighbours == 3)
                    return (true);
                else
                    return (false);
            }
            else
            {
                if (neighbours == 3)
                    return (true);
                else
                    return (false);
            }
        }

        private bool GetState(int x, int y)
        {
            if (Bordered)
                return GetStateBordered(x, y);
            else
                return GetStateTorus(x, y);
        }

        private bool[,] GetNextGeneration()
        {
            bool[,] res = new bool[Height, Width];
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    res[i, j] = GetState(j, i);
                }
            }
            return (res);
        }

        public void Step()
        {
            this.generation++;
            bool[,] tmp = field;
            field = GetNextGeneration();
            //GC.Collect();
        }

        private bool InWorld(Coords pos)
        {
            if (pos.X < 0 || pos.X >= Width || pos.Y < 0 || pos.Y >= Height)
                return false;
            else
                return true;
        }
        private bool InWorld(int x, int y)
        {
            if (x < 0 || x >= Width || y < 0 || y >= Height)
                return false;
            else
                return true;
        }
        private bool InWorld(Coords pos, int w, int h)
        {
            if (pos.X < 0 || pos.X >= Width || pos.Y < 0 || pos.Y >= Height || pos.X + w >= Width || pos.Y + h >= Height)
                return false;
            else
                return true;
        }
        private bool InWorld(Coords pos, Brush brush)
        {
            if (pos.X - brush.Width / 2 < 0 || pos.Y - brush.Height / 2 < 0 || pos.X + brush.Width / 2 >= Width || pos.Y + brush.Height / 2 >= Height)
                return false;
            else
                return true;
        }

        public void Alive(Coords pos)
        {
            if (!InWorld(pos))
                return;
            field[pos.Y, pos.X] = true;
        }

        public void Kill(Coords pos)
        {
            if (!InWorld(pos))
                return;
            field[pos.Y, pos.X] = false;
        }

        public void Kill(Coords pos, int w, int h)
        {
            if (!InWorld(pos, w, h))
                return ;
            Debug.WriteLine($"Kill {pos.X} {pos.Y}  {w}  {h}");
            for (int i = pos.Y; i < pos.Y+h; i++)
            {
                for (int j = pos.X; j <pos.X+w; j++)
                {
                    field[i, j] = false;
                }
            }
        }

        public bool[,] GetArea(Coords pos, int w, int h)
        {
            bool[,] res;
            if (!InWorld(pos, w, h))
            {
              res = new bool[1, 1];
                res[0,0] = true;
                return res;
            }
            res = new bool[h, w];

            for (int i = 0; i <  h; i++)
            {
                for (int j = 0; j <  w; j++)
                {
                    res[i , j ] = field[i+pos.Y, j+ pos.X];
                }
            }
            return res;
        }

        public void BrushStamp(Brush brush, Coords pos)
        {
            int k, l;
           // if (!InWorld(pos, brush))
               // return;
            for (int i = 0; i < brush.Height; i++)
            {
                for (int j = 0; j < brush.Width; j++)
                {
                    k =pos.X+ j - brush.Width / 2;
                    l = pos.Y + i - brush.Height / 2;
                    if(InWorld(k,l))
                        field[l,k] = brush.Field[i , j] || field[l,k];
                }
            }
        }
    }
}
