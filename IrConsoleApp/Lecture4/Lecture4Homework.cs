using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrynaZharnasek.Lecture4
{
    public class Lecture4Homework
    {
        public static void Task1()
        {
            Console.WriteLine("Enter any positive number:");
            int pNumb = Convert.ToInt32(Console.ReadLine());
            int sum;
            for (int i = 0;i < pNumb; i++)
            {
                sum = i + (i + 1);
                Console.WriteLine($"The sum of numbers up to {pNumb} is:{sum}"); 
            }
        }

        public static void Task2()
        {
            byte i = 0;
            do
            {
                i++;
                Console.WriteLine($"{i}*3={i * 3}");
            }
            while (i < 10);
        }

        public static void Task3()
        {
            int[] massiv = new int[5] { 3, 5, 9, 8, 15 };
            Console.WriteLine(massiv[0] * massiv[1] * massiv[2] * massiv[3] * massiv[4]);
        }

        public static void Task4()
        {
            short i = 2048;
            short count = 0;
            do
            {
                i = (short)(i / 2);
                count++;
            }
            while (i >= 10);
            Console.WriteLine(count);

        }
    }
}

