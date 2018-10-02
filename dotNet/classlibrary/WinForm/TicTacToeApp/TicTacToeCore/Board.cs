using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeCore
{
    public class Board
    {
        private int _rows, _cols;
        private Cell[,] cells;
        private Cell cell;

        public Board(int noRow,int noCol)
        {
            this._rows = noRow;
            this._cols = noCol;
            this.cells = new Cell[this._rows,this._cols];
            InitializeBoard();
        }

        public int NoRows
        {
            get
            {
                return _rows;
            }
        }

        public int NoCols
        {
            get
            {
                return _cols;
            }
        }

        public Cell[,] Cells
        {
            get
            {
                return cells;
            }
        }
        public  void InitializeBoard()
        {
            int position = 0;
            for (int i=0;i<_rows;i++)
            {
                for (int j=0;j<_cols;j++)
                {
                    position++;
                    cells[i, j] = new Cell(i,j,position);
                }
            }
        }

        public void UpdateBoard(MarkType mark,int postion)
        {
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _cols; j++)
                {
                    if (cells[i,j].Position==postion)
                    {
                        cells[i, j].CellMark=mark;
                    }
                   
                }
            }
        }

       
        public void display()
        {
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _cols; j++)
                {
                    if ((j + 1) == _cols)
                    {
                        Console.Write(" " + cells[i,j]);
                    }
                    else
                    {
                        Console.Write(" " + cells[i,j] + " |");
                    }
                }
                if (i + 1 == _rows)
                {

                }
                else
                {
                    Console.WriteLine("\n--- --- --- ");
                }
            }
            Console.Write("\n");
        }


    }
}
