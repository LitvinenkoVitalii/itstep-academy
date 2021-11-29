using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{



    class Program
    {
        static void Main(string[] args)
        {
            Money money1 = new Money(2, 50);
            Money money2 = new Money(2, 20);

            Money money3 = new Money();

            money3 = money1 + money2;
            Console.WriteLine(money3);

            money3 = money1 * 5;
            Console.WriteLine(money3);
            money3 = money1 / 5;
            Console.WriteLine(money3);

            money1++;
            money2--;
            Console.WriteLine(money1);
            Console.WriteLine(money2);

            Console.WriteLine(money1>money2);       //True
            Console.WriteLine(money1!=money2);      //True
            Console.WriteLine(money1 == money3);    //False

        }

    }
}
