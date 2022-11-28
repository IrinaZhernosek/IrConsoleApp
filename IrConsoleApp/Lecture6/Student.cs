using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IrynaZharnasek.Lecture6
{
    public class Student : Person
    {
        private string position;

        public string Position
        {
            set
            {
                this.position = value;
            }
            get { return this.position; }
        }

        //creating Student through Constructor by default:
        public Student() {}

        //creating Student through Constructor (all parameters):
        public Student(int age, string name = "underfined", string surname = "underfined", string position = "underfined"): base(age, name, surname)
        {
            this.position = position;
        }

        public Student(string name = "underfined", string surname = "underfined", string position = "underfined") : base(name, surname)
        {
            this.position = position;
        }



        public void showStudentInfo() => Console.WriteLine($"name: {Name} surname:{Surname} age:{Age} position: {position}");
        
    }
}
