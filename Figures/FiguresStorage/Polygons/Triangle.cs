using Figures.Utilities;
using System.Numerics;

namespace Figures.FiguresStorage.Polygons
{
    /// <summary>
    /// Представляет треугольник
    /// </summary>
    /// <param name="rectangleSides">Последовательный набор сторон создаваемого треугольника в формате векторов</param>
    public class Triangle(IEnumerable<Vector2> rectangleSides) : Polygon(rectangleSides), ITriangle
    {
        public float A => sides[0].Length();//Этот порядок сейчас используется в TriangleRight наследнике

        public float B => sides[1].Length();//Этот порядок сейчас используется в TriangleRight наследнике

        public float C => sides[2].Length();//Этот порядок сейчас используется в TriangleRight наследнике

        public override float CalculateArea()
        {
            return MathF.Abs(Vector2Utilities.CrossProduct(sides[0], -sides[2])) / 2;
        }

        public override bool Validate()
        {
            if (base.Validate())
                if (sides.Count == 3)
                    return true;

            return false;
        }

        /// <summary>
        /// Создаёт треугольник на основе имеющегося треугольника
        /// </summary>
        /// <param name="example">Треугольник-образец</param>
        public Triangle(Triangle example) : this([.. example.sides])
        {

        }
    }
}
