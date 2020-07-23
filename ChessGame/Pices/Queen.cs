using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessGame.Pices.Elements;

namespace ChessGame.Pices
{
    public class Queen : Pice
    {
        public Queen()
        {
        }

        public Queen(int x, int y, Players player) : base(x, y, player)
        {
            this.piceType = "Q";
        }

        public override List<Pozition> GetAllMoves(Pice[,] bord)
        {
            List<Pozition> pozitionsToMove = new List<Pozition>();

            // Look up 
            for (int i = this.pozition.pozX + 1; i < bord.GetLength(0); i++)
            {
                if (!ValidateAndGetPozition(i, this.pozition.pozY, ref bord, ref pozitionsToMove))
                    break;
            }

            // look down
            for (int i = this.pozition.pozX - 1; i >= 0; i--)
            {
                if (!ValidateAndGetPozition(i, this.pozition.pozY, ref bord, ref pozitionsToMove))
                    break;
            }

            // look left 
            for (int i = this.pozition.pozY - 1; i >= 0; i--)
            {

                if (!ValidateAndGetPozition(this.pozition.pozX, i, ref bord, ref pozitionsToMove))
                    break;
            }
            // look right
            for (int i = this.pozition.pozY + 1; i < bord.GetLength(1); i++)
            {
                if (!ValidateAndGetPozition(this.pozition.pozX, i, ref bord, ref pozitionsToMove))
                    break;
            }
            // looking down right
            for (int i = this.pozition.pozX + 1, j = this.pozition.pozY + 1; i < bord.GetLength(1) && j < bord.GetLength(0); i++, j++)
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
                if (!ValidateAndGetPozition(i, j, ref bord, ref pozitionsToMove))
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
    }
}
