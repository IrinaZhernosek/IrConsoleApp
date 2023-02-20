namespace IrynaZharnasek.Lecture7.Task3
{
    public abstract class PhotoDevices
    {
        public int paperWidth;
        public int paperHeight;
        public double numberOfPixelsInCamera;
        public abstract string? modelName { get; set; }
        public abstract decimal price { get; set; }

        public PhotoDevices(int paperWidth, int paperHeight, double numberOfPixelsInCamera, string? modelName, decimal price)
        {
            this.paperWidth = paperWidth;
            this.paperHeight = paperHeight;
            this.numberOfPixelsInCamera = numberOfPixelsInCamera;
            this.modelName = modelName;
            this.price = price;
        }
        public PhotoDevices(int paperWidth, int paperHeight, string? modelName, decimal price) : this(paperWidth, paperHeight, 0, modelName, price)
        {

        }
        public PhotoDevices(double numberOfPixelsInCamera, string? modelName, decimal price) : this(0, 0, numberOfPixelsInCamera, modelName, price)
        {

        }

        public abstract string Description
        {
            get;
        }

        public abstract void turnOn();
        public abstract void turnOff();
    }
}
