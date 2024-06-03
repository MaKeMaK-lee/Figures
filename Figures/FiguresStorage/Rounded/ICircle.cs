namespace Figures.FiguresStorage.Rounded
{
    /// <summary>
    /// Представляет функционал для работы с кругом
    /// </summary>
    public interface ICircle : IFigure
    {
        /// <summary>
        /// Получает радиус окружности
        /// </summary>
        public float R { get; }
    }
}
