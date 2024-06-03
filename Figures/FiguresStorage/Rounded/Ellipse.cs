namespace Figures.FiguresStorage.Rounded
{
    /// <summary>
    /// Представляет эллипс
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    public class Ellipse(float a, float b) : IEllipse
    {
        protected float a = a;

        protected float b = b;

        public float A => a;

        public float B => b;

        public float CalculateArea() => MathF.PI * a * b;

        public float CalculatePerimeter() => 2 * MathF.PI * MathF.Sqrt((MathF.Pow(a, 2) + MathF.Pow(b, 2)) / 2);

        public string GetInformationString()
        {
            var validated = Validate();

            var typeString = $"Type: {GetType()}";
            var validationString = $"Validated Success: {validated.ToString().ToUpper()}";

            string radiusAString = string.Empty;
            string radiusBString = string.Empty;
            var perimeterString = string.Empty;
            var areaString = string.Empty;

            if (validated)
            {
                radiusAString = $"A: {a}";
                radiusBString = $"B: {b}";
                perimeterString = $"Perimeter: {CalculatePerimeter()}";
                areaString = $"Area: {CalculateArea()}";
            }

            return string.Join('\n', typeString, validationString, radiusAString, radiusBString, perimeterString, areaString);
        }

        public bool Validate()
        {
            if (a > 0 && b > 0)
                return true;

            return false;
        }
    }
}
