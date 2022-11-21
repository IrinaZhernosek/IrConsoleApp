using ClassLibraryHW5;
using IrynaZharnasek.Lecture4;
using IrynaZharnasek.Lecture5;
using System.Linq.Expressions;
using System.Xml.Linq;

namespace IrynaZharnasek
{
    public class Program
    {
        public static void Main()
        {
            Employee emp1 = new(29, "Brian","Colier", "Product Owner");
            Employee emp2 = new(30);
            Employee emp3 = new("David");
            Employee emp4 = new("Jennyfer", "Anderson");
            Employee emp5 = new("Daniel", "Sharipo", "Software Developer");
            Employee emp6 = new();
            Employee emp7 = new(35, "Torrance", "Hullian", "Software Developer");
                       
            emp1.Print();
            emp2.Print();
            emp3.Print();
            emp4.Print();
            emp5.Print(); 
            emp6.Print();
            emp7.Print();
            Company iTechArt = new Company();
            //for edding new employees to Company
            iTechArt.AddNewEmployee(emp1);
            iTechArt.AddNewEmployee(emp2);
            iTechArt.AddNewEmployee(emp3);
            iTechArt.AddNewEmployee(emp4);
            iTechArt.AddNewEmployee(emp5);
            iTechArt.AddNewEmployee(emp6);
            iTechArt.AddNewEmployee(emp7);
            //Show count of all employees:
            iTechArt.ShowTotalNumbersOfEmployees();
            //show Name/Surname for all employees:
            iTechArt.ShowAllEmployees();
            //show employees Name/Surname by 'Software Daveliper' position:
            iTechArt.ShowEmployeesByPosition();

            iTechArt.GetEmployee(6);
        }  
    }
}