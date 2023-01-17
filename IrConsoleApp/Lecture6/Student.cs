namespace IrynaZharnasek.Lecture6
{
    public class Student : Person
    {
        public string Position { get; set; }

        //creating Student through Constructor by default:
        public Student()
        {
        }

        //creating Student through Constructor (all parameters):
        public Student(int age, string name = "underfined", string surname = "underfined", string position = "underfined") : base(age, name, surname)
        {
            Position = position;
        }

        public Student(string name = "underfined", string surname = "underfined", string position = "underfined") : base(name, surname)
        {
            Position = position;
        }

        public override void ShowPersonInfo() => Console.WriteLine($"name: {Name} surname:{Surname} age:{Age} position: {Position}");
    }
}
