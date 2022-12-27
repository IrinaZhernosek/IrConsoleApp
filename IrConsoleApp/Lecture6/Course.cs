namespace IrynaZharnasek.Lecture6
{
    public class Course
    {
        private string course;
        private Mentor mentor;

        private Student[] arrayOfStudents = new Student[10];
        private Mentor[] arrayOfMentors = new Mentor[10];
        private Course[] courses = new Course[10];

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
        public Course GetCourseByTitle(string title)
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
