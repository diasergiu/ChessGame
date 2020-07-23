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
        public Players player { get; set; }
        public Pozition pozition { get; set; }
        public Image image { get; set; }
        public String piceType { get; set; }
        public abstract List<Pozition> GetAllMoves(Pice[,] bord);

        public Pice(int x, int y, Players player)
        {
            this.pozition = new Pozition(x, y);
            this.player = player;
        }

        // for bord initialization
        public Pice()
        {

        }

        protected bool DiferentPlayer(Pice[,] bord, Pozition pozition)
        {
            if (this.player != bord[pozition.pozX, pozition.pozY].player) {
                return true;
            }
            return false;
        }

        protected bool ValidateAndGetPozition(int x, int y, ref Pice[,] bord, ref List<Pozition> pozitionsToMove)
        {
            // for hte knight
            if( x < 0 && x > bord.Length && y < 0 && y > bord.Length)
            {
                return false;
            }
            // for the rest the pices 
            if (bord[x, y] == null)
            {
                pozitionsToMove.Add(new Pozition(x, y));
                return true;
            }
            if (bord[x, y].player == this.player)
                return false;

            pozitionsToMove.Add(new Pozition(x, y));
            return false;
        }



    }
}
