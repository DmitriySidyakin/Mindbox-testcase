namespace GeometryClassLibrary
{
    /// <summary>
    /// Класс представляющий круг
    /// </summary>
    public class Circle : IFigure
    {
        /// <summary>
        /// Радиус круга
        /// </summary>
        public double Radius { get; set; }

        /// <summary>
        /// Основной конструктор
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        public Circle(double radius) { if (radius < 0) throw new ArgumentOutOfRangeException(); Radius = radius; }

        /// <summary>
        /// Вычисляемое поле, только для чтения. Представляет собой площадь круга.
        /// </summary>
        public double Square
        {
            // S = π × r^2
            get { return Math.PI * Radius * Radius; }
        }
    }
}