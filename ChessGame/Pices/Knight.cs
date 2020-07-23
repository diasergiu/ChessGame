using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessGame.Pices.Elements;

namespace ChessGame.Pices
{
    public class Knight : Pice
    {
        public Knight(int x, int y, Players player) : base(x, y, player)
        {
            this.piceType = "K";
        }

        public override List<Pozition> GetAllMoves(Pice[,] bord)
        {
            List<Pozition> pozitionsToMove = new List<Pozition>();

            ValidateAndGetPozition(this.pozition.pozX + 2, this.pozition.pozY + 1, ref bord, ref pozitionsToMove);
            ValidateAndGetPozition(this.pozition.pozX + 1, this.pozition.pozY + 2, ref bord, ref pozitionsToMove);
            ValidateAndGetPozition(this.pozition.pozX - 2, this.pozition.pozY + 1, ref bord, ref pozitionsToMove);
            ValidateAndGetPozition(this.pozition.pozX - 1, this.pozition.pozY + 2, ref bord, ref pozitionsToMove);
            ValidateAndGetPozition(this.pozition.pozX - 2, this.pozition.pozY - 1, ref bord, ref pozitionsToMove);
            ValidateAndGetPozition(this.pozition.pozX - 1, this.pozition.pozY - 2, ref bord, ref pozitionsToMove);
            ValidateAndGetPozition(this.pozition.pozX + 2, this.pozition.pozY - 1, ref bord, ref pozitionsToMove);
            ValidateAndGetPozition(this.pozition.pozX + 1, this.pozition.pozY - 2, ref bord, ref pozitionsToMove);
            
            return pozitionsToMove;
        }

        //public void ValidateAndGetPozition(int x, int y,ref Pice[,] bord, ref List<Pozition> pozitionsToMove)
        //{
        //    if (x < bord.Length && x >= 0 && y >= 0 && y < bord.Length && DiferentPlayer(bord, new Pozition(x, y))){
        //        pozitionsToMove.Add(new Pozition(x, y));
        //    }
        //}

    }
}
