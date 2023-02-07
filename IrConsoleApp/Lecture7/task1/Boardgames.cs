namespace IrynaZharnasek.Lecture7.task1
{
    internal class Boardgames : Entertainments
    {
        public override string name { get; set; }
        public override string estimatedTime { get; set; }
        int age;
        int countOfPeople;
        string skillsLevel;

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

        public Boardgames(string name, string estimatedTime, int age, int countOfPeople, string skillsLevel) : base(name, estimatedTime, age)
        {
            this.name = name;
            this.estimatedTime = estimatedTime;
            this.age = age;
            this.countOfPeople = countOfPeople;
            this.skillsLevel = skillsLevel;
        }

        public override void typeOfGame()
        {
            Console.WriteLine($"The game is {name}");
        }
    }
}
