using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrynaZharnasek.Lecture6
{
    public class CoursesLibrary
    {
        private Course[] courses = new Course[10];

        public void AddCourseToCoursesLibrary(Course course)
        {
            for (var i = 0; i < courses.Length; i++)
            {
                if (courses[i] == null)
                {
                    courses[i] = course;
                    break;
                }
            }
        }


        public void AssignStudentToCours(Student student)
        {
            if (student.Position == "developer")
            {
                Course cSharp = GetCourseByTitle("C#");
                cSharp.AddNewStudent(student);
                Console.WriteLine($"Student {student.Name} assighed to {cSharp.CourseTitle}");
            }
            else if (student.Position == "tester")
            {
                Course testing = GetCourseByTitle("Functional testing");
                testing.AddNewStudent(student);
                Console.WriteLine($"Student {student.Name} assighed to {testing.CourseTitle}");
            }
            else
            {
                Console.WriteLine($"No courses were found for {student.Name} position!");
            }
        }

        public void AssignMentorToCours(Mentor mentor)
        {
            if (mentor.Qualification == "development")
            {
                Course cSharp = GetCourseByTitle("C#");
                cSharp.AddNewMentor(mentor);
                Console.WriteLine($"Mentor {mentor.Name} assighed to {cSharp.CourseTitle}");
            }
            else if (mentor.Qualification == "qualityAssurance")
            {
                Course testing = GetCourseByTitle("Functional testing");
                testing.AddNewMentor(mentor);
                Console.WriteLine($"Mentor {mentor.Name} assighed to {testing.CourseTitle}");
            }
            else
            {
                Console.WriteLine($"No courses were found for {mentor.Name} qualification!");
            }
        }

        private Course GetCourseByTitle(string title)
        {
            for (var i = 0; i < courses.Length; i++)
            {
                if (courses[i].CourseTitle == title)
                {
                    return courses[i];
                }
            }

            return null;
        }
    }
}

