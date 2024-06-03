
using System.Numerics;

namespace Figures.FiguresStorage.Polygons
{
    /// <summary>
    /// Представляет квадрат
    /// </summary>
    public class Square : Rectangle
    {
        public override float CalculateArea() => MathF.Pow(A, 2);

        public override float CalculatePerimeter() => A * 4;

        public override bool Validate()
        {
            if (base.Validate())
                if (A == B)//Стороны равны
                    return true;

            return false;
        }

        /// <summary>
        /// Создаёт квадрат на основе стороны
        /// </summary>
        /// <param name="sides">Сторона создаваемого квадрата</param>
        public Square(float a) : base(a, a)
        {

        }

        /// <summary>
        /// Создаёт квадрат на основе имеющихся сторон (достраивает одну сторону, если они не замкнуты)
        /// </summary>
        /// <param name="squareSides">Последовательный набор сторон в формате векторов</param>
        public Square(IEnumerable<Vector2> squareSides) : base(squareSides)
        {

        }

        /// <summary>
        /// Создаёт квадрат на основе имеющегося квадрата
        /// </summary>
        /// <param name="example">Квадрат-образец</param>
        public Square(Square example) : this([.. example.sides])
        {

        }
    }
}
