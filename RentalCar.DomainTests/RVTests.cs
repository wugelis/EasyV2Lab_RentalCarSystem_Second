using Microsoft.VisualStudio.TestTools.UnitTesting;
using EasyV2Lab8.Domain8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentalCar.Domain;

namespace EasyV2Lab8.Domain8.Tests
{
    [TestClass()]
    public class RVTests
    {
        // 測試 RAV4 租兩天的價格
        [TestMethod()]
        public void Test_CalculateRentalCost_Toyota_RAV4()
        {
            // Arrange
            IVehicle target = new RV(ModelType.Toyota);
            int actual;
            int excepted = 200;

            // Act
            actual = target.CalculateRentalCost(2);

            // Assert
            Assert.AreEqual(actual, excepted);
        }

        [TestMethod()]
        public void Test_CaculateRentalCost_Lexus_IS()
        {
            // Arrange
            IVehicle target = new Car(ModelType.Lexus);
            int actual;
            int excepted = 300;

            // Act
            actual = target.CalculateRentalCost(2);

            // Assert
            Assert.AreEqual(excepted, actual);
        }
    }
}