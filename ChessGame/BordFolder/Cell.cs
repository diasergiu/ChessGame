using ChessGame.Pices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.BordFolder
{
    public class Cell
    {
        private int x { get; set; }
        private int y { get; set; }
        //private Enum cellType { get; set; }
        public Pice pice { get; set; }
    }

}
