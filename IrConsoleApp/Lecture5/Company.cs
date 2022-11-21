﻿using ClassLibraryHW5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrynaZharnasek.Lecture5
{
    public class Company
    {
        private string companyName;
        private Employee[] arrayOfEmployees = new Employee[100];

        public void AddNewEmployee(Employee employee)
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
        public void ShowTotalNumbersOfEmployees ()
        {
            var count =0;
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
                    Console.WriteLine($"Name: {arrayOfEmployees[i].name}  Surname: {arrayOfEmployees[i].surname}");
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
                    if (arrayOfEmployees[i].position == "Software Developer")
                    {
                        Console.WriteLine($"Name: {arrayOfEmployees[i].name}  Surname: {arrayOfEmployees[i].surname} Position: {arrayOfEmployees[i].position}"); 
                    }
                }
                else break;
            }
        }
        public Employee GetEmployee (int index) 
        {
            return arrayOfEmployees[index];
            Console.WriteLine(GetEmployee(index));
        
        }
    }
}
