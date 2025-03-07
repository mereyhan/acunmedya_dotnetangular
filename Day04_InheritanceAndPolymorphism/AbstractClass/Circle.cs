using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04_InheritanceAndPolymorphism.AbstractClass
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius) : base("Circle")
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

    }
}
