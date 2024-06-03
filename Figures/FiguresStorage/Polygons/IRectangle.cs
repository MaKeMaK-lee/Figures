namespace Figures.FiguresStorage.Polygons
{
    /// <summary>
    /// Представляет функционал для работы с прямоугольником
    /// </summary>
    public interface IRectangle : IFigure
    {
        /// <summary>
        /// Получает длину стороны a прямоугольника
        /// </summary>
        public float A { get; }

        /// <summary>
        /// Получает длину стороны b прямоугольника
        /// </summary>
        public float B { get; }
    }
}
