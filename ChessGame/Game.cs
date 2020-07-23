using ChessGame.Pices;
using ChessGame.Pices.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    public class Game
    {
        private bool gameState;
        private Players[] listOfPlayers;
        private Pice[,] bord;

        public Game(int x, int y, Players[] players)
        {
            gameState = false;
            Init(x, y ,players);
        }

        public void Init(int x, int y,Players[] players)
        {
            bord = new Pice[x, y];
            listOfPlayers = players;
            for (int i = 0; i < listOfPlayers.Length; i++)
            {
                foreach(Pice p in listOfPlayers[i].playerPices)
                {
                    bord[p.pozition.pozX, p.pozition.pozY] = p;
                }
            }
        }

        public void playGame()
        {
            int playerTurn = 0;
            while (!gameState)
            {
                PrintBord();
                Console.WriteLine("Player" + listOfPlayers[playerTurn].playerNumber + " next to move");
                Console.WriteLine("select pozition x :");
                int x = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("select Pozition y :");
                int y = Convert.ToInt16(Console.ReadLine());

                Pice selectedPice = bord[x, y];
                if(selectedPice == null && !listOfPlayers[playerTurn].playerPices.Contains(bord[x,y]))
                {
                    continue;
                }
                List<Pozition> poz = selectedPice.GetAllMoves(this.bord);
                // implement later a way to stop mooving foward till we select where to move
                PrintPozitions(poz);

                Console.WriteLine("select pozition x :");
                int chozePozition = Convert.ToInt16(Console.ReadLine());

                Pozition newPozition = poz[chozePozition];

                if (bord[newPozition.pozX, newPozition.pozY] != null) {
                    bord[newPozition.pozX, newPozition.pozY].player.DeletePice(bord[newPozition.pozX, newPozition.pozY]);
                }
                bord[x, y] = null;
                bord[newPozition.pozX, newPozition.pozY] = selectedPice;
                selectedPice.pozition = newPozition; 

                playerTurn = (playerTurn + 1) % listOfPlayers.Length;
            }
        }

        public void PrintBord()
        {
            for(int i = 0; i < bord.GetLength(0); i++)
            {
                for(int j = 0; j < bord.GetLength(1);j++)
                {
                    if (bord[i, j] == null)
                        Console.Write(". ");
                    else
                    {
                        Console.Write(bord[i, j].piceType + " ");
                    }
                }
                Console.WriteLine();
            }
        }

        public void PrintPozitions(List<Pozition> listToMove)
        {
            int count = 0;
            foreach(Pozition poz in listToMove)
            {
                Console.WriteLine(count + " " + poz.pozX + " " + poz.pozY);
                count++;
            }
        }

        
    }
}
