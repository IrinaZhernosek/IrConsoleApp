namespace IrynaZharnasek.Lecture6
{
    public class Mentor : Person
    {
        public string Qualification { get; set; }

        //creating Mentor through Constructor by default:
        public Mentor()
        {
        }

        //creating Mentor through Constructor (all parameters):
        public Mentor(int age, string Name = "underfined", string Surname = "underfined", string qualification = "underfined") : base(age, Name, Surname)
        {
            Qualification = qualification;
        }

        public void ShowMentorInfo() => Console.WriteLine($"name: {Name} surname:{Surname} age:{Age} qualification: {Qualification}");
    }
}
