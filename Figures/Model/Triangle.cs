using System;

namespace Figures.Model
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public class Triangle
    {
        /// <summary>
        /// Конструктор класса "Треугольник"
        /// </summary>
        /// <param name="firstSide"> Первая сторона </param>
        /// <param name="secondSide"> Вторая сторона </param>
        /// <param name="thirdSide"> Третья сторона </param>
        /// <exception cref="ArgumentException"> Аргументы не могут принимать нулевые или отрицательные вхождения </exception>
        public Triangle(int firstSide, int secondSide, int thirdSide) 
        {
            #region Блок проверок
            if (firstSide <= 0)
            {
                throw new ArgumentException("Сторона не может быть меньше либо равна нулю", nameof(firstSide));
            }
            if (secondSide <= 0)
            {
                throw new ArgumentException("Сторона не может быть меньше либо равна нулю", nameof(secondSide));
            }
            if (thirdSide <= 0)
            {
                throw new ArgumentException("Сторона не может быть меньше либо равна нулю", nameof(thirdSide));
            }
            #endregion

            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }

        #region Свойства
        /// <summary>
        /// Сторона треугольника
        /// </summary>
        protected int FirstSide { get; set; }
        /// <summary>
        /// Сторона треугольника
        /// </summary>
        protected int SecondSide { get; set; }
        /// <summary>
        /// Сторона треугольника
        /// </summary>
        protected int ThirdSide { get; set; }
        /// <summary>
        /// Площадь треугольника
        /// </summary>
        protected double Square { get; set; }
        #endregion

        /// <summary>
        /// Ищет максимальное значение из всех сторон и проверяет на существование данного треугольника
        /// </summary>
        /// <returns> Значение true, если треугольник существует, false - в ином случае </returns>
        public bool CheckingExistenceTriangle()
        {

            if (FirstSide <= 0 || SecondSide <= 0 || ThirdSide <= 0) return false;

            if (FirstSide > SecondSide && FirstSide > ThirdSide && FirstSide < (SecondSide + ThirdSide))
            {
                return true;
            }
            else if (SecondSide > FirstSide && SecondSide > ThirdSide && SecondSide < (FirstSide + ThirdSide))
            {
                return true;
            }
            else if (ThirdSide > FirstSide && ThirdSide > SecondSide && ThirdSide < (FirstSide + SecondSide))
            {
                return true;
            }
            else if (FirstSide == SecondSide && FirstSide == ThirdSide && SecondSide == ThirdSide)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Находит площадь треугольника
        /// </summary>
        /// <returns> Значение площади треугольника </returns>
        public double FindingSquare()
        {
            double perimeter = FirstSide + SecondSide + ThirdSide;
            return Square = Math.Sqrt(perimeter * (perimeter - FirstSide) * (perimeter - SecondSide) * (perimeter - ThirdSide));
        }
    }
}
