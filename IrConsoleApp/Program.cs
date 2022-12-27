using IrynaZharnasek.Lecture6;

namespace IrynaZharnasek
{
    public class Program
    {
        public static void Main()
        {
            Student student1 = new Student("Iryna", "Zharnasek","tester");
            student1.Age = 33;
            student1.ShowStudentInfo();

            Student student2 = new Student("Paul", "Zelinsky", "developer");
            student2.Age = 69;
            student2.ShowStudentInfo();

            Student student3 = new Student("Lena", "Melko", "sister");
            student3.Age = 25;
            student3.ShowStudentInfo();

            Mentor mentor1 = new Mentor( 22, "Anna", "Maslova", "qualityAssurance");
            mentor1.ShowMentorInfo();

            Mentor mentor2 = new Mentor(23, "Alex", "Zaitcev", "development");
            mentor2.ShowMentorInfo();

            Course course1 = new Course("C#");
            Console.WriteLine(course1.CourseTitle);
            Course course2 = new Course("Functional testing");
            Console.WriteLine(course2.CourseTitle);

            CoursesLibrary udemy = new CoursesLibrary();
            udemy.AddNewCourse(course1);
            udemy.AddNewCourse(course2);

            udemy.AssignStudentToCours(student1);
            udemy.AssignStudentToCours(student2);
            udemy.AssignStudentToCours(student3);

            udemy.AssignMentorToCours(mentor1);
            udemy.AssignMentorToCours(mentor2);
        }
    }
}