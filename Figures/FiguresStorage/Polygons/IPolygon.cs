
using System.Numerics;

namespace Figures.FiguresStorage.Polygons
{
    /// <summary>
    /// Представляет функционал для работы с многоугольником
    /// </summary>
    public interface IPolygon : IFigure
    {
        /// <summary>
        /// Получает упорядоченный набор сторон многоугольника, представленный в виде векторов 
        /// </summary>
        IEnumerable<Vector2> Sides
        {
            get;
        }
    }
}
