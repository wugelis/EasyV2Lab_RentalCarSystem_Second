using RentalCar.Application.port.In;
using RentalCar.Application.port.Out;
using RentalCar.Domain;
//using Domain.Lab120240821;

namespace RentalCar.Application
{
    public class RentalCarSerAppServices
    {
        private readonly IRentalCarRepository _rentalCarRepository;
        private readonly IRentalCarUseCase _rentalCarUseCase;

        public RentalCarSerAppServices(IRentalCarRepository rentalCarRepository, IRentalCarUseCase rentalCarUseCase)
        {
            _rentalCarRepository = rentalCarRepository;
        }
        public IEnumerable<IVehicle>? GetAllCars()
        {
            return _rentalCarUseCase.GetAllCars();
        }

        public bool ToRentCar(IVehicle car)
        {
            Car mycar = new Car(car.Model) { CC = car.CC };

            return _rentalCarRepository.AddCar(car);
        }
    }
}

