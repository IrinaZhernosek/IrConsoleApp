using IrynaZharnasek.Lecture7.Task3;

namespace AutomationCources.Lecture_7.Homework
{
    public class Polaroid : PhotoDevices, IPrint, ITakePhoto
    {
        private int paperWidth;
        private int paperHeight;
        private double numberOfPixelsInCamera;
        public Polaroid(int paperWidth, int paperHeight, double numberOfPixelsInCamera, string? modelName, decimal price) : base(paperWidth, paperHeight, numberOfPixelsInCamera, modelName, price)
        {

        }

        public override string? modelName { get; set; }
        public override decimal price { get; set; }

        public override string Description
        {
            get
            {
                return $"Price: {price}, model:{modelName}, number of pixels in camera: {numberOfPixelsInCamera}";
            }
        }

        public void Print()
        {
            Console.WriteLine("Printing...");
        }

        public void TakePhoto()
        {
            Console.WriteLine("Press black button at the top and photo is ready");
        }

        public override void turnOff()
        {
            Console.WriteLine("Press Turn Off button");
        }

        public override void turnOn()
        {
            Console.WriteLine("Press right side button");
        }
    }
}
