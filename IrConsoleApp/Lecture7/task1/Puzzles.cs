namespace IrynaZharnasek.Lecture7.task1
{
    public class Puzzles : Entertainments
    {
        public override string name { get; set; }
        public override string estimatedTime { get; set; }
        private int age;
        private int countOfDetails;
        private string detailsSize;

        public int Age
        {
            set
            {
                age = value;
            }
            get
            {
                return age;
            }
        }

        public Puzzles(string name, string estimatedTime, int age, int countOfDetails, string detailsSize) : base(name, estimatedTime, age)
        {
            this.name = name;
            this.estimatedTime = estimatedTime;
            this.age = age;
            this.countOfDetails = countOfDetails;
            this.detailsSize = detailsSize;
        }

        public Puzzles()
        {

        }

        public override void typeOfGame()
        {
            Console.WriteLine($"The game is {name}");
        }
    }
}
