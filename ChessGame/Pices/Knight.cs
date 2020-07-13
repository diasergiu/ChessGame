using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessGame.Pices.Elements;

namespace ChessGame.Pices
{
    class Knight : Pice
    {
        public override List<Pozition> GetAllMoves(int[,] bord)
        {
            List<Pozition> pozitionsToMove = new List<Pozition>();
            if (this.pozition.pozX + 2 < bord.GetLength(0) && this.pozition.pozY + 1 < bord.GetLength(1)
                && DiferentPlayer(bord, new Pozition(this.pozition.pozX + 2, this.pozition.pozY + 1)))
                    pozitionsToMove.Add(new Pozition(this.pozition.pozX + 2, this.pozition.pozY + 1));

            if (this.pozition.pozX + 1 < bord.GetLength(0) && this.pozition.pozY + 2 < bord.GetLength(1)
                && DiferentPlayer(bord, new Pozition(this.pozition.pozX + 2, this.pozition.pozY + 1)))
                pozitionsToMove.Add(new Pozition(this.pozition.pozX + 1, this.pozition.pozY + 2));

            // trebuie sa mai fac asta de 6 ori 
            return pozitionsToMove;
        }

    }
}
