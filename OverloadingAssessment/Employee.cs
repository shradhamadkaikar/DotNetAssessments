using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo.OverloadingAssessment
{
    public class Employee
    {
        private int id;
        private string name;
        private double salary;

        // Constructor with ID, Name, and Salary
        public Employee(int id, string name, double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public void Display()
        {
            Console.WriteLine($"ID: {id}\n" +
                $"Name: {name}\n" +
                $"Salary: {salary}");
        }
    }
}
