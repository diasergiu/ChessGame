using ChessGame.Pices.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.Pices
{
    class Bishop : Pice
    {
        public override List<Pozition> GetAllMoves(int[,] bord)
        {
            List<Pozition> pozitionsToMove = new List<Pozition>();
            // looking down right
            for(int i  = this.pozition.pozX + 1, j = this.pozition.pozY + 1; i < bord.GetLength(1) && j < bord.GetLength(0);i++, j++)
            {
                if (bord[i, j] == this.player)
                    break;
                else
                {
                    pozitionsToMove.Add(new Pozition(i, j));
                    if (DiferentPlayer(bord, new Pozition(i, j)))
                        break;
                }
            }
            // looking down left
            for (int i = this.pozition.pozX + 1, j = this.pozition.pozY - 1; i < bord.GetLength(1) && j >= 0; i++, j--)
            {
                if (bord[i, j] == this.player)
                    break;
                else
                {
                    pozitionsToMove.Add(new Pozition(i, j));
                    if (DiferentPlayer(bord, new Pozition(i, j)))
                        break;
                }
            }
            // looking up right
            for (int i = this.pozition.pozX - 1, j = this.pozition.pozY + 1; i >= 0 && j < bord.GetLength(0); i--, j++)
            {
                if (bord[i, j] == this.player)
                    break;
                else
                {
                    pozitionsToMove.Add(new Pozition(i, j));
                    if (DiferentPlayer(bord, new Pozition(i, j)))
                        break;
                }
            }

            for (int i = this.pozition.pozX - 1, j = this.pozition.pozY - 1; i >= 0 && j >= 0; i--, j--)
            {
                if (bord[i, j] == this.player)
                    break;
                else
                {
                    pozitionsToMove.Add(new Pozition(i, j));
                    if (DiferentPlayer(bord, new Pozition(i, j)))
                        break;
                }
            }


            return pozitionsToMove;
        }
    }
}
