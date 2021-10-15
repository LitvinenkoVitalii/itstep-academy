using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW1__Litvinenko_
{

    public class Quadratic
{
        double a;
        double b;
        double c;

        public Quadratic(double source_a, double source_b, double source_c)
        {
            a = source_a;
            b = source_b;
            c = source_c;
        }
        public void getroots()
        {
            if (a == 0)
            {
                Console.WriteLine("Equation is not quadratic!");
                return;
            }

            double D = Math.Pow(b, 2) - 4 * a * c;
            double x1, x2;

            if (D < 0)
            {
                Console.WriteLine("Equation has no roots!");
                return;
            }
            else if (D == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine("Root: {0}", x1);
            }
            else if (D > 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("Roots: {0}, {1}", x1, x2);
            }
        }
}

class Program
    {


    static void Main(string[] args)
        {
            Console.WriteLine("Enter a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            Quadratic quad = new Quadratic(a, b, c);
            quad.getroots();

            Console.ReadKey();
        }
    }
}
