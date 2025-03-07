using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04_InheritanceAndPolymorphism.Staff
{
    class Employee
    {
        public Employee(int id, string name, double salary, string department)
        {
            Id = id;
            Name = name;
            Salary = salary;
            Department = department;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }

        public virtual double CalculateBonus()
        {
            return 0;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Salary: {Salary} TL, Department: {Department}");
        }
    }
}
