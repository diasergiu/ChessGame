using ChessGame.Pices.Elements;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.Pices
{
    public abstract class Pice
    {
        // pulbic Collor collor{get;set;} 
        public int player { get; set; } 
        public Pozition pozition { get; set; }
        public Image image { get; set; }
        public abstract List<Pozition> GetAllMoves(int[,] bord);

        protected bool DiferentPlayer(int[,] bord, Pozition pozition)
        {
            if (this.player != bord[pozition.pozX, pozition.pozY] && bord[pozition.pozX, pozition.pozY] != 0) {
                return true;
            }
            return false;
        }

    }
}
