using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackJack__Litvinenko_
{
    class Player
	{
        protected List<Card> hand = new List<Card>();

        public Player()
        {
           
        }

		public void Get_card(Card source)
		{
			hand.Add(source);
		}
		public int Get_size()
		{
			return hand.Count();
		}
		public int Check_summ()
		{
			int summ = 0;
			for (int i = 0; i < hand.Count(); i++)
			{
				summ += hand[i].value;
			}

			for (int i = 0; i < hand.Count(); i++)
			{
				if ((14 == hand[i].rank) && (summ > 21) && (hand[i].value != 1))                    //Если сумма очков перевалила за 21 и в твердой руке есть туз     
				{
					summ -= 10;
					hand[i].value = 1;                                                              //Превращаем твердую руку в мягкую
				}
			}

			return summ;

		}

        public void Show_hand()
        {
            for (int i = 0; i < hand.Count(); i++)
            {
                hand[i].Show();
            }
        }

	}
}
