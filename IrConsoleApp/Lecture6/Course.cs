using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IrynaZharnasek.Lecture6;

namespace IrynaZharnasek.Lecture6
{
    public class Course
    {
        private string course;

        private Student[] arrayOfStudents = new Student[100];
        private Mentor[] arrayOfMentors = new Mentor[100];

        public string CourseTitle
        {
            get { return this.course; }
        }

        public Course(string course)
        {
            this.course = course;
        }

        public void AddNewStudent(Student student)
        {
            for (var i = 0; i < arrayOfStudents.Length; i++)
            {
                if (arrayOfStudents[i] == null)
                {
                    arrayOfStudents[i] = student;
                    break;
                }
            }
        }

        public void AddNewMentor(Mentor mentor)
        {
            for (var i = 0; i < arrayOfMentors.Length; i++)
            {
                if (arrayOfMentors[i] == null)
                {
                    arrayOfMentors[i] = mentor;
                    break;
                }
            }
        }

    }
}
