using Figures.Utilities;
using System.Drawing;
using System.Numerics;

namespace Figures.FiguresStorage.Polygons
{
    /// <summary>
    /// Представляет многоугольник с произвольным количеством сторон
    /// </summary>
    public class Polygon : IPolygon
    {
        /// <summary>
        /// Упорядоченный набор сторон многоугольника, представленный в виде векторов
        /// </summary>
        protected IList<Vector2> sides;

        public IEnumerable<Vector2> Sides => sides.Where(s => true);

        public virtual float CalculateArea()
        {
            var vertices = CalculateVertices(1);
            vertices.Add(vertices.First());

            float sumOfMultipliesCurrentXOnNextY = 0;
            float sumOfMultipliesCurrentXOnPrevY = 0;
            int i = 0;

            sumOfMultipliesCurrentXOnNextY += vertices[i].X * vertices[i + 1].Y;
            for (i = 1; i < vertices.Count - 1; i++)
            {
                sumOfMultipliesCurrentXOnNextY += vertices[i].X * vertices[i + 1].Y;
                sumOfMultipliesCurrentXOnPrevY += vertices[i].X * vertices[i - 1].Y;
            }
            sumOfMultipliesCurrentXOnPrevY += vertices[i].X * vertices[i - 1].Y;

            return Math.Abs((sumOfMultipliesCurrentXOnNextY - sumOfMultipliesCurrentXOnPrevY) / 2);
        }

        public virtual float CalculatePerimeter() => sides.Aggregate(0f,
                (sum, side) => sum + side.Length());

        public string GetInformationString()
        {
            var validated = Validate();

            var typeString = $"Type: {GetType()}";
            var validationString = $"Validated Success: {validated.ToString().ToUpper()}";

            IEnumerable<string> sidesStrings = [];
            var perimeterString = string.Empty;
            var areaString = string.Empty;

            if (validated)
            {
                sidesStrings = sides.Select((side, index)
                   => $"Side {index + 1}: ({side.X}, {side.Y})");
                perimeterString = $"Perimeter: {CalculatePerimeter()}";
                areaString = $"Area: {CalculateArea()}";
            }

            return string.Join('\n',

                sidesStrings
                .Append(typeString)
                .Append(validationString)
                .Append(perimeterString)
                .Append(areaString));
        }

        public virtual bool Validate()
        {
            if (sides.Count > 2)//Минимум три стороны
                if (Vector2Utilities.IsZero(Vector2Utilities.SumOfVectors(sides)))//Завершённый(не линия)
                    if (sides.Any(v => !Vector2Utilities.IsZero(v)
                        && sides.Where(v2 => v2 != v)
                            .Any(v2 => !Vector2Utilities.IsZero(v2))))//Минимум две различной стороны имеют длину
                        return true;
            return false;
        }

        /// <summary>
        /// Создаёт многоугольник на основе имеющихся сторон (достраивает одну сторону, если они не замкнуты)
        /// </summary>
        /// <param name="sides">Последовательный набор сторон в формате векторов</param>
        public Polygon(IEnumerable<Vector2> sides) => this.sides = Vector2Utilities.SureCycled(sides).ToList();

        /// <summary>
        /// Создаёт многоугольник на основе имеющегося многоугольника
        /// </summary>
        /// <param name="example">Многоугольник-образец</param>
        public Polygon(Polygon example) => sides = [.. example.sides];

        /// <summary>
        /// Рассчитывает набор сторон вершин многоугольника
        /// </summary>
        /// <param name="additionalCapacity">Количество дополнительно выделенных ячеек памяти</param>
        /// <returns>Новый текущий набор сторон вершин многоугольника</returns>
        protected IList<PointF> CalculateVertices(int additionalCapacity = 0)
        {
            List<PointF> vertices = new(sides.Count() + additionalCapacity);

            Vector2 position = Vector2.Zero;
            foreach (var side in sides)
            {
                position += side;
                vertices.Add(new PointF(position));
            }

            return vertices;
        }
    }
}
