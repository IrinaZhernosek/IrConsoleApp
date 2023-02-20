using IrynaZharnasek.Lecture7.Task3;

namespace AutomationCources.Lecture_7.Homework
{
    public class Printer: PhotoDevices, IPrint
    {
        private int paperWidth;
        private int paperHeight;

        public Printer(int paperWidth, int paperHeight, string? modelName, decimal price): base (paperWidth, paperHeight, modelName, price)
        {
            this.modelName = modelName;
            this.price = price;
            this.paperWidth = paperWidth;
            this.paperHeight = paperHeight;
        }

        public override string? modelName { get ; set ; }
        public override decimal price { get ; set ; }

        public override string Description
        {
            get
            {
                return $"Price: {price}, model:{modelName}";
            }
        }

        public void Print()
        {
            Console.WriteLine("Printing...");
        }
        public override void turnOff()
        {
            Console.WriteLine("Press Turn Off button");
        }

        public override void turnOn()
        {
            Console.WriteLine("Press button at the top");
        }
    }
}
