using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace dotNet5778_02_0520_4703
{
    public class CardStock
    {
        public List<Cards> Card;

        private CardStock()//c-tor
        {
            Card = new List<Cards>();
            for (int i = 0; i < 13; i++)
            {
                Card.Add(new Cards(i, E_color.Black));
            }
            for (int i = 0; i < 13; i++)
            {
                Card.Add(new Cards(i, E_color.Red));
            }

           // throw new System.NotImplementedException();
        }

        public void MixDeck(List<Cards> myCards)
        {
            Random r = new Random();
            Cards temp = new Cards(1,E_color.Black);
            int i = r.Next(0,25);
            for (int j = 0; j < 26; j++)
            {
                temp = myCards[j];
                myCards[j] = myCards[i];
                myCards[i] = temp;
                i = r.Next(0, 25);//recieve the next random card to swap with

            }


            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            string AllCards = null;
            foreach (Cards C in Card)//
                AllCards += C.ToString();
            return AllCards;
          //  throw new System.NotImplementedException();
        }

        public void distribute(params Player[] players)
        {
            int i = 0;
            while (i < 26)
                { 
                foreach (Player p in players)
                {
                    if (i<26)
                        p.addCards(Card[i]);
                }
                i++;
            }
         //   throw new System.NotImplementedException();
        }

        public Cards this [string myCard]
        {
            get
            {
                foreach (Cards c in Card)
                    if (c.CardName == myCard)
                        return c;
                return null;
            }
        }

        public void sort()
        {
            Card.Sort();
        }
        public IEnumerator GetEnumerator()
        {
            return Card.GetEnumerator();
        }
        public void addCard(Cards c)
        {
            Card.Add(c);
        }
        public void removeCard(Cards c)
        {
            Card.Remove(c);
        }

    }
}