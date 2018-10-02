using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeCore
{
   public class ResultAnalyzer
    {
        private Board _board;
        private Cell[,] cells;
        private GameStatus _gameStatus;

        public ResultAnalyzer(Board board)
        {
            this._board = board;
            this.cells = this._board.Cells;
        }

        public GameStatus GenerateResult(Board board)
        {
            this._board = board;
            bool result;
            for (int i = 0; i < _board.NoRows; i++)
            {
                for (int j = 0; j < _board.NoCols; j++)
                {
                    if (!(cells[i,j].CellMark.Mark == MarkFactory.NoValue.Mark))
                    {
                        // analyze the cell
                        result = AnalyzeCell(cells[i,j].Position);
                        if (result)
                        {
                            return this._gameStatus = GameStatus.WON;

                        }
                        else
                        {
                            this._gameStatus = GameStatus.ONGOING;
                        }
                    }
                }
            }

            if (CheckDrawCase() && (this._gameStatus == GameStatus.ONGOING))
            {
                this._gameStatus = GameStatus.DRAW;
            }

            return this._gameStatus;
        }

        private bool AnalyzeCell(int position)
        {
            switch (position)
            {
                case 1:
                    if (CheckHorizontalWin(0) || CheckVerticalWin(0)
                            || CheckDiagonalWin())
                    {
                        return true;
                    }
                    break;

                case 2:
                    if (CheckHorizontalWin(0) || CheckVerticalWin(1))
                    {
                        return true;
                    }
                    break;
                case 3:
                    if (CheckHorizontalWin(0) || CheckVerticalWin(2)
                            || CheckDiagonalWin())
                    {
                        return true;
                    }
                    break;
                case 4:
                    if (CheckHorizontalWin(1) || CheckVerticalWin(0))
                    {
                        return true;
                    }
                    break;
                case 5:
                    if (CheckHorizontalWin(1) || CheckVerticalWin(1)
                            || CheckDiagonalWin())
                    {
                        return true;
                    }
                    break;
                case 6:
                    if (CheckHorizontalWin(1) || CheckVerticalWin(2))
                    {
                        return true;
                    }
                    break;
                case 7:
                    if (CheckHorizontalWin(2) || CheckVerticalWin(0)
                            || CheckDiagonalWin())
                    {
                        return true;
                    }
                    break;
                case 8:
                    if (CheckHorizontalWin(2) || CheckVerticalWin(1))
                    {
                        return true;
                    }
                    break;
                case 9:
                    if (CheckHorizontalWin(2) || CheckVerticalWin(2)
                            || CheckDiagonalWin())
                    {
                        return true;
                    }
                    break;
                default:
                    return false;

            }
            return false;

        }

        public bool CheckDrawCase()
        {

            if (this._gameStatus == GameStatus.ONGOING)
            {
                for (int i = 0; i < _board.NoRows; i++)
                {
                    for (int j = 0; j < _board.NoCols; j++)
                    {
                        if (cells[i,j].CellMark.Mark == MarkFactory.NoValue.Mark)
                        {
                            return false;

                        }
                    }
                }
            }
            return true;
        }

        private bool CheckDiagonalWin()
        {

            MarkType markAtZeroZeroPosition = cells[0,0].CellMark;
            MarkType markAtTwoZeroPos = cells[2,0].CellMark;
            if (markAtZeroZeroPosition.Mark == cells[1,1].CellMark.Mark
                    && markAtZeroZeroPosition.Mark == cells[2,2].CellMark.Mark)
            {
                if (markAtZeroZeroPosition.Mark != MarkFactory.NoValue.Mark
                        && cells[1,1].CellMark.Mark != MarkFactory.NoValue.Mark
                        && cells[2,2].CellMark.Mark != MarkFactory.NoValue.Mark)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else if (markAtTwoZeroPos.Mark == cells[1,1].CellMark.Mark
                  && markAtTwoZeroPos.Mark == cells[0,2].CellMark.Mark)
            {
                if (markAtTwoZeroPos.Mark != MarkFactory.NoValue.Mark
                        && cells[1,1].CellMark.Mark != MarkFactory.NoValue.Mark
                        && cells[0,2].CellMark.Mark != MarkFactory.NoValue.Mark)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            return false;

        }

        private bool CheckVerticalWin(int col)
        {

            if (cells[0,col].CellMark.Mark == cells[1,col].CellMark.Mark)
            {
                if (cells[0,col].CellMark.Mark == cells[2,col].CellMark.Mark)
                {
                    return true;
                }
            }
            return false;
        }

        private bool CheckHorizontalWin(int row)
        {
            if (cells[row,0].CellMark.Mark == cells[row,1].CellMark.Mark)
            {
                if (cells[row,0].CellMark.Mark == cells[row,2].CellMark.Mark)
                {
                    return true;
                }
            }
            return false;
        }





    }

}
