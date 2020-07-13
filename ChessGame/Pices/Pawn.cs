using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessGame.Pices.Elements;

namespace ChessGame.Pices
{
    class Pawn : Pice
    {
        public override List<Pozition> GetAllMoves(int[,] bord)
        {
            if (this.player == 1)
                return GetAllMoves(bord, 1);
            return GetAllMoves(bord, -1);
        }

        public List<Pozition> GetAllMoves(int[,] bord, int up)
        {
            List<Pozition> pozitionToMove = new List<Pozition>();
            if (bord[this.pozition.pozX + up, this.pozition.pozY] == 0)
                pozitionToMove.Add(new Pozition(this.pozition.pozX + up , this.pozition.pozY));

            Pozition newPozition = new Pozition(this.pozition.pozX + up, this.pozition.pozY + 1);

            if(DiferentPlayer(bord, newPozition))
                pozitionToMove.Add(newPozition.Clone());

            newPozition.pozY -= 2;

            if (DiferentPlayer(bord, newPozition))
                pozitionToMove.Add(newPozition.Clone());

            return pozitionToMove;
        }
 
        private Pice Promote(Pice newPice)
        {
            throw new NotImplementedException();
        }
    }
}
