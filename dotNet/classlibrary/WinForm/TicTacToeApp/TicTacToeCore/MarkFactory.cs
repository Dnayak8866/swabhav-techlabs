using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeCore
{
   public abstract  class MarkFactory
    {
       
        public static MarkType Nought
        {
            get
            {
                return new Nought();
            }
        }

        public static MarkType Cross
        {
            get
            {
                return new Cross();
            }
        }

        public static MarkType NoValue
        {
            get
            {
                return new NoValue();
            }
        }
    }
}
