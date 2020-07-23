using ChessGame.Pices.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.Pices
{
    public class Bishop : Pice
    {
        public Bishop()
        {
        }

        public Bishop(int x, int y, Players player) : base(x, y, player)
        {
            this.piceType = "B";
        }

        public override List<Pozition> GetAllMoves(Pice[,] bord)
        {
            List<Pozition> pozitionsToMove = new List<Pozition>();
            // looking down right
            for(int i  = this.pozition.pozX + 1, j = this.pozition.pozY + 1; i < bord.GetLength(1) && j < bord.GetLength(0);i++, j++)
            {
                if (!ValidateAndGetPozition(i, j, ref bord, ref pozitionsToMove))
                    break;
            }
            // looking down left
            for (int i = this.pozition.pozX + 1, j = this.pozition.pozY - 1; i < bord.GetLength(1) && j >= 0; i++, j--)
            {
                if (!ValidateAndGetPozition(i, j, ref bord, ref pozitionsToMove))
                    break;
            }
            // looking up right
            for (int i = this.pozition.pozX - 1, j = this.pozition.pozY + 1; i >= 0 && j < bord.GetLength(0); i--, j++)
            {
                if(!ValidateAndGetPozition(i, j, ref bord, ref pozitionsToMove))
                    break;
            }
            // looking up left
            for (int i = this.pozition.pozX - 1, j = this.pozition.pozY - 1; i >= 0 && j >= 0; i--, j--)
            {
                if (!ValidateAndGetPozition(i, j, ref bord, ref pozitionsToMove))
                    break;
            }


            return pozitionsToMove;
        }

        //private void ValidateAndGetPozition(int x, int y, ref Pice[,] bord, ref List<Pozition> pozitionsToMove)
        //{
        //    if(bord[x,y] == null)
        //    {
        //        pozitionsToMove.Add(new Pozition(x, y));
        //        return;
        //    }
        //    if (bord[x, y].player == this.player)
        //        return;
        //    else
        //    {
        //        pozitionsToMove.Add(new Pozition(x, y));
        //    }
        //}

    }
}
