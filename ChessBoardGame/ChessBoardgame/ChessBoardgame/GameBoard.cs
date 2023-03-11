using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardgame
{
    public class GameBoard
    {
        public int Size { get; set; }
         //2d array
        public Cell[,] Grid { get; set; }
        // constructor 
        public GameBoard(int s) {
            // initialize size of the board is defined by s
            Size = s;
            Grid = new Cell[Size, Size];
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    Grid[i,j] = new Cell(i, j);
                }
            }
        }
    }
}
