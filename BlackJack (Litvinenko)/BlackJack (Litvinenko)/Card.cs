using System;

namespace BlackJack__Litvinenko_
{
    class Card
	{
		public int rank { get; set; }

		public int suit { get; set; }

		public int value { get; set; }


		public void Show()
        {

            char symb = 'X';
            if (rank == 11)
            {
                symb = 'J';
            }
            else if (rank == 12)
            {
                symb = 'Q';
            }
            else if (rank == 13)
            {
                symb = 'K';
            }
            else if (rank == 14)
            {
                symb = 'A';
            }
            if ((rank >= 2) && (rank < 10))
            {
                if (suit == 1)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("\u2660");
                    Console.Write(rank);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(rank);
                    Console.Write("\u2660");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("\u2588\n");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("\u2588\n");
                    
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("\u2588\n");
                   
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("\u2588\n");

                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("\u2660");
                    Console.Write(rank);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(rank);
                    Console.Write("\u2660");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("\u2588\n");



                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine();
                }
                else if (suit == 2)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\u2665");
                    Console.Write(rank);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(rank);
                    Console.Write("\u2665");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("\u2588\n");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("\u2588\n");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("\u2588\n");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("\u2588\n");


                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\u2665");
                    Console.Write(rank);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(rank);
                    Console.Write("\u2665");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("\u2588\n");

                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine();
                }
                else if (suit == 3)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\u2666");
                    Console.Write(rank);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(rank);
                    Console.Write("\u2666");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("\u2588\n");



                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("\u2588\n");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("\u2588\n");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("\u2588\n");


                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\u2666");
                    Console.Write(rank);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(rank);
                    Console.Write("\u2666");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("\u2588\n");

                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine();
                }
                else if (suit == 4)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("\u2663");
                    Console.Write(rank);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(rank);
                    Console.Write("\u2663");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("\u2588\n");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("\u2588\n");
                    
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("\u2588\n");
                    
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("\u2588\n");
                    

                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("\u2663");
                    Console.Write(rank);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(rank);
                    Console.Write("\u2663");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("\u2588\n");

                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine();
                }
            }
            else if (rank == 10)
            {
                if (suit == 1)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("\u2660");
                    Console.Write(rank);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(rank);
                    Console.Write("\u2660");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("\u2588\n");


                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("\u2588\n");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("\u2588\n");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("\u2588\n");

                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("\u2660");
                    Console.Write(rank);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(rank);
                    Console.Write("\u2660");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("\u2588\n");



                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine();
                }
                else if (suit == 2)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\u2665");
                    Console.Write(rank);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(rank);
                    Console.Write("\u2665");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("\u2588\n");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("\u2588\n");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("\u2588\n");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("\u2588\n");


                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\u2665");
                    Console.Write(rank);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(rank);
                    Console.Write("\u2665");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("\u2588\n");

                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine();
                }
                else if (suit == 3)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\u2666");
                    Console.Write(rank);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(rank);
                    Console.Write("\u2666");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("\u2588\n");


                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("\u2588\n");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("\u2588\n");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("\u2588\n");


                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\u2666");
                    Console.Write(rank);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(rank);
                    Console.Write("\u2666");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("\u2588\n");


                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine();
                }
                else if (suit == 4)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("\u2663");
                    Console.Write(rank);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(rank);
                    Console.Write("\u2663");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("\u2588\n");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("\u2588\n");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("\u2588\n");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("\u2588\n");


                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("\u2663");
                    Console.Write(rank);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(rank);
                    Console.Write("\u2663");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("\u2588\n");


                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine();
                }
            }
            else if (rank > 10)
            {
                if (suit == 1)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("\u2660");
                    Console.Write(symb);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(symb);
                    Console.Write("\u2660");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("\u2588\n");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("\u2588\n");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("\u2660");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("\u2588\n");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("\u2588\n");


                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("\u2660");
                    Console.Write(symb);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(symb);
                    Console.Write("\u2660");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("\u2588\n");



                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine();
                }
                else if (suit == 2)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\u2665");
                    Console.Write(symb);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(symb);
                    Console.Write("\u2665");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("\u2588\n");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("\u2588\n");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\u2665");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("\u2588\n");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("\u2588\n");


                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\u2665");
                    Console.Write(symb);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(symb);
                    Console.Write("\u2665");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("\u2588\n");



                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine();
                }
                else if (suit == 3)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\u2666");
                    Console.Write(symb);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(symb);
                    Console.Write("\u2666");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("\u2588\n");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("\u2588\n");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\u2666");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("\u2588\n");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("\u2588\n");


                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\u2666");
                    Console.Write(symb);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(symb);
                    Console.Write("\u2666");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("\u2588\n");



                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine();
                }
                else if (suit == 4)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("\u2663");
                    Console.Write(symb);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(symb);
                    Console.Write("\u2663");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("\u2588\n");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("\u2588\n");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("\u2663");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("\u2588\n");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("\u2588\n");


                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("\u2663");
                    Console.Write(symb);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(symb);
                    Console.Write("\u2663");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("\u2588\n");



                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine();
                }
            }
            }


	}
}
