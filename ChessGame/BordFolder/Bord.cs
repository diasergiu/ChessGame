using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.BordFolder
{
    public class Bord
    {
        public Cell[,] bord;

        public Bord(int x, int y)
        {
            bord = new Cell[x, y];
        }
    }
}
