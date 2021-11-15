using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack__Litvinenko_
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Title = "BlackJack";

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();

            Game game = new Game();
            game.Play_Game();

            int key;
            do
            {
                Console.Write("New Game - 1;\n");
                Console.Write("Exit - 0;\n");
                key = Convert.ToInt32(Console.ReadLine());

                if (key == 1)
                {
                    game.Play_Game();
                }
                else if (key == 0)
                {
                    return;
                }
            } while (key == 1);
        }
    }
}
