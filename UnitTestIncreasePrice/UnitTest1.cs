using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HannahByrne_S00189764;

namespace UnitTestIncreasePrice
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIncreasePrice()
        {
            // Arrange
            Phone phone1 = new Phone();
            decimal expectedPrice = 550;
            // Act
            phone1.IncreasePrice(0.1);
            // Assert
            Assert.AreEqual(expectedPrice, phone1.Price);
        }
    }
}
