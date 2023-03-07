using System.Linq.Expressions;

namespace IrynaZharnasek.Lecture8.Task1
{
    public class Massive
    {
        public static void ShowMassiveElement()
        {
            int[] massive = { 8, 7, 1, 4, 2 };

            Console.WriteLine("Input index of element in massive:");
            string? inputedValue = Console.ReadLine();
            string? checkedValue = inputedValue.Equals(string.Empty) ? null : inputedValue;
            int inputtedNumber = Int32.Parse(checkedValue);

            int massiveElement = massive[inputtedNumber];
            Console.WriteLine($"Massive element that has index {inputedValue} has value {massiveElement}");
        }
    }
}
