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
            int sum = 0;
            for (int i = 1; i <= pNumb; i++)
            {
                sum += i;
                Console.WriteLine($"The sum of numbers up to {pNumb} is:{sum}");
            }
        }

        public static void Task2()
        {
            byte i = 0;
            while (i < 10)
            {
                i++;
                Console.WriteLine($"{i}*3={i * 3}");
            }
        }

        public static void Task3()
        {
            int[] massiv = new int[5] { 3, 5, 9, 8, 15 };
            int pr = 1;
            foreach (int i in massiv)
            {
                pr *= i;
                Console.WriteLine(pr);
            }
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
                if (word == "hello")
                {
                    Console.WriteLine("Labas");
                }
                else Console.WriteLine(word);
            }
        }

        public static void Task6()
        {
            int[] mas = new int[5] { 1, 20, 3, 487, 556 };
            Console.WriteLine($"The sum of the first and the last elements of array is:{mas[0] + mas[^1]}");
        }

        public static void Task7()
        {
            int[] mas = {4, 128, 2, 123, -2, 25, 25, -5, 7 };
            int max = mas[0];
            int maxIndex = 0;
            int min = mas[0];
            int minIndex = 0;
            //Console.WriteLine($"Minimum number is {mas.Min()}");
            //Console.WriteLine($"Maximum number is {mas.Max()}");
            //Console.WriteLine($"Sum of the Minimum and Maximum nambers is {mas.Min() + mas.Max()} ");
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] > max)
                {
                    maxIndex = i;
                    max = mas[i];
                    Console.WriteLine($"max {maxIndex}");
                }
                else
                {
                    minIndex = i;
                    min = mas[i];
                    Console.WriteLine($"min {minIndex}");
                }
               // Console.WriteLine($"min {minIndex} max {maxIndex}");
            }
            Console.WriteLine($"The summa of min and max elements of array is: {mas[minIndex] + mas[maxIndex]}");
        }

        public static void Task8()
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


