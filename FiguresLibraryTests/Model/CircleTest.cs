using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Figures.Model.Tests
{
    [TestClass()]
    public class CircleTest
    {
        /// <summary>
        /// Проверяем выдаст ли тест ArgumentException, если радиус имеет нулевое вхождение
        /// </summary>
        [ExpectedException(typeof(ArgumentException), "")]
        [TestMethod()]
        public void CircleTestIsZero()
        {
            Circle _ = new Circle(0);
        }

        /// <summary>
        /// Проверяем выдаст ли тест ArgumentException, если радиус имеет отрицательное вхождение
        /// </summary>
        [ExpectedException(typeof(ArgumentException), "")]
        [TestMethod()]
        public void CircleTestIsLessThanZero()
        {
            Circle _ = new Circle(-14.3);
        }

        /// <summary>
        /// Проверяем соответствует ли исходное значение площади круга с полученным
        /// </summary>
        [TestMethod()]
        public void CircleTestIsGreaterThanZero()
        {
            Circle circle = new Circle(8);
            Assert.AreEqual(201.061929829747, circle.FindingSquare(), 1E-6);
        }
    }
}
