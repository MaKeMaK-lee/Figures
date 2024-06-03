namespace Figures.FiguresStorage.Rounded
{
    /// <summary>
    /// Представляет функционал для работы с эллипсом
    /// </summary>
    public interface IEllipse : IFigure
    {
        /// <summary>
        /// Получает полуось A эллипса
        /// </summary>
        public float A { get; }

        /// <summary>
        /// Получает полуось B эллипса
        /// </summary>
        public float B { get; }
    }
}
