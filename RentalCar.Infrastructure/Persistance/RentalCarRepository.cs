using RentalCar.Application.port.Out;
using RentalCar.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCar.Infrastructure.Persistance
{
    public class RentalCarRepository : IRentalCarRepository
    {
        private static List<IVehicle> vehicles = new List<IVehicle>(
            new IVehicle[]
            {
                new Car(ModelType.Toyota) { CC = "1.8", Name = "Altis"},
                new Car(ModelType.Toyota) { CC = "2.0", Name = "Camry"},
                new RV(ModelType.Lexus) { CC = "3.5", Name = "RX35"},
                new Car(ModelType.BMW) { CC = "1.5", Name = "i210"},
            });
        public bool AddCar(IVehicle car)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IVehicle> GetAllCars()
        {
            return vehicles;
        }

        public bool RemoveCar(IVehicle car)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCar(IVehicle car)
        {
            throw new NotImplementedException();
        }
    }
}
