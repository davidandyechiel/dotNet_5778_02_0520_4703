using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace dotNet5778_02_0520_4703
{
    public class CardStock
    {
        private List<Cards> Cards;

        public CardStock()
        {
            throw new System.NotImplementedException();
        }

        public void MixDeck(List<Cards> myCards)
        {
            throw new System.NotImplementedException();
        }

        public List<Cards> ToString()
        {
            throw new System.NotImplementedException();
        }

        public void distribute(params Player[] players)
        {
            foreach (Player p in players)
            {
                p.AddCards(players.Length,ref Cards)
            }
            throw new System.NotImplementedException();
        }
    }
}