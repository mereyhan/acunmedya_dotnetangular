using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04_InheritanceAndPolymorphism.Interface
{
    public class RentalManager : IRentalService
    {
        private List<Rental> _rentals = new List<Rental>();

        public void CreateRental(Rental rental)
        {
            _rentals.Add(rental);
            Console.WriteLine($"Rental created: Car {rental.CarId} rented by {rental.Renter}");
        }

        public List<Rental> ReadRental()
        {
            return _rentals;
        }

        public void UpdateRental(Rental rental)
        {
            var existingRental = _rentals.FirstOrDefault(r => r.Id == rental.Id);
            if (existingRental != null)
            {
                existingRental.CarId = rental.CarId;
                existingRental.Renter = rental.Renter;
                existingRental.StartDate = rental.StartDate;
                existingRental.EndDate = rental.EndDate;
                Console.WriteLine($"Rental updated: {rental.Renter} now renting Car {rental.CarId}");
            }
        }

        public void DeleteRental(int rentalId)
        {
            var rental = _rentals.FirstOrDefault(r => r.Id == rentalId);
            if (rental != null)
            {
                _rentals.Remove(rental);
                Console.WriteLine($"Rental deleted: {rental.Renter} no longer renting Car {rental.CarId}");
            }
        }
    }
}