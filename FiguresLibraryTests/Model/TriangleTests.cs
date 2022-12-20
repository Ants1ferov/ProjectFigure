using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Figures.Model.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        /// <summary>
        /// Проверяем выдаст ли тест ArgumentException, если одна или более сторон имеют нулевые вхождения
        /// </summary>
        [ExpectedException(typeof(ArgumentException), "")]
        [TestMethod()]
        public void TriangleTestIsZero()
        {
            Triangle _ = new Triangle(7, 0, 0);
        }

        /// <summary>
        /// Проверяем выдаст ли тест ArgumentException, если одна или более сторон имеют отрицательные вхождения
        /// </summary>
        [ExpectedException(typeof(ArgumentException), "")]
        [TestMethod()]
        public void TriangleTestIsLessThanZero()
        {
            Triangle _ = new Triangle(4.3, 1, -9);
        }

        /// <summary>
        /// Проверяем является треугольник прямоугольным
        /// </summary>
        [TestMethod()]
        public void TriangleTestIsRectangular()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            triangle.CheckingExistenceTriangle();
            Assert.AreEqual(true, triangle.IsTriangleRectangular);
        }
    }
}