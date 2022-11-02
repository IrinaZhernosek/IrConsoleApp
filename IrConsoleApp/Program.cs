namespace IrynaZharnasekSaysHello
{
    class Program
    {
        static void Main()
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
            Task6();
            Task7();
            Task8();
            Task9();
        }

        private static void Task1()
        {
            var num = 20 + 5;
            Console.WriteLine(num);
        }

        private static void Task2()
        {
            Console.WriteLine("Enter count of days from 1000 to 9999:");
            ushort days = (ushort)Convert.ToUInt32(Console.ReadLine());
            byte years = (byte)(days / 365);
            byte month = (byte)((days - years * 365) / 30);
            byte day = (byte)(days - years * 365 - month * 30);

            Console.WriteLine($"{days} days are {years} years {month} months {day} days");

        }

        private static void Task3()
        {
            Console.WriteLine("Enter any number:");
            var numb = (int)Convert.ToUInt32(Console.ReadLine());
            var res = numb + 5;
            Console.WriteLine($"The result is {res}");

        }

        private static void Task4()
        {
            sbyte p1 = -34;
            Console.WriteLine($"sbyte type: {p1}");
            byte p2 = 4;
            Console.WriteLine($"byte type: {p2}");
            string p3 = "Hello";
            Console.WriteLine($"string type: {p3}");
            char p4 = '\u0052';
            Console.WriteLine($"Char type: {p4}");
            float p5 = 23.093433222f;
            Console.WriteLine($"Float type: {p5}");
            ushort p6 = 40000;
            Console.WriteLine($"Ushort type: {p6}");
            Boolean p7 = true;
            Console.WriteLine($"Boolean type: {p7}");
            byte p8 = 0;
            Console.WriteLine($"Byte type: {p8}");
        }

        private static void Task5()
        {
            //Получите от пользователя данные и запишите их в переменные с типами данных: short
            Console.WriteLine("Enter number from -32 768 to 32 767:");
            short t1 = (short)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Thank you! You entered {t1}");

            //Получите от пользователя данные и запишите их в переменные с типами данных: ulong
            Console.WriteLine("Enter number above 0:");
            ulong t2 = (ulong)Convert.ToInt64(Console.ReadLine());
            Console.WriteLine($"Thank you! You entered {t2}");

            //Получите от пользователя данные и запишите их в переменные с типами данных:char
            Console.WriteLine("Enter character:");
            char t3 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"Thank you! You entered {t3}");

            //Получите от пользователя данные и запишите их в переменные с типами данных:double
            Console.WriteLine("Enter fractional number:");
            double t4 = (double)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Thank you! You entered {t4}");
        }


        private static void Task6()
        {
            sbyte n = -5 * 7;
            sbyte n1 = --n;
            Console.WriteLine(n1);
        }

        private static void Task7()
        {
            Console.WriteLine("Enter any number:");
            short ch1 = (short)Convert.ToInt32(Console.ReadLine());
            if (ch1 % 2 == 0)
            { Console.WriteLine($"The number {ch1} is even number"); }
            else
            { Console.WriteLine($"The number {ch1} is odd number"); }
        }

        private static void Task8()
        {
            Console.WriteLine("Enter any number:");
            short a = (short)Convert.ToInt32(Console.ReadLine());
            if (a < 50 & a != 37 & a >= 32)
            { Console.WriteLine("Working"); }
            else if
                (a == 0 | a == 15)
            { Console.WriteLine("Working"); }
            else
            { Console.WriteLine("The enreded number is not matched the condition"); }
        }

        private static void Task9()
        {
            Console.WriteLine("Enter b1:");
            short b1 = (short)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b2:");
            short b2 = (short)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter any action (* + - /):");
            string o = (Console.ReadLine());

            switch (o)
            {
                case "*":
                    Console.WriteLine(b1 * b2);
                    break;
                case "+":
                    Console.WriteLine(b1 + b2);
                    break;
                case "-":
                    Console.WriteLine(b1 - b2);
                    break;
                case "/":
                    Console.WriteLine(b1 / b2);
                    break;

            }

        }

    }
}





