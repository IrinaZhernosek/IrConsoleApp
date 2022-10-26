using System;


namespace IrynaZharnasek_SaysHello
{
    class Program {
        static void Main()
        {
            Task1();
            Task2();
        }
        /*{
            Console.WriteLine("Hi! What is your name?");

            string st1;
            
            st1 = (Console.ReadLine());
            Console.WriteLine("Nice to meet you " + st1);

        } */
        private static void Task1()
        {
            var num = 20 + 5;
            Console.WriteLine(num);
        }

        private static void Task2()
        {
            Console.WriteLine("Enter count of days from 1000 to 9999:");
            ushort Days = (ushort)Convert.ToUInt32(Console.ReadLine());
            byte Years = (byte) (Days / 365);
            byte Month = (byte)((Days - Years * 365) / 30);
            byte Day = (byte)(Days - Years * 365 - Month * 30);

            Console.WriteLine($"{Days} days are {Years} years {Month} months {Day} days");
            

        }

    }
}





