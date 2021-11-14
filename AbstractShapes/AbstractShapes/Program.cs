using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractShapes
{


    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<IShape> shapes = new List<IShape>();

            //Random rnd = new Random();

            RedShapeFactory rf = new RedShapeFactory();
            BlueShapeFactory bf = new BlueShapeFactory();
            GreenShapeFactory gf = new GreenShapeFactory();


            char symbol_1 = 'X';
            char symbol_2 = 'X';

            do
            {
                Console.WriteLine();
                Console.WriteLine("Вы можете выбрать одну или несколько фигур для вывода на экран: ");
                Console.WriteLine(" Выберите цвет фигуры ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" R - красный");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(" B - синий");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" G - зеленый");
                Console.ResetColor();

                Console.WriteLine(" Выход для вывода выбранных фигур на экран - 0\n\n");

                symbol_1 = Convert.ToChar(Console.ReadLine().ToUpper());
                

                switch (symbol_1)
                {

                    case 'R':


                        do
                        {
                            Console.WriteLine();
                            Console.WriteLine(" Выберите фигуру: ");
                            Console.WriteLine(" R - прямоугольник");
                            Console.WriteLine(" T - треугольник");
                            Console.WriteLine(" E - эллипс");
                            Console.WriteLine(" Выход из меню выбора фигур - 0\n\n");

                            symbol_2 = Convert.ToChar(Console.ReadLine().ToUpper());

                            switch (symbol_2)
                            {

                                case 'R':

                                    shapes.Add(rf.GetRectangle(10, 10, 100, 100));

                                    break;
                                case 'T':

                                    shapes.Add(rf.GetTriangle(10, 10, 100, 100));

                                    break;
                                case 'E':

                                    shapes.Add(rf.GetEllipse(10, 10, 100, 100));

                                    break;

                                default:
                                    if (symbol_2 != '0')
                                    {
                                        Console.WriteLine("Некорректный ввод! \n");
                                    }

                                    break;
                            }
                        } while (symbol_2 != '0');

                        symbol_2 = 'X';

                        break;
                    case 'B':

                        do
                        {
                            Console.WriteLine();
                            Console.WriteLine(" Выберите фигуру: ");
                            Console.WriteLine(" R - прямоугольник");
                            Console.WriteLine(" T - треугольник");
                            Console.WriteLine(" E - эллипс");
                            Console.WriteLine(" Выход из меню выбора фигур - 0\n\n");

                            symbol_2 = Convert.ToChar(Console.ReadLine().ToUpper());

                            switch (symbol_2)
                            {

                                case 'R':

                                    shapes.Add(bf.GetRectangle(10, 10, 100, 100));

                                    break;
                                case 'T':

                                    shapes.Add(bf.GetTriangle(10, 10, 100, 100));

                                    break;
                                case 'E':

                                    shapes.Add(bf.GetEllipse(10, 10, 100, 100));

                                    break;

                                default:
                                    if (symbol_2 != '0')
                                    {
                                        Console.WriteLine("Некорректный ввод! \n");
                                    }

                                    break;
                            }
                        } while (symbol_2 != '0');

                        symbol_2 = 'X';

                        break;
                    case 'G':

                        do
                        {
                            Console.WriteLine();
                            Console.WriteLine(" Выберите фигуру: ");
                            Console.WriteLine(" R - прямоугольник");
                            Console.WriteLine(" T - треугольник");
                            Console.WriteLine(" E - эллипс");
                            Console.WriteLine(" Выход из программы - 0\n\n");

                            symbol_2 = Convert.ToChar(Console.ReadLine().ToUpper());

                            switch (symbol_2)
                            {

                                case 'R':

                                    shapes.Add(gf.GetRectangle(10, 10, 100, 100));

                                    break;
                                case 'T':

                                    shapes.Add(gf.GetTriangle(10, 10, 100, 100));

                                    break;
                                case 'E':

                                    shapes.Add(gf.GetEllipse(10, 10, 100, 100));

                                    break;

                                default:
                                    if (symbol_2 != '0')
                                    {
                                        Console.WriteLine("Некорректный ввод! \n");
                                    }

                                    break;
                            }
                        } while (symbol_2 != '0');

                        symbol_2 = 'X';

                        break;
                    
                    default:
                        if (symbol_1 != '0')
                        {
                            Console.WriteLine("Некорректный ввод! \n");
                        }

                        break;
                }
            } while (symbol_1 != '0');


            foreach (Shape item in shapes)
            {
                item.Draw();
            }

        }
    }
}
