using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04_InheritanceAndPolymorphism.Interface
{
    public class CarManager : ICarService
    {
        private List<Car> _cars = new List<Car>();

        public void CreateCar(Car car)
        {
            _cars.Add(car);
            Console.WriteLine($"Car created: {car.Brand} {car.Model}");
        }

        public List<Car> ReadCar()
        {
            return _cars;
        }

        public void UpdateCar(Car car)
        {
            var existingCar = _cars.FirstOrDefault(c => c.Id == car.Id);
            if (existingCar != null)
            {
                existingCar.Model = car.Model;
                existingCar.Brand = car.Brand;
                Console.WriteLine($"Car updated: {car.Brand} {car.Model}");
            }
        }

        public void DeleteCar(int carId)
        {
            var car = _cars.FirstOrDefault(c => c.Id == carId);
            if (car != null)
            {
                _cars.Remove(car);
                Console.WriteLine($"Car deleted: {car.Brand} {car.Model}");
            }
        }
    }
}
