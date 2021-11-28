using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MySet<int> tree = new MySet<int>();
            Random r = new Random();
            for (int i = 0; i < 100; ++i)
            {
                tree.Add(r.Next(100));
            }

            foreach (int x in tree)
            {
                Console.Write($"{x}; ");
            }

            Console.ReadKey();


        }
    }
}
