using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeCore
{
   public  class Game
    {
        private ResultAnalyzer _analyser;
        private Board _board;
        private Player _player1;
        private Player _player2;
        private GameStatus _gameStatus;
        private Player _currentPlayer;
        private bool turn = true;

        public Game(ResultAnalyzer analyser, Board board, Player player1, Player player2)
        {
            this._gameStatus = GameStatus.ONGOING;
            this._analyser = analyser;
            this._board = board;
            this._player1 = player1;
            this._player2 = player2;
            this._currentPlayer = GetPlayerTurn();

        }

        public void play(int position)
        {

            this._currentPlayer = GetPlayerTurn();
            _board.UpdateBoard(GetPlayerTurn().Mark, position);

            this._gameStatus = _analyser.GenerateResult(_board);
            if (this._gameStatus == GameStatus.WON)
            {

            }
            else
            {
                if (turn)
                {
                    turn = false;
                }
                else
                {
                    turn = true;
                }
            }

            _board.display();
            Console.WriteLine(this._gameStatus);

        }

        public GameStatus GameStatus
        {
            get
            {
                return _gameStatus;
            }
        }

        public Player GetPlayerTurn()
        {
            if (turn)
            {
                return this._player1;
            }
            else
            {
                return this._player2;
            }

        }

        public Player GetCurrentPlayer()
        {
            return this._currentPlayer;
        }



    }
}
