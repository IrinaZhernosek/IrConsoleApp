using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrynaZharnasek.Lecture6
{
    public class Mentor:Person
    {
        private string qualification;

        public string Qualification
        {
            set
            {
                this.qualification = value;
            }
            get { return this.qualification; }
        }

        //creating Mentor through Constructor by default:
        public Mentor() { }

        //creating Mentor through Constructor (all parameters):
        public Mentor(int age, string name = "underfined", string surname = "underfined", string qualification = "underfined") : base(age, name, surname)
        {
            this.qualification = qualification;
        }

        public void showMentorInfo() => Console.WriteLine($"name: {Name} surname:{Surname} age:{Age} qualification: {qualification}");
        
    }
}
