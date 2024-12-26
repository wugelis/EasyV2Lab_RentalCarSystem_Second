namespace RentalCar.Domain
{
    public class Car : IVehicle
    {
        private ModelType _modelName;
        private string _cc;
        private string _name;

        public ModelType Model { get => _modelName; set => _modelName = value; }
        public string CC { get => _cc; set => _cc = value; }
        public string Name { get => _name; set => _name = value; }

        public Car(ModelType modelName)
        {
            _modelName = modelName;
        }
        /// <summary>
        /// 計算租車費用
        /// </summary>
        /// <param name="daysRented"></param>
        /// <returns></returns>
        public int CalculateRentalCost(int daysRented)
        {
            return daysRented * (int)_modelName; // 假設為美元
        }

        /// <summary>
        /// 選擇租車時間
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public TimeSpan ChoiseRentalTime(DateTime start, DateTime end)
        {
            return end - start;
        }
        /// <summary>
        /// 取得車輛類型
        /// </summary>
        /// <returns></returns>
        public VehicleType GetVehicleType() => VehicleType.Car;
    }
}

