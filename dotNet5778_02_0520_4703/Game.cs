using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dotNet5778_02_0520_4703
{
    public class Game
    {
        private CardStock deck;
        Player[] players = new Player[2];

        public void startAgain()
        {

        }

        public void isOver()
        {
            if (players[1].lose())
                if (players[0].lose())
                    Console.WriteLine("No Winners\n");
                else Console.WriteLine("First Player Won!\n");
            else if (players[0].lose())
                Console.WriteLine("Second Player Won!\n");
        }

        private int stillIn(Player[] players)
        {
            int i = 0;
            foreach (Player plyr in players)
                if (!plyr.lose())
                    i++;
            return i;
        }

        public override string ToString()
        {
            return base.ToString();
        }
        public void nextMove()
        {

        }

    }
}