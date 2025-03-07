using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04_InheritanceAndPolymorphism.Staff
{
    class Developer : Employee
    {
        public Developer(int id, string name, double salary, string department, string about) : base(id, name, salary, department)
        {
            About = about;
        }

        public string About { get; set; }

        public override double CalculateBonus()
        {
            return Salary * 0.1;
        }

    }
}
