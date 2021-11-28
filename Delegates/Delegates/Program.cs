using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;

namespace Delegates
{
    delegate float ArithmeticDelegate(float a, float b);
    class Program
    {
		delegate bool CompareDelegate(int x, int y);
        delegate void MyDelegate(int a, int b);
        static void MyMethod(int x, int y)
        {
            Console.WriteLine(x + y);
        }

        static float add(float a, float b)
        {
            return a + b;
        }

        static float sub(float a, float b)
        {
            return a - b;
        }

        static float mul(float a, float b)
        {
            return a * b;
        }

        static float div(float a, float b)
        {
            return a / b;
        }

		static void DemoSort(int[] mas, CompareDelegate d)
        {
			int size = mas.Length;
			while(--size > 0)
            {
				for(int i = 0; i<size; ++i)
                {
					if(d(mas[i], mas[i+1]))
                    {
						int tmp = mas[i];
						mas[i] = mas[i + 1];
						mas[i + 1] = tmp;
                    }
                }
            }
        }

		static bool func(int a, int b)
        {
			return a > b;
        }
		static void Main(string[] args)
		{
			Thread.CurrentThread.CurrentCulture = new CultureInfo("en-us");
			Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-us");
			ArithmeticDelegate[] arithmetics = new ArithmeticDelegate[] { add, sub, mul, div };


			Console.WriteLine("Введите число A и число B: ");
			float a = Convert.ToSingle(Console.ReadLine());
			float b = Convert.ToSingle(Console.ReadLine());

			Console.WriteLine(" Какое действие выполнить с этими числами?");

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

						Console.WriteLine(arithmetics[0](a, b));

						break;
					case '-':

						Console.WriteLine(arithmetics[1](a, b));

						break;
					case '*':

						Console.WriteLine(arithmetics[2](a, b));

						break;
					case '/':

						Console.WriteLine(arithmetics[3](a, b));

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
