using Figures.Utilities;
using System.Numerics;

namespace Figures.FiguresStorage.Polygons
{
    /// <summary>
    /// Представляет прямоугольник
    /// </summary>
    /// <param name="rectangleSides">Последовательный набор сторон создаваемого прямоугольника в формате векторов</param>
    public class Rectangle(IEnumerable<Vector2> rectangleSides) : Polygon(rectangleSides), IRectangle
    {
        public virtual float A => sides[0].Length();

        public float B => sides[1].Length();

        public override float CalculateArea() => A * B;

        public override float CalculatePerimeter() => A * 2 + B * 2;

        public override bool Validate()
        {
            if (base.Validate())
                if (sides.Count == 4)
                    if (Math.Abs(Vector2Utilities.AngleBetween(sides[0], sides[1])) == 90//Один угол прямой
                        && sides[0].Length() == sides[2].Length()
                        && sides[1].Length() == sides[3].Length())//Противоположные стороны равны
                        return true;

            return false;
        }

        /// <summary>
        /// Создаёт прямоугольник на основе имеющихся сторон (достраивает одну сторону, если они не замкнуты)
        /// </summary>
        /// <param name="sides">Последовательный набор сторон в формате векторов</param>
        public Rectangle(float a, float b) : this([
            new Vector2(a,0), new Vector2(0,b),
            new Vector2(-a,0), new Vector2(0,-b)])
        {

        }
    }
}
