
using System.Numerics;

namespace Figures.FiguresStorage.Polygons
{
    /// <summary>
    /// Представляет функционал для работы с многоугольником
    /// </summary>
    public interface IPolygon : IFigure
    {
        /// <summary>
        /// Получает набор сторон многоугольника 
        /// </summary>
        IEnumerable<Vector2> Sides
        {
            get;
        }
    }
}
