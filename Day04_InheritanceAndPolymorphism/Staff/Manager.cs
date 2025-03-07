using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04_InheritanceAndPolymorphism.Staff
{
    class Manager : Employee
    {
        public Manager(int id, string name, double salary, string department, int teamSize) : base(id, name, salary, department)
        {
            TeamSize = teamSize;
        }

        public int TeamSize { get; set; }

        public override double CalculateBonus()
        {
            return Salary * 0.2;
        }
    }
}
