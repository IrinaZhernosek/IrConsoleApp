namespace IrynaZharnasek.Lecture7.task1
{
    public abstract class Entertainments
    {
        public abstract string name { get; set; }
        public abstract string estimatedTime { get; set; }
        private int age;

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

        public Entertainments(string name, string estimatedTime, int age)
        {
            this.name = name;
            this.estimatedTime = estimatedTime;
            this.age = age;
        }

        public Entertainments(string name) : this(name, "underfind", 0)
        {

        }

        public Entertainments(int age) : this("underfind", "underfind", age)
        {

        }

        public Entertainments()
        {
        }

        public abstract void typeOfGame();

        public void gameInfo()
        {
            Console.WriteLine($"The {name} game takes {estimatedTime} you time. It is for you if you are older than {age} years old.");
        }
    }
}
