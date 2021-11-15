using System;
using System.Collections.Generic;

namespace BlackJack__Litvinenko_
{
    class Card_deck
	{

		Stack<Card> deck { get; set; }
		
	public Card_deck()
        {
            deck = new Stack<Card>();

            Card[] array_card = new Card[52];

			for (int i = 0; i < 52;)
			{
				for (int j = 2; j <= 14; j++)
				{
					for (int k = 1; k <= 4; k++)
					{
                        array_card[i] = new Card();
						array_card[i].rank = j;
						array_card[i].suit = k;
						i++;
					}
				}
			}

			for (int i = 0; i < 52; i++)
			{
				if (array_card[i].rank == 14)
				{
					array_card[i].value = 11;
				}
				else if (array_card[i].rank <= 10)
				{
					array_card[i].value = array_card[i].rank;
				}
				else
				{
					array_card[i].value = 10;
				}
			}


			Random rand = new Random();

			for (int i = 0; i < 52; i++)
			{
				int j = rand.Next(i + 1);

				Card tmp = array_card[j];
				array_card[j] = array_card[i];
				array_card[i] = tmp;
			}

				for (int i = 0; i < 52; i++)
			{    
				deck.Push(array_card[i]);
			}
		}

		public void Show()
        {
			while (deck.Count != 0)
			{
				deck.Peek().Show();
				deck.Pop();
			}
		}
		public Card Hand_out()
        {
			Card tmp = deck.Pop();
			//deck.Pop();
			return tmp;
		}

	}
}
