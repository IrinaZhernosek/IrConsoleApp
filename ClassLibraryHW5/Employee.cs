namespace ClassLibraryHW5
{
    public class Employee //adding new class
    {
        //defining of class parameters:
        public int age;
        public string name;
        public string surname;
        public string position;

        //the first constructor:
        public Employee(int age = 0, string name = "underfined", string surname = "underfined", string position = "underfined")
        {
            this.age = age;
            this.name = name;
            this.surname = surname;
            this.position = position;
        }

        //constructor 2 - only age:
        public Employee (int age) : this(age, "underfind", "underfind", "underfind")
        {

        }
        //constructor 3- only name:
        public Employee (string name) : this(0, name, "underfind", "underfind")
        {

        }

        //constructor 4- name + surname:
        public Employee (string name, string surname) : this(0, name, surname, "underfind")
        {

        }

        //constructor 5 - name + surname + position:
        public Employee(string name, string surname, string position) : this(0, name, surname, position)
        {

        }
        //constructor 6 - by default:
        public Employee()
        {
        
        }

    public void Print() => Console.WriteLine($"name: {name} surname:{surname} age:{age} position: {position}");
    }  
}