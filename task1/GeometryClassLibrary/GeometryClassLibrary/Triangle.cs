using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryClassLibrary
{
    /// <summary>
    /// Класс представляющий треугольник
    /// </summary>
    public class Triangle : IFigure
    {
        /// <summary>
        /// Сторона A
        /// </summary>
        public double A { get; set; }

        /// <summary>
        /// Сторона B
        /// </summary>
        public double B { get; set; }

        /// <summary>
        /// Сторона C
        /// </summary>
        public double C { get; set; }

        /// <summary>
        /// Основной конструктор
        /// </summary>
        /// <param name="a">Сторона a</param>
        /// <param name="b">Сторона b</param>
        /// <param name="c">Сторона c</param>
        public Triangle(double a, double b, double c)
        {
            if (A < 0 || B < 0 || C < 0) throw new ArgumentOutOfRangeException();
            A = a; B = b; C = c;
        }

        /// <summary>
        /// Вычисляемое поле, только для чтения. Представляет собой площадь треугольника.
        /// </summary>
        public double Square
        {
            get
            {
                double p = (A + B + C) / 2;
                return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            }
        }

        /// <summary>
        /// Метод вычисляет правильный ли это треугольник c погрешностью 0.2
        /// </summary>
        /// <returns>true - если треугольник правильный, c погрешностью 0.2</returns>
        public bool IsItRightTriangle()
        {
            double max = Math.Max(A, B);
            max = Math.Max(C, max);
            return ((A * A + B * B + C * C) - max * max >= max * max - 0.1) && ((A * A + B * B + C * C) - max * max <= max * max + 0.1);
        }
    }
}
