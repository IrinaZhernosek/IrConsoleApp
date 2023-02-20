using IrynaZharnasek.Lecture7.Task3;

namespace AutomationCources.Lecture_7.Homework
{
    public class MobilePhone: PhotoDevices, ITakePhoto
    {
        private double numberOfPixelsInCamera;

        public MobilePhone(double numberOfPixelsInCamera, string? modelName, decimal price): base (numberOfPixelsInCamera, modelName, price)
        {
            this.numberOfPixelsInCamera = numberOfPixelsInCamera;
            this.modelName = modelName;
            this.price = price;
        }

        public override string Description
        {
            get
            {
                return $"Price: {price}, model:{modelName}, number of pixels in camera: {numberOfPixelsInCamera}";
            }
        }

        public override string? modelName { get; set; }
        public override decimal price { get ; set; }

        public void TakePhoto()
        {
            Console.WriteLine("Press button on the screen and photo is ready");
        }

        public override void turnOff()
        {
            Console.WriteLine("Press Turn Off button");
        }

        public override void turnOn()
        {
            Console.WriteLine("Press left side button");
        }
    }
}
