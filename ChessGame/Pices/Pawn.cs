using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessGame.Pices.Elements;

namespace ChessGame.Pices
{
    // dont forget about the enpusant, 
    // dont forget that now if the pawn didnt move he can jump a pice
    // don forget about promotion
    public class Pawn : Pice
    {
        public bool moved;

        public Pawn(int x, int y, Players player) : base(x, y, player)
        {
            this.piceType = "p";
        }

        public override List<Pozition> GetAllMoves(Pice[,] bord)
        {
            if (this.player.playerNumber == 1)
                return GetAllMoves(bord, 1);
            return GetAllMoves(bord, -1);
        }

        public List<Pozition> GetAllMoves(Pice[,] bord, int up)
        {
            List<Pozition> pozitionToMove = new List<Pozition>();

            if (!moved)
            {
                if(bord[this.pozition.pozX + (up * 2), this.pozition.pozY] == null)
                {
                    pozitionToMove.Add(new Pozition(this.pozition.pozX + (up * 2), this.pozition.pozY));
                }
            }

            if (bord[this.pozition.pozX + up, this.pozition.pozY].player == null)
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
