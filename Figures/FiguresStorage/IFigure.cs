
namespace Figures.FiguresStorage
{
    /// <summary>
    /// Представляет функционал для работы с различными плоскими фигурами
    /// </summary>
    public interface IFigure : IInformationStringable, IValidatable
    {
        /// <summary>
        /// Получает площадь фигуры
        /// </summary>
        /// <returns>Площадь фигуры</returns>
        float CalculateArea();

        /// <summary>
        /// Получает перимет фигуры
        /// </summary>
        /// <returns>Периметр фигуры</returns>
        float CalculatePerimeter();

    }
}
