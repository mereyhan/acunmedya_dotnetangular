using Day04_InheritanceAndPolymorphism.AbstractClass;
using Day04_InheritanceAndPolymorphism.BankOperations;
using Day04_InheritanceAndPolymorphism.Interface;
using Day04_InheritanceAndPolymorphism.Staff;
using System.Drawing;

namespace Day04_InheritanceAndPolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Staff
            Manager manager = new Manager(1, "Atlas", 50000, "Electronics", 5);
            manager.DisplayInfo();
            Console.WriteLine($"Bonus: {manager.CalculateBonus()} TL\n");

            Developer developer = new Developer(2, "Mehmet", 40000, "Software", ".NET & Angular Developer");
            developer.DisplayInfo();
            Console.WriteLine($"Bonus: {developer.CalculateBonus()} TL\n");

            // BankOperations
            SavingsAccount savings = new SavingsAccount("Ensar", 10000);
            savings.DisplayInfo();
            savings.CalculateInterest();
            Console.WriteLine();

            CheckingAccount checking = new CheckingAccount("Semih", 5000);
            checking.DisplayInfo();
            checking.CalculateInterest();
            Console.WriteLine("\n\n");

            // Araç yönetimi testleri
            ICarService carService = new CarManager();

            // Create
            Car car1 = new Car { Id = 1, Brand = "Toyota", Model = "Corolla" };
            carService.CreateCar(car1);
            Car car2 = new Car { Id = 2, Brand = "Honda", Model = "Civic" };
            carService.CreateCar(car2);

            // Read
            Console.WriteLine("\nTüm Araçlar:");
            foreach (var car in carService.ReadCar())
            {
                Console.WriteLine($"ID: {car.Id}, Brand: {car.Brand}, Model: {car.Model}");
            }

            // Update
            Car updatedCar = new Car { Id = 1, Brand = "Toyota", Model = "Camry" };
            carService.UpdateCar(updatedCar);

            // Delete
            carService.DeleteCar(2);

            Console.WriteLine("\nGüncel Liste:");
            foreach (var car in carService.ReadCar())
            {
                Console.WriteLine($"ID: {car.Id}, Brand: {car.Brand}, Model: {car.Model}");
            }
            Console.WriteLine("\n\n");

            // Kiralama işlemleri
            IRentalService rentalService = new RentalManager();

            // Create
            Rental rental1 = new Rental { Id = 101, CarId = 1, Renter = "Ahmet", StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(7) };
            rentalService.CreateRental(rental1);

            // Read
            Console.WriteLine("\nTüm Kiralamalar:");
            foreach (var rental in rentalService.ReadRental())
            {
                Console.WriteLine($"Rental ID: {rental.Id}, Car ID: {rental.CarId}, Renter: {rental.Renter}, Start: {rental.StartDate}, End: {rental.EndDate}");
            }

            // Update
            Rental updatedRental = new Rental { Id = 101, CarId = 1, Renter = "Ahmet", StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(7) };
            rentalService.UpdateRental(updatedRental);

            // Delete
            rentalService.DeleteRental(101);
            Console.WriteLine("\nGüncel Liste:");
            foreach (var rental in rentalService.ReadRental())
            {
                Console.WriteLine($"Rental ID: {rental.Id}, Car ID: {rental.CarId}, Renter: {rental.Renter}, Start: {rental.StartDate}, End: {rental.EndDate}");
            }
            Console.WriteLine("\n\n");

            // Alan Hesaplamaları
            Shape circle = new Circle(5);
            Shape triangle = new Triangle(3, 4, 5);

            circle.Display();
            triangle.Display();

        }
    } 
}
