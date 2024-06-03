using Figures.Utilities;
using System.Numerics;

namespace Figures.FiguresStorage.Polygons
{
    /// <summary>
    /// Представляет прямоугольный треугольник с катетами A и B и гипотенузой C
    /// </summary>
    public class TriangleRight : Triangle
    {
        public override float CalculateArea() => A * B / 2;

        public override bool Validate()
        {
            if (base.Validate())
                if (Math.Abs(Vector2Utilities.AngleBetween(-sides[0], sides[1])) == 90)
                    return true;

            return false;
        }

        /// <summary>
        /// Создаёт прямоугольный треугольник на основе rfntnjd
        /// </summary>
        /// <param name="a">Катет a создаваемого квадрата</param>
        /// <param name="b">Катет b создаваемого квадрата</param>
        public TriangleRight(float a, float b) : this([
            new(a,0),
            new(0,-b)
            ])
        {

        }

        /// <summary>
        /// Создаёт прямоугольный треугольник на основе имеющихся сторон (достраивает одну сторону, если они не замкнуты)
        /// </summary>
        /// <param name="triangleSides">Последовательный набор сторон в формате векторов</param>
        public TriangleRight(IEnumerable<Vector2> triangleSides) : base(triangleSides)
        {
            MoveSides();
        }

        /// <summary>
        /// Меняет местами стороны в списке так, чтобы катеты были на позициях 0 и 1 
        /// </summary>
        private void MoveSides()
        {
            int offset = 0;

            if (Math.Abs(Vector2Utilities.AngleBetween(sides[0], sides[1])) == 90)
                return;
            if (Math.Abs(Vector2Utilities.AngleBetween(sides[1], sides[2])) == 90)
                offset = 2;
            if (Math.Abs(Vector2Utilities.AngleBetween(sides[2], sides[0])) == 90)
                offset = 1;

            sides = [
                sides[(0 + offset) % 3],
                sides[(1 + offset) % 3],
                sides[(2 + offset) % 3]];

        }
    }
}
