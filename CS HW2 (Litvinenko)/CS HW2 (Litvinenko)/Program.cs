using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW2__Litvinenko_
{
    class Array
    {
        int[] array;

        public Array()
        {
            Random rnd = new Random();
            array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(10) - 4;
            }
        }

        public void Show()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("\n");
        }


        public void Change_nulls()
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0)
                {
                    for (int j = i; j < (array.Length - 1); j++)
                    {
                        array[j] = array[j + 1];
                    }
                    array[array.Length - 1] = -1;
                    i--;
                }
            }
        }

        public void Move_negative()
        {
            int temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    temp = array[i];
                    for (int j = i; j > 0; j--)
                    {
                        array[j] = array[j - 1];
                    }
                    array[0] = temp;
                }
            }
        }


        public int Input_count()
        {
            Console.Write("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    counter++;
                }
            }

            Console.WriteLine("The number occurs " + counter + " times");
            return counter;
        }

     


    }
        class Program
    {
        static void Main(string[] args)
        {
            Array arr = new Array();
            arr.Show();

            arr.Change_nulls();                 //1
            arr.Show();

            arr.Move_negative();                //2
            arr.Show();

            arr.Input_count();                  //3
        }
    }
}
