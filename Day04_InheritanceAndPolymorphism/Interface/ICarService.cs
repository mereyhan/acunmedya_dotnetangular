using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Day04_InheritanceAndPolymorphism.Interface
{
    public interface ICarService
    {
        void CreateCar(Car car);
        List<Car> ReadCar();
        void UpdateCar(Car car);
        void DeleteCar(int carId);
    }
}
