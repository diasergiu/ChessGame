using ChessGame.Pices;
using ChessGame.Pices.Elements;
using System;
using System.Collections.Generic;

namespace ChessGame
{
    public class Players
    {
        public List<Pice> playerPices;
        public int playerNumber { get; set; }

        public Players(int playerNumber)
        {
            this.playerPices = new List<Pice>();
            this.playerNumber = playerNumber;
        }

        public void DeletePice(Pice deletePice)
        {
            playerPices.Remove(deletePice);
        }
    }
}