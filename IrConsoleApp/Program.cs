using ClassLibraryHW5;
using IrynaZharnasek.Lecture4;
using System.Xml.Linq;

namespace IrynaZharnasek
{
    public class Program
    {
        public static void Main()
        {
            Employees emp1 = new(29, "Brian","Colier", "Product Owner");
            Employees emp2 = new(30);
            Employees emp3 = new("David");
            Employees emp4 = new("Jennyfer", "Anderson");
            Employees emp5 = new("Daniel", "Sharipo", "Software Developer");
            Employees emp6 = new();
                       
            emp1.Print();
            emp2.Print();
            emp3.Print();
            emp4.Print();
            emp5.Print(); 
            emp6.Print();
            Company iTechArt = new Company();
            iTechArt.Print();
            
        }
        public class Company
        {
            public string companyName = "iTechArt";
            Employees[] mass = new Employees[5];
            public void Print() => Console.WriteLine($"{mass.Length} employees works for {companyName} company");
            //public void Print() => Console.WriteLine($"{mass.Length}");

            //employees[0] = Employees.emp1;
        }
        
    }
}