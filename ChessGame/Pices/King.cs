using ChessGame.Pices.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.Pices
{
    public class King : Pice
    {
        public King(int x, int y, Players player) : base(x, y, player)
        {
            this.piceType = "KK";
        }

        public override List<Pozition> GetAllMoves(Pice[,] bord)
        {
            List<Pozition> listToMove = new List<Pozition>();
            ValidateAndGetPozition(this.pozition.pozX + 1, this.pozition.pozY + 1,ref bord,ref listToMove);
            ValidateAndGetPozition(this.pozition.pozX + 1, this.pozition.pozY, ref bord, ref listToMove);
            ValidateAndGetPozition(this.pozition.pozX + 1, this.pozition.pozY - 1, ref bord, ref listToMove);
            ValidateAndGetPozition(this.pozition.pozX, this.pozition.pozY + 1, ref bord, ref listToMove);
            ValidateAndGetPozition(this.pozition.pozX, this.pozition.pozY - 1, ref bord, ref listToMove);
            ValidateAndGetPozition(this.pozition.pozX - 1, this.pozition.pozY, ref bord, ref listToMove);
            ValidateAndGetPozition(this.pozition.pozX - 1, this.pozition.pozY - 1, ref bord, ref listToMove);
            ValidateAndGetPozition(this.pozition.pozX - 1, this.pozition.pozY + 1, ref bord, ref listToMove);

            return listToMove;
        }
    }
}
