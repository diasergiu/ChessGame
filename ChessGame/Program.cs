using ChessGame.Pices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessGame
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            // builder pathern

            //Players player1 = new Players(0);
            //Players player2 = new Players(1);

            ////White Pices
            //Pice WhiteRook = new Rook(7, 0, player1);
            //player1.playerPices.Add(WhiteRook);
            //Pice SecondWhiteRook = new Rook(2, 2, player1);
            //player1.playerPices.Add(SecondWhiteRook);
            //Pice WhiteKing = new King(3, 3, player1);
            //player1.playerPices.Add(WhiteKing);

            //// BlackPices
            //Pice blackRook = new Rook(7, 7, player2);
            //player2.playerPices.Add(blackRook);
            //Pice BlackBishop = new Bishop(5, 5, player2);
            //player2.playerPices.Add(BlackBishop);

            //Players[] listOfPlayers = new Players[2];
            //listOfPlayers[0] = player1;
            //listOfPlayers[1] = player2;

            //Game game = new Game(8, 8, listOfPlayers);
            //game.playGame();
        }
    }
}
