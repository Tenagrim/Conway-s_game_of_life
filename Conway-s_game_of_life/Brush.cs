using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conway_s_game_of_life
{
    [Serializable]
    class Brush
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public string Name { get; set; }
        public bool[,] Field { get { return field; } }
        private bool[,] field;

        public Brush(bool[,] new_field, string name)
        {
            Name = name;
            field = new_field;
            Width = new_field.GetLength(1);
            Height = new_field.GetLength(0);
        }
        public Brush()
        {
            Width = 1;
            Height = 1;
            Name = "Default Brush";
            field = new bool[1, 1];
            field[0, 0] = true;
        }

        public void TurnLeft()
        {
            bool[,] res = new bool[Width, Height];
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    res[i, j] = field[j , Width - i -1 ];
                }
            }
            field = res;
            int tmp = Width;
            Width = Height;
            Height = tmp;
        }
        public void TurnRight()
        {
            bool[,] res = new bool[Width, Height];
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    res[i, j] = field[Height - j -1, i];
                }
            }
            field = res;
            int tmp = Width;
            Width = Height;
            Height = tmp;
        }
        public void MirrorVertical()
        {
            bool[,] res = new bool[Height, Width];

            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    res[i, j] = field[Height - i -1 , j];
                }
            }
            field = res;
        }
        public void MirrorHorizontal()
        {
            bool[,] res = new bool[Height, Width];

            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    res[i, j] = field[i, Width - j - 1];
                }
            }
            field = res;
        }
    }
}
