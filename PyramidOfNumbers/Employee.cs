using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyramidOfNumbers
{
    class Employee
    {
        public string Name { get; set; }
        public int YearOfHiring { get; set; }
        public decimal Salary { get; set; }

        public Employee() {}

        public Employee(string name, int yearOfHiring, decimal salary)
        {
            this.Name = name;
            this.YearOfHiring = yearOfHiring;
            this.Salary = salary;
        }

        //Destuctor
        ~Employee()
        {
            Console.WriteLine("Destuctor was called.");
        }

        //Copy constructor
        public Employee(Employee copiedEmployee)
        {
            this.Name = copiedEmployee.Name;
            this.YearOfHiring = copiedEmployee.YearOfHiring;
            this.Salary = copiedEmployee.Salary;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {this.Name} - Year of hiring: {this.YearOfHiring}" +
                $" - Salary: {this.Salary}");
        }
    }
}
