using Figures.Model;
using System;

namespace ConsoleForms
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("========Меню=======");
                Console.Write("Площадь какой фигуры вы хотите посчитать?\n" +
                    "1. Круг\n" +
                    "2. Треугольник\n" +
                    "Впишите номер соответствующего пункта: ");
                InputValidation(out double number);

                switch (number)
                {
                    case 1:
                        CreatingCircle();
                        break;
                    case 2:
                        CreatingTriangle();
                        break;
                    default:
                        Console.WriteLine("Введен некорректный номер!");
                        break;
                }

                Console.WriteLine("Для продолжения нажмите Enter...");
                Console.ReadLine();

                Console.Clear();
            }
        }

        /// <summary>
        /// Реализует создание круга
        /// </summary>
        static void CreatingCircle()
        {
            Console.Write("Введите значение радиуса: ");
            InputValidation(out double value);

            Circle circle = new Circle(radius: value);

            Console.WriteLine($"Площадь круга равна {circle.FindingSquare()} у.е.");
        }

        /// <summary>
        /// Реализует создание треугольника
        /// </summary>
        static void CreatingTriangle()
        {
            Console.Write("Введите значение первой стороны: ");
            InputValidation(out double firstSide);
            Console.Write("Введите значение второй стороны: ");
            InputValidation(out double secondSide);
            Console.Write("Введите значение третьей стороны: ");
            InputValidation(out double thirdSide);

            Triangle triangle = new Triangle(firstSide, secondSide, thirdSide);

            if (triangle.CheckingExistenceTriangle())
            {
                Console.WriteLine($"Площадь треугольника: {triangle.FindingSquare()}");
                Console.WriteLine($"Треугольник прямоугольный: {triangle.IsTriangleRectangular}");
            }
            else
            {
                Console.WriteLine("Данный треугольник не существует!");
            }
        }

        /// <summary>
        /// Проверяет корректность ввода на числа
        /// </summary>
        /// <param name="value"> Значение </param>
        /// <returns> Корректное числовое значение </returns>
        static double InputValidation(out double value)
        {
            string input = Console.ReadLine();

            while (!double.TryParse(input, out value))
            {
                Console.Write("Введены неверные данные\nВведите снова значение: ");
                input = Console.ReadLine();
            }

            if (value <= 0)
            {
                Console.Write("Значение не может быть меньше или равным нуля\nВведите снова значение: ");
                InputValidation(out value);
            }

            return value;
        }
    }
}
