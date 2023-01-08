using IrynaZharnasek.Lecture6;

namespace IrynaZharnasek.Lecture6
{
    public class Person
    {
        private int age;

        //defining access metod for Student's Age:
        public int Age
        {
            set
            {
                if (value < 1 || value > 70)
                    Console.WriteLine("The age should be between '0' and '71'");
                else
                    this.age = value;
            }
            get { return this.age; }
        }

        //defining access metod for name:
        public string Name { get; set; }

        //defining access metod for surname:
        public string Surname { get; set; }

        //creating object of Class person through Constructor (all parameters):
        public Person(int age, string name = "underfined", string surname = "underfined")
        {
            this.age = age;
            Name = name;
            Surname = surname;
        }

        //creating object of Class Person through Constructor (only age):
        public Person(int age) : this(age, "underfind", "underfind")
        {

        }

        //creating object of Class Person through Constructor (only name):
        public Person(string name) : this(0, name, "underfind")
        {

        }

        //creating object of Class Person through Constructor (name + surname):
        public Person(string name, string surname) : this(0, name, surname)
        {

        }

        //creating object of Class Student through Constructor by default:
        public Person()
        {

        }

        public void ShowPersonInfo() => Console.WriteLine($"name: {Name} surname:{Surname} age:{Age}");
    }
}
