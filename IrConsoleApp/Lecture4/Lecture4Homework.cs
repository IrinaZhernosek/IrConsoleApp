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
            for (int i = 0; i < pNumb; i++)
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

        public static void Task5()
        {
            string[] mas = new string[3];
            Console.WriteLine("Enter the first word:");
            string a = Console.ReadLine();
            Console.WriteLine("Enter the second word:");
            string b = Console.ReadLine();
            Console.WriteLine("Enter the third word:");
            string c = Console.ReadLine();
            mas[0] = a;
            mas[1] = b;
            mas[2] = c;
            foreach (string word in mas)
            {
                if (word == "Hello")
                {
                    Console.WriteLine("Labas");
                }
            }
        }

        public static void Task6()
        {
            int[] mas = new int[5] { 1, 20, 3, 487, 556 };
            foreach (int sum in mas) ;
            Console.WriteLine($"The sum of the first and the last elements of array is:{mas[0] + mas[^1]}");

        }

        public static void Task7()
        {
            int[] mas = { 54, 2, 123, -2, 25, 25, -5, 128 };
            int temp;
            for (int i = 0; i < mas.Length - 1; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
            foreach (int val in mas)
            {
                Console.WriteLine(val);
            }
            Console.WriteLine($"The sum of the max and min elements of array is:{mas[0] + mas[^1]}");
        }

        public static void Task9()
        {
            int[,] arr = new int[10, 10];
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    int sum = i * j;
                    if (i == j)
                    {
                        arr[i, j] = sum;
                        Console.Write(arr[i, j] + "\t");
                    }
                    else if (i > j)
                    {
                        arr[i, j] = sum;
                        Console.Write(arr[i, j] + "\t");
                    }
                    else if (i < j)
                    {
                        arr[i, j] = sum;
                        Console.Write(arr[i, j] + "\t");
                    }

                }
                Console.WriteLine("\n\n");
            }
        }

    }
}


