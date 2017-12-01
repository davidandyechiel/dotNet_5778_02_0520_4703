using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dotNet5778_02_0520_4703
{
    public class Player
    {
        string name;
        System.Collections.Generic.Queue<Cards> hand;

        public void addCards(params Cards[] cards)
        {
            foreach (Cards i in cards)
                hand.Enqueue(i);
        }
        public override string ToString()
        {
              return "The player " + name + "has " + hand.LongCount() + " cards:\n" + hand;
        }


        public bool lose() 
        {
            if (hand == null)
                return true;
            return false;            
        }
        
        public Cards pickACard()
        {
            return hand.Dequeue();
        }
    }
}