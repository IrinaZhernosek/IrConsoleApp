using ClassLibraryHW5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrynaZharnasek.Lecture6
{
    public class _Employee //adding new class
    {
        //defining of class parameters:
        private int age;
        private string name;
        private string surname;
        private string position;

        //the first constructor:
        public _Employee(int age = 0, string name = "underfined", string surname = "underfined", string position = "underfined")
        {
            this.age = age;
            this.name = name;
            this.surname = surname;
            this.position = position;
        }

        //constructor 2 - only age:
        public _Employee(int age) : this(age, "underfind", "underfind", "underfind")
        {

        }
        //constructor 3- only name:
        public _Employee(string name) : this(0, name, "underfind", "underfind")
        {

        }

        //constructor 4- name + surname:
        public _Employee(string name, string surname) : this(0, name, surname, "underfind")
        {

        }

        //constructor 5 - name + surname + position:
        public _Employee(string name, string surname, string position) : this(0, name, surname, position)
        {

        }
        //constructor 6 - by default:
        public _Employee()
        {

        }
        public void ShowEmployeeInfo() => Console.WriteLine($"name: {name} surname:{surname} age:{age} position: {position}");

        public void ShowEmployeeNameSurName() => Console.WriteLine($"name: {name} surname:{surname}");

        public string GetPosition() => position;
    }

    public class _Company
    {
        private string companyName;
        private _Employee[] arrayOfEmployees = new _Employee[100];

        public void AddNewEmployee(_Employee employee)
        {
            for (var i = 0; i < arrayOfEmployees.Length; i++)
            {
                if (arrayOfEmployees[i] == null)
                {
                    arrayOfEmployees[i] = employee;
                    break;
                }
            }
        }

        public void ShowTotalNumbersOfEmployees()
        {
            var count = 0;
            for (var i = 0; i < arrayOfEmployees.Length; i++)
            {
                if (arrayOfEmployees[i] != null)
                {
                    count = i + 1;
                    Console.WriteLine($"General count of employees:{count}");
                }
            }
        }

        public void ShowAllEmployees()
        {
            for (var i = 0; i < arrayOfEmployees.Length; i++)
            {
                if (arrayOfEmployees[i] != null)
                {
                    arrayOfEmployees[i].ShowEmployeeNameSurName();
                }
                else break;
            }
        }

        public void ShowEmployeesByPosition()
        {
            for (var i = 0; i < arrayOfEmployees.Length; i++)
            {
                if (arrayOfEmployees[i] != null)
                {
                    if (arrayOfEmployees[i].GetPosition() == "Software Developer")
                    {
                        arrayOfEmployees[i].ShowEmployeeInfo();
                    }
                }
                else break;
            }
        }

        public _Employee GetEmployee(int index)
        {
            return arrayOfEmployees[index];
        }
    }
}
