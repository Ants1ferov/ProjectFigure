using System;

namespace Figures.Model
{
    /// <summary>
    /// Круг
    /// </summary>
    public class Circle
    {
        /// <summary>
        /// Конструктор класса "Круг"
        /// </summary>
        /// <param name="radius"> Радиус </param>
        /// <exception cref="ArgumentException"> Аргументы не могут принимать нулевые или отрицательные вхождения </exception>
        public Circle(int radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Радиус не может быть меньше либо равен нулю", nameof(radius));
            }

            Radius = radius;
        }

        #region Свойства
        /// <summary>
        /// Площадь круга
        /// </summary>
        public int Square { get; private set; }
        /// <summary>
        /// Радиус круга
        /// </summary>
        public int Radius { get; private set; }
        #endregion

        /// <summary>
        /// Находит площадь круга
        /// </summary>
        /// <returns> Значение площади круга </returns>
        public double FindingSquare()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
