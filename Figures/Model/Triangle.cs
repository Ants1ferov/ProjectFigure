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
        public Triangle(double firstSide, double secondSide, double thirdSide) 
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
        protected double FirstSide { get; private set; }
        /// <summary>
        /// Сторона треугольника
        /// </summary>
        protected double SecondSide { get; private set; }
        /// <summary>
        /// Сторона треугольника
        /// </summary>
        protected double ThirdSide { get; private set; }
        /// <summary>
        /// Площадь треугольника
        /// </summary>
        protected double Square { get; private set; }
        /// <summary>
        /// Булевое значение проверки является ли треугольник прямоугольным
        /// </summary>
        public bool IsTriangleRectangular { get; private set; }
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
                IsTriangleRectangular = CheckingTriangleRightTriangle(hypotenuse: FirstSide,
                                                                      firstLeg: SecondSide,
                                                                      secondLeg: ThirdSide);
                return true;

            }    
            else if (SecondSide > FirstSide && SecondSide > ThirdSide && SecondSide < (FirstSide + ThirdSide))
            {
                IsTriangleRectangular = CheckingTriangleRightTriangle(hypotenuse: SecondSide,
                                                                      firstLeg: FirstSide,
                                                                      secondLeg: ThirdSide);
                return true;
            }
            else if (ThirdSide > FirstSide && ThirdSide > SecondSide && ThirdSide < (FirstSide + SecondSide))
            {
                IsTriangleRectangular = CheckingTriangleRightTriangle(hypotenuse: ThirdSide,
                                                                      firstLeg: FirstSide,
                                                                      secondLeg: SecondSide);
                return true;
            }
            else if (FirstSide == SecondSide && FirstSide == ThirdSide && SecondSide == ThirdSide)
            {
                IsTriangleRectangular = false;
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Проверяет является ли заданный треугольник прямоугольным
        /// </summary>
        /// <param name="hypotenuse"> Гипотенуза </param>
        /// <param name="firstLeg"> Первый катет </param>
        /// <param name="secondLeg"> Второй катет </param>
        /// <returns> Значение true, если треугольник соответствует условию, false - в ином случае </returns>
        private bool CheckingTriangleRightTriangle(double hypotenuse, double firstLeg, double secondLeg)
        {
            if (Math.Pow(hypotenuse,2) == (Math.Pow(firstLeg,2) + Math.Pow(secondLeg, 2)))
                return true;
            else
                return false;
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
