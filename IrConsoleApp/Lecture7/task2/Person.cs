using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrynaZharnasek.Lecture7.task2
{
    public class Person: IRun, IJump
    {
        private string name;
        private int age;
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
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

        public int speed { get; set ; }
        public int high { get; set ; }

        public Person (string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public Person()
        {

        }

        public void CanRun()
        {
            Console.WriteLine($"{Name} can running");
        }

        public void CanJump()
        {
            Console.WriteLine($"{Name} can jumping");
        }
    }
}
