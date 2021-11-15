using System;

namespace BlackJack__Litvinenko_
{
    class Game
    {
        Player player;
        Dealer dealer;
        Card_deck deck;

        public Game()
        {
            
        }

        public int Player_decisions(Dealer dealer, ref int dealer_open_card, ref Player player, ref Card_deck deck, int score)
        {
            
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write(" Your decision?\n");
            int number = 0;

            Console.Write(" Hit - 1.\n");
            Console.Write(" Stand - 2.\n");
            do
            {
                number = Convert.ToInt32(Console.ReadLine());


                switch (number)
                {

                    case 1:
                        Console.Clear();
                        player.Get_card(deck.Hand_out());
                        score = player.Check_summ();
                        dealer.Show_dealer_hand();
                        Console.Write("Dealer has: " + dealer_open_card + "\n\n");

                        player.Show_hand();
                        Console.Write("Player has: " + score + "\n");

                        if (score < 21)
                        {
                            return Player_decisions(dealer, ref dealer_open_card, ref player, ref deck, score);
                        }
                        else
                        {
                            return score;
                        }
                        break;
                        
                    case 2:
                        return score;

                        break;
                        

                    default:
                        if ((number < 1) || (number > 2))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.Write("Invalid input!\n");
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.BackgroundColor = ConsoleColor.Blue;
                        }
                        break;
                }
            } while ((number != 1) && (number != 2));

            return score;
        }


        public void Play_Game()
        {
            Console.Title = "BlackJack";
            deck = new Card_deck();
            dealer = new Dealer();
            player = new Player();
            int dealer_open_card = 0;
            int dealer_score = 0;
            int player_score = 0;


           player.Get_card(deck.Hand_out());
           dealer.Get_card(deck.Hand_out());
           player.Get_card(deck.Hand_out());
           dealer.Get_card(deck.Hand_out());

            dealer_open_card = dealer.Open_card_value();
            dealer_score = dealer.Check_summ();
            player_score = player.Check_summ();

            Console.Clear();
            dealer.Show_dealer_hand();
            Console.Write("\nDealer has: " + dealer_open_card + "\n\n");
            player.Show_hand();
            Console.Write("Player has: " + player_score + "\n");

            if ((player_score == 21) && (dealer_score == 21))
            {
                Console.Clear();
                dealer.Show_hand();
                Console.Write("Dealer has: " + dealer_score + "\n\n");
                player.Show_hand();
                Console.Write("Player has: " + player_score + "\n");
                Console.Write("Draw! \n");                                                                 //и у игрока и у крупье БлэкДжек
                return;
            }

            if (player_score == 21)
            {
                Console.Write("BlackJack! Player wins! \n" );                                               //у игрока БлэкДжек 
                return;
            }

            if (dealer_score == 21)
            {
                Console.Clear();
                dealer.Show_hand();
                Console.Write("Dealer has: " + dealer_score + "\n\n");
                player.Show_hand();
                Console.Write("Dealer has BlackJack! Dealer wins! \n");                                    //У крупье БлэкДжек
                return;
            }

            player_score = Player_decisions(dealer, ref dealer_open_card, ref player, ref deck, player_score);

            if (player_score == 21)
            {
                Console.Write("Player wins! \n" );                                                          //игрок добрал до 21
                return;
            }

            if (player_score > 21)
            {
                Console.Write("Player busted!\nDealer wins! \n");                                          //У игрока перебор
                return;
            }

            while (dealer_score < 17)
            {
                Console.Clear();
                dealer.Get_card(deck.Hand_out());
                dealer_score = dealer.Check_summ();
                if (dealer_score > 21)
                {
                    dealer.Show_hand();
                    Console.Write("Dealer has: " + dealer_score + "\n\n");
                    player.Show_hand();
                    Console.Write("Player has: " + player_score + "\n");
                    Console.Write("Dealer busted!\nPlayer wins! \n" );                                      //У крупье перебор
                    return;
                }
            }

            if (dealer_score == player_score)
            {
                Console.Clear();
                dealer.Show_hand();
                Console.Write("Dealer has: " + dealer_score + "\n\n");
                player.Show_hand();
                Console.Write("Player has: " + player_score + "\n");
                Console.Write("Draw! \n");                                                                 //Ничья
                return;
            }

            if (dealer_score > player_score)
            {
                Console.Clear();
                dealer.Show_hand();
                Console.Write("Dealer has: " + dealer_score +"\n\n");
                player.Show_hand();
                Console.Write("Player has: " + player_score + "\n");
                Console.Write("Dealer wins with " + dealer_score + "\n");
                return;
            }

            if (dealer_score < player_score)
            {
                Console.Clear();
                dealer.Show_hand();
                Console.Write("Dealer has: " + dealer_score +"\n\n");
                player.Show_hand();
                Console.Write("Player wins with " + player_score + "\n");
                return;
            }

        }
    
    }
}
