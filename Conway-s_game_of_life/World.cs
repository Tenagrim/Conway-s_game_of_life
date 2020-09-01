using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Conway_s_game_of_life
{
    class World
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public bool[,] Field { get { return field; } }
        public bool[,] init_state { get; }
        public bool Bordered { get; set; }
        public int Generetion { get { return generation; } }

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
            field = GetNextGeneration();
        }
    }
}
