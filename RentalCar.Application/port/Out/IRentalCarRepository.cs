//using Domain.Lab120240821;
using RentalCar.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCar.Application.port.Out
{
    public interface IRentalCarRepository
    {
        bool AddCar(IVehicle car);
        bool RemoveCar(IVehicle car);
        bool UpdateCar(IVehicle car);

        IEnumerable<IVehicle> GetAllCars();
    }
}

