using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dotNet5778_02_0520_4703
{
    public enum E_color { Black, Red };

    public class Cards : IComparable
    {
        private E_color color;
        private int num;

        public Cards(int num , E_color color)
        {
            Num = num;
            Color = color;
        }

        #region Properties
        public int Num
        {
            get
            {
                return num;
            }
            set
            {
                if (value < 2 || value > 14)
                    throw new System.NotImplementedException("Illegal value");
                num = value;
            }
        }

        internal E_color Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
            }
        }

        internal string CardName
        {
            get
            {
                switch (num)
                {
                    case (11):
                        return "Jack";
                    case (12):
                        return "Queen";
                    case (13):
                        return "King";
                    case (14):
                        return "Ace";
                    default:
                        return num.ToString();
                }
            }

        }
        #endregion

        public override string ToString()
        {
            return CardName + " " + Color;
        }

        #region IComparable Members
        public int CompareTo(object obj)
        {
            return Num.CompareTo(((Cards)obj).num);
        }
        #endregion

    }
}