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
            CardStock deck = new CardStock();
            foreach (Player plyr in players)
                plyr.reset();
            deck.distribute(players);
        }

        public bool isOver()
        {
            if (players[1].lose())
            {
                if (players[0].lose()) // two players are loos - when they have the same values again and again.
                    Console.WriteLine("No Winners\n");
                else Console.WriteLine("First Player Won!\n");//first player won (second player lost and first player not)
                return true;
            }
            else if (players[0].lose())
            {
                Console.WriteLine("Second Player Won!\n"); //second player won (first player lost and second player not)
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public int nextMove()
        {
            if (!isOver())
            {
                Cards first, second;
                first = players[0].pickACard();
                second = players[1].pickACard();

                if (first.CompareTo(second) > 0)
                {
                    players[0].addCards(first, second);
                    return 1;
                }
                else if (first.CompareTo(second) < 0)
                {
                    players[1].addCards(first, second);
                    return -1;
                }
                else // the cards are equal and stat war
                {
                    return nextMove(keepFour(), first, second);
                }
            }

        }

        private int nextMove(params Cards[] keeper)
        {
            Cards first, second;
            first = players[0].pickACard();
            second = players[1].pickACard();

            if (first.CompareTo(second) > 0)
            {
                //players[0].addCards(first, second);
                return 1;
            }
            else if (first.CompareTo(second) < 0)
            {
                //players[1].addCards(first, second);
                return -1;
            }
            else // the cards are equal and continue the war
            {
                return nextMove(keepFour(), first, second);
            }
        }

        private Cards[] keepFour()
        {
            Cards[] keeper = new Cards[4];
            int yield  = 0;
            for (int i =0;  i<2; i++)
            {
                if (!isOver())
                {
                    keeper[yield] = players[0].pickACard();
                    keeper[yield] = players[1].pickACard();
                }
            }
            return keeper;
        }
    }
}