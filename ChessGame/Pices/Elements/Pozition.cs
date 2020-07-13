using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.Pices.Elements
{
    public class Pozition
    {
        public int pozX { get; set; }
        public int pozY { get; set; }

        public Pozition(int pozX, int pozY)
        {
            this.pozX = pozX;
            this.pozY = pozY;
        }

        public Pozition Clone()
        {
            return new Pozition(this.pozX, this.pozY);
        }

    }
}
