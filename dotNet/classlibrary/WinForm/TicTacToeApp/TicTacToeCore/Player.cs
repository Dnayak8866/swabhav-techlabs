using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeCore
{
   public  class Player
    {
        private string _name;
        private MarkType _mark;

        public Player(string name,MarkType mark)
        {
            this._name = name;
            this._mark = mark;
        }

        public MarkType Mark
        {
            get
            {
                return _mark;
            }
        }

        public string Name
        {
            get
            {
                return this._name;
            }
        }

    }
}
