using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04_InheritanceAndPolymorphism.Interface
{
    public interface IRentalService
    {
        void CreateRental(Rental rental);
        List<Rental> ReadRental();
        void UpdateRental(Rental rental);
        void DeleteRental(int rentalId);
    }
}
