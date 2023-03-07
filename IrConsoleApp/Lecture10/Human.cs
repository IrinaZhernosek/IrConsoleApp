
namespace IrynaZharnasek.Lecture10
{
    abstract public class Human
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public Human(string firstName = "underfined", string lastName = "underfind")
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public Human(string firstName): this (firstName, "underfined")
        {

        }
        public Human()
        {

        }


    }
}
