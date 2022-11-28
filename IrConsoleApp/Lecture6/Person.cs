using IrynaZharnasek.Lecture6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrynaZharnasek.Lecture6
{
    public class Person
    {
        private int age;
        private string name;
        private string surname;
        
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
        public string Name
        {
            set
            {
                this.name = value;
            }
            get { return this.name; }
        }

        //defining access metod for surname:
        public string Surname
        {
            set
            {
                this.surname = value;
            }
            get { return this.surname; }
        }

        //creating object of Class person through Constructor (all parameters):
        public Person(int age, string name = "underfined", string surname = "underfined")
        {
            this.age = age;
            this.name = name;
            this.surname = surname;
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

        public void showPersonInfo() => Console.WriteLine($"name: {name} surname:{surname} age:{Age}");
    }
}
