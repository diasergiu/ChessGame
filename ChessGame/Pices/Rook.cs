using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessGame.Pices.Elements;

namespace ChessGame.Pices
{
    class Rook : Pice
    {
        public override List<Pozition> GetAllMoves(int[,] bord)
        {
            List<Pozition> pozitionsToMove = new List<Pozition>();

        // Look up 
        for(int i = this.pozition.pozX + 1; i < bord.GetLength(1); i++)
            {
                if (bord[i, this.pozition.pozY] == this.player)
                    break;
                else {
                    pozitionsToMove.Add(new Pozition(i, this.pozition.pozY));
                    if(DiferentPlayer(bord, new Pozition(i, this.pozition.pozY)))
                        break;
                }
            }
            // look down
            for (int i = this.pozition.pozX - 1; i >= 0; i--)
            {
                if (bord[i, this.pozition.pozY] == this.player)
                    break;
                else
                {
                    pozitionsToMove.Add(new Pozition(i, this.pozition.pozY));
                    if (DiferentPlayer(bord, new Pozition(i, this.pozition.pozY)))
                        break;
                }
            }

            // look left 
            for (int i = this.pozition.pozY - 1; i >= 0; i--)
            {
                if (bord[this.pozition.pozX, i] == this.player)
                    break;
                else
                {
                    pozitionsToMove.Add(new Pozition(this.pozition.pozX, i));
                    if (DiferentPlayer(bord, new Pozition(this.pozition.pozX, i)))
                        break;
                }
            }
            // look right
            for (int i = this.pozition.pozY + 1; i >= 0; i++)
            {
                if (bord[this.pozition.pozX, i] == this.player)
                    break;
                else
                {
                    pozitionsToMove.Add(new Pozition(this.pozition.pozX, i));
                    if (DiferentPlayer(bord, new Pozition(this.pozition.pozX, i)))
                        break;
                }
            }

            return pozitionsToMove;
        }

        public 

        
    }
}
