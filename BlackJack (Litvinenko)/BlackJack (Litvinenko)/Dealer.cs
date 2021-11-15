using System;

namespace BlackJack__Litvinenko_
{
    class Dealer : Player
	{
        public Dealer()
        {
            
        }

      
        public void Show_dealer_hand()
        {
			hand[0].Show();

			Console.BackgroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Write("\u2593\u2593\u2593\u2593\u2593\u2593\u2593");
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.Write("\u2588\n");
			Console.BackgroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Write("\u2593\u2593\u2593\u2593\u2593\u2593\u2593");
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.Write("\u2588\n");
			Console.BackgroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Write("\u2593\u2593\u2593\u2593\u2593\u2593\u2593");
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.Write("\u2588\n");
			Console.BackgroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Write("\u2593\u2593\u2593\u2593\u2593\u2593\u2593");
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.Write("\u2588\n");
			Console.BackgroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Write("\u2593\u2593\u2593\u2593\u2593\u2593\u2593");
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.Write("\u2588\n");


			Console.BackgroundColor = ConsoleColor.Blue;
			Console.ForegroundColor = ConsoleColor.Black;
			Console.WriteLine();
		}
		public int Open_card_value()
        {
			return hand[0].value;
		}

       
    }
}
