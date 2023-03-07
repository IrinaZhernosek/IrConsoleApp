using IrynaZharnasek.Lecture8.Task2;

namespace IrynaZharnasek.Lecture8
{
    static class Lecture8Runner
    {
        public static void Lecture8RunAllTasks()
        {

        }
        //task 1
        
        public static void RunTask1()
        {
            try
            {
                IrynaZharnasek.Lecture8.Task1.Massive.ShowMassiveElement();
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("The entered value is outside the array");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("The array element index was not entered");
            }
            catch (FormatException)
            {
                Console.WriteLine("The entered value is in the wrong format. Please, use numeric format!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"There was exception: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Thank you for your attention! Have a good day!");
            }
        }
        //task2
        public static void RunTask2()
        {
            try
            {
                PersonalDocuments personalDocuments = new PersonalDocuments("Temporary residence permit", "1444444444444444444");
                Console.WriteLine($"The docoment name is: {personalDocuments.docName}");
                Console.WriteLine($"The docoment ID is: {personalDocuments.DocId}");
            }
            catch (DocIdException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally { Console.WriteLine("Program is finished!"); }
        }
    }
}
