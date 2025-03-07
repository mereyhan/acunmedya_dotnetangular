using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04_InheritanceAndPolymorphism.AbstractClass
{
    class Triangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double sideA, double sideB, double sideC) : base("Triangle")
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public override double CalculateArea()
        {
            // Heron Formülü: Alan = sqrt(s * (s - a) * (s - b) * (s - c))
            double s = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }
    }
}
