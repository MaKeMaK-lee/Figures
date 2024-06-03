namespace Figures.FiguresStorage.Polygons
{
    /// <summary>
    /// Представляет функционал для работы с треугольником
    /// </summary>
    public interface ITriangle
    {
        /// <summary>
        /// Получает длину стороны a треугольника
        /// </summary>
        public float A { get; }

        /// <summary>
        /// Получает длину стороны b треугольника
        /// </summary>
        public float B { get; }

        /// <summary>
        /// Получает длину стороны c треугольника
        /// </summary>
        public float C { get; }
    }
}
