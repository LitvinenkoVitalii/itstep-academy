using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poker
{
    class DrawCards
    {

        //рисуем карту
        public static void DrawCard(Card card, int xcoor, int ycoor)
        {




            Console.ForegroundColor = ConsoleColor.White;

            int x = xcoor * 12;
            int y = ycoor;

            Console.SetCursorPosition(x, y);

            Console.OutputEncoding = Encoding.UTF8;

            char symb = 'X';

            if (card.MyValue == Card.VALUE.JACK)
            {
                symb = 'J';
            }
            else if (card.MyValue == Card.VALUE.QUEEN)
            {
                symb = 'Q';
            }
            else if (card.MyValue == Card.VALUE.KING)
            {
                symb = 'K';
            }
            else if (card.MyValue == Card.VALUE.ACE)
            {
                symb = 'A';
            }

            if ((card.MyValue == Card.VALUE.TWO) || (card.MyValue == Card.VALUE.THREE) || (card.MyValue == Card.VALUE.FOUR) || (card.MyValue == Card.VALUE.FIVE)
                || (card.MyValue == Card.VALUE.SIX) || (card.MyValue == Card.VALUE.SEVEN) || (card.MyValue == Card.VALUE.EIGHT) || (card.MyValue == Card.VALUE.NINE))
            {
                if (card.MySuit == Card.SUIT.SPADES)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("\u2660");
                    Console.Write((int)card.MyValue);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write((int)card.MyValue);
                    Console.Write("\u2660");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588\n");

                    Console.SetCursorPosition(x, y + 1);

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588\n");
                    Console.SetCursorPosition(x, y + 2);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588\n");
                    Console.SetCursorPosition(x, y + 3);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588\n");
                    Console.SetCursorPosition(x, y + 4);

                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("\u2660");
                    Console.Write((int)card.MyValue);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write((int)card.MyValue);
                    Console.Write("\u2660");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588\n");

                    Console.SetCursorPosition(x, y + 5);

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588");

                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine();


                }
                else if (card.MySuit == Card.SUIT.HEARTS)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\u2665");
                    Console.Write((int)card.MyValue);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write((int)card.MyValue);
                    Console.Write("\u2665");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588\n");

                    Console.SetCursorPosition(x, y + 1);

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588\n");
                    Console.SetCursorPosition(x, y + 2);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588\n");
                    Console.SetCursorPosition(x, y + 3);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588\n");
                    Console.SetCursorPosition(x, y + 4);

                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\u2665");
                    Console.Write((int)card.MyValue);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write((int)card.MyValue);
                    Console.Write("\u2665");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588\n");

                    Console.SetCursorPosition(x, y + 5);

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588");

                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine();
                }
                else if (card.MySuit == Card.SUIT.DIAMONDS)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\u2666");
                    Console.Write((int)card.MyValue);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write((int)card.MyValue);
                    Console.Write("\u2666");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588\n");

                    Console.SetCursorPosition(x, y + 1);

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588\n");
                    Console.SetCursorPosition(x, y + 2);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588\n");
                    Console.SetCursorPosition(x, y + 3);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588\n");
                    Console.SetCursorPosition(x, y + 4);

                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\u2666");
                    Console.Write((int)card.MyValue);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write((int)card.MyValue);
                    Console.Write("\u2666");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588\n");

                    Console.SetCursorPosition(x, y + 5);

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588");

                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine();
                }
                else if (card.MySuit == Card.SUIT.CLUBS)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("\u2663");
                    Console.Write((int)card.MyValue);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write((int)card.MyValue);
                    Console.Write("\u2663");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588\n");

                    Console.SetCursorPosition(x, y + 1);

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588\n");
                    Console.SetCursorPosition(x, y + 2);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588\n");
                    Console.SetCursorPosition(x, y + 3);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588\n");
                    Console.SetCursorPosition(x, y + 4);

                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("\u2663");
                    Console.Write((int)card.MyValue);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write((int)card.MyValue);
                    Console.Write("\u2663");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588\n");

                    Console.SetCursorPosition(x, y + 5);

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588");

                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine();
                }
            }
            else if (card.MyValue == Card.VALUE.TEN)
            {
                if (card.MySuit == Card.SUIT.SPADES)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("\u2660");
                    Console.Write((int)card.MyValue);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write((int)card.MyValue);
                    Console.Write("\u2660");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588\n");

                    Console.SetCursorPosition(x, y + 1);

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588\n");
                    Console.SetCursorPosition(x, y + 2);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588\n");
                    Console.SetCursorPosition(x, y + 3);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588\n");
                    Console.SetCursorPosition(x, y + 4);

                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("\u2660");
                    Console.Write((int)card.MyValue);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write((int)card.MyValue);
                    Console.Write("\u2660");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588\n");

                    Console.SetCursorPosition(x, y + 5);

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588");

                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine();
                }
                else if (card.MySuit == Card.SUIT.HEARTS)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\u2665");
                    Console.Write((int)card.MyValue);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write((int)card.MyValue);
                    Console.Write("\u2665");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588\n");

                    Console.SetCursorPosition(x, y + 1);

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588\n");
                    Console.SetCursorPosition(x, y + 2);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588\n");
                    Console.SetCursorPosition(x, y + 3);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588\n");
                    Console.SetCursorPosition(x, y + 4);

                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\u2665");
                    Console.Write((int)card.MyValue);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write((int)card.MyValue);
                    Console.Write("\u2665");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588\n");

                    Console.SetCursorPosition(x, y + 5);

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588");

                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine();
                }
                else if (card.MySuit == Card.SUIT.DIAMONDS)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\u2666");
                    Console.Write((int)card.MyValue);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write((int)card.MyValue);
                    Console.Write("\u2666");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588\n");

                    Console.SetCursorPosition(x, y + 1);

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588\n");
                    Console.SetCursorPosition(x, y + 2);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588\n");
                    Console.SetCursorPosition(x, y + 3);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588\n");
                    Console.SetCursorPosition(x, y + 4);

                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\u2666");
                    Console.Write((int)card.MyValue);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write((int)card.MyValue);
                    Console.Write("\u2666");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588\n");

                    Console.SetCursorPosition(x, y + 5);

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588");

                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine();
                }
                else if (card.MySuit == Card.SUIT.CLUBS)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("\u2663");
                    Console.Write((int)card.MyValue);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write((int)card.MyValue);
                    Console.Write("\u2663");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588\n");

                    Console.SetCursorPosition(x, y + 1);

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588\n");
                    Console.SetCursorPosition(x, y + 2);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588\n");
                    Console.SetCursorPosition(x, y + 3);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588\n");
                    Console.SetCursorPosition(x, y + 4);

                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("\u2663");
                    Console.Write((int)card.MyValue);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write((int)card.MyValue);
                    Console.Write("\u2663");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588\n");

                    Console.SetCursorPosition(x, y + 5);

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588");

                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine();
                }
            }
            else if ((card.MyValue == Card.VALUE.JACK) || (card.MyValue == Card.VALUE.QUEEN)
                || (card.MyValue == Card.VALUE.KING) || (card.MyValue == Card.VALUE.ACE))
            {
                if (card.MySuit == Card.SUIT.SPADES)
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
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588\n");

                    Console.SetCursorPosition(x, y + 1);

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588\n");
                    Console.SetCursorPosition(x, y + 2);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("\u2660");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588\n");
                    Console.SetCursorPosition(x, y + 3);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588\n");
                    Console.SetCursorPosition(x, y + 4);

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
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588\n");

                    Console.SetCursorPosition(x, y + 5);

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588");

                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine();


                }
                else if (card.MySuit == Card.SUIT.HEARTS)
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
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588\n");

                    Console.SetCursorPosition(x, y + 1);

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588\n");
                    Console.SetCursorPosition(x, y + 2);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\u2665");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588\n");
                    Console.SetCursorPosition(x, y + 3);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588\n");
                    Console.SetCursorPosition(x, y + 4);

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
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588\n");

                    Console.SetCursorPosition(x, y + 5);

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588");

                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine();
                }
                else if (card.MySuit == Card.SUIT.DIAMONDS)
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
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588\n");

                    Console.SetCursorPosition(x, y + 1);

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588\n");
                    Console.SetCursorPosition(x, y + 2);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\u2666");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588\n");
                    Console.SetCursorPosition(x, y + 3);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588\n");
                    Console.SetCursorPosition(x, y + 4);

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
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588\n");

                    Console.SetCursorPosition(x, y + 5);

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588");

                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine();
                }
                else if (card.MySuit == Card.SUIT.CLUBS)
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
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588\n");

                    Console.SetCursorPosition(x, y + 1);

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588\n");
                    Console.SetCursorPosition(x, y + 2);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("\u2663");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588\n");
                    Console.SetCursorPosition(x, y + 3);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2588\u2588\u2588\u2588\u2588\u2588\u2588");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588\n");
                    Console.SetCursorPosition(x, y + 4);

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
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588\n");

                    Console.SetCursorPosition(x, y + 5);

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2588");

                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine();
                }
            }

        }

        public static void DrawHiddenCard(Card card, int xcoor, int ycoor)
        {

            Console.ForegroundColor = ConsoleColor.White;

            int x = xcoor * 12;
            int y = ycoor;

            Console.SetCursorPosition(x, y);

            Console.OutputEncoding = Encoding.UTF8;

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\u2593\u2593\u2593\u2593\u2593\u2593\u2593");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("\u2588\n");
            Console.SetCursorPosition(x, y + 1);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\u2593\u2593\u2593\u2593\u2593\u2593\u2593");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("\u2588\n");
            Console.SetCursorPosition(x, y + 2);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\u2593\u2593\u2593\u2593\u2593\u2593\u2593");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("\u2588\n");
            Console.SetCursorPosition(x, y + 3);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\u2593\u2593\u2593\u2593\u2593\u2593\u2593");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("\u2588\n");
            Console.SetCursorPosition(x, y + 4);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\u2593\u2593\u2593\u2593\u2593\u2593\u2593");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("\u2588\n");
            Console.SetCursorPosition(x, y + 5);


            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine();
        }


    }

}
