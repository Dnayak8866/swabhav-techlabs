using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeCore
{
    public class Cell
    {
        private MarkType _mark;
        private int _rowIndex;
        private int _colIndex;
        private int _position;
        
        public Cell(int rowindex,int colindex,int postion)
        {
            this._mark = MarkFactory.NoValue;
            this._rowIndex = rowindex;
            this._colIndex = colindex;
            this._position = postion;
        }

        public MarkType CellMark
        {
            get
            {
                return _mark;
            }
            set
            {
                if (this._mark.Mark != MarkFactory.NoValue.Mark)
                {
                    throw new Exception("Mark exists at this place try again..");
                }
                else
                {
                    this._mark = value;
                }
            }
           
        }
       

        public int RowIndex
        {
            get
            {
                return _rowIndex;
            }
        }

        public int ColIndex
        {
            get
            {
                return _colIndex;
            }
        }

        public int Position
        {
            get
            {
                return _position;
            }
        }

        public override string ToString()
        {
            return _mark.Mark;
        }
    }
}
