namespace IrynaZharnasek.Lecture6
{
    public class Course
    {
        private string courseName;
        private Mentor mentor;

        private Student[] arrayOfStudents = new Student[10];

        public string CourseTitle
        {
            get { return courseName; }
        }

        public Course(string course)
        {
            courseName = course;
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
            this.mentor = mentor;
        }
    }
}
