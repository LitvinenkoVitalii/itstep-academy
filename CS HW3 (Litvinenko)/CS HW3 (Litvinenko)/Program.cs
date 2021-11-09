using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW3__Litvinenko_
{

    class Program
    {
        static void Main(string[] args)
        {

			Console.WriteLine("Введите действительную и мнимую часть комплексного числа №1: ");
			double a1 = Convert.ToDouble(Console.ReadLine());
			double b1 = Convert.ToDouble(Console.ReadLine());

			Complex number1 = new Complex(a1, b1);

			Console.WriteLine("Введите действительную и мнимую часть комплексного числа №2: ");
			double a2 = Convert.ToDouble(Console.ReadLine());
			double b2 = Convert.ToDouble(Console.ReadLine());

			Complex number2 = new Complex(a2, b2);

			Console.WriteLine("Комплексное число №1: {0}\nКомплексное число №1: {1}", number1, number2);

			Console.WriteLine( " Что Вы хотите сделать с этими числами?");

			char symbol = 'X';

			do
			{
				Console.WriteLine();
				Console.WriteLine(" Прибавить: '+'");
				Console.WriteLine(" Вычесть: '-'");
				Console.WriteLine(" Умножить: '*'");
				Console.WriteLine(" Разделить: '/'");
				Console.WriteLine(" Выход из программы - 0\n\n");

				symbol = Convert.ToChar(Console.ReadLine());

				switch (symbol)
				{

					case '+':

						Console.WriteLine(number1 + number2);

						break;
					case '-':

						Console.WriteLine(number1 - number2);

						break;
					case '*':

						Console.WriteLine(number1 * number2);

						break;
					case '/':

						Console.WriteLine(number1 / number2);

						break;

					default:
						if (symbol != '0')
						{
							Console.WriteLine("Некорректный ввод! \n");
						}

						break;
				}
			} while (symbol != '0');

		}
	}
}
