namespace ClassLibraryHW5
{
    public class Employees
    {
        public int age;
        public string name;
        public string surname;
        public string position;

        public Employees(int age, string name, string surname, string position)
        {
            this.age = age;
            this.name = name;
            this.surname = surname;
            this.position = position;
        }

        public Employees() { age = 24; name = "Jon"; surname = "Golt"; position = "engineer"; }

        public void Print() => Console.WriteLine($"name {name} age:{age} surname:{surname}");

    }


    /*public class Person
    {
        public string name = "Undefined";   // имя
        public int age;                     // возраст

        public void Print()
        {
            Person Tom = new Person();  // создание объекта класса Person
            Console.WriteLine($"Имя: {name}  Возраст: {age}");
        }
    }*/
}