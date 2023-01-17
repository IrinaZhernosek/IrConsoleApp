namespace IrynaZharnasek.Lecture6
{
    public class CoursesLibrary
    {
        private Student[] _totalArrayOfStudents = new Student[100];
        private Mentor[] _totalMentors = new Mentor[10];
        private Course[] _allCourses = new Course[10];

        public void AddNewStudent(Student student)
        {
            for (var i = 0; i < _totalArrayOfStudents.Length; i++)
            {
                if (_totalArrayOfStudents[i] == null)
                {
                    _totalArrayOfStudents[i] = student;
                    break;
                }
            }
        }

        public void AddNewMentor(Mentor mentor)
        {
            for (var i = 0; i < _totalMentors.Length; i++)
            {
                if (_totalMentors[i] == null)
                {
                    _totalMentors[i] = mentor;
                    break;
                }
            }
        }

        public void AddNewCourse(Course course)
        {
            for (var i = 0; i < _allCourses.Length; i++)
            {
                if (_allCourses[i] == null)
                {
                    _allCourses[i] = course;
                    break;
                }
            }
        }

        public Course GetCourseByTitle(string title)
        {
            for (var i = 0; i < _allCourses.Length; i++)
            {
                if (_allCourses[i].CourseTitle == title)
                {
                    return _allCourses[i];
                }
            }
            return null;
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

    }
}

