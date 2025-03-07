using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04_InheritanceAndPolymorphism.AbstractClass
{
    abstract class Shape
    {
        public string Name { get; set; }

        public Shape(string name)
        {
            Name = name;
        }

        // Soyut metot: Alt sınıflar override etmek zorunda
        public abstract double CalculateArea();

        // Soyut olmayan metot: Alt sınıflar doğrudan kullanabilir
        public void Display()
        {
            Console.WriteLine($"Shape: {Name}, Area: {CalculateArea():F2}");
        }
    }
}
