using RentalCar.Application.port.Out;
using RentalCar.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCar.Application.port.In
{
    public class RentalCarUseCase : IRentalCarUseCase
    {
        private readonly IRentalCarRepository _rentalCarRepository;

        public RentalCarUseCase(IRentalCarRepository rentalCarRepository)
        {
            _rentalCarRepository = rentalCarRepository;
        }
        public IEnumerable<IVehicle> GetAllCars()
        {
            return _rentalCarRepository.GetAllCars();
        }

        public bool ToRentCar(IVehicle car)
        {
            throw new NotImplementedException();
        }
    }
}
