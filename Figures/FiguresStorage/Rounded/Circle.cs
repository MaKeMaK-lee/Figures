namespace Figures.FiguresStorage.Rounded
{
    /// <summary>
    /// Представляет круг
    /// </summary>
    internal class Circle(float radius) : ICircle
    {
        protected float r = radius;

        public float R => r;

        public float CalculateArea() => MathF.PI * MathF.Pow(r, 2);

        public float CalculatePerimeter() => 2 * MathF.PI * r;

        public string GetInformationString()
        {
            var validated = Validate();

            var typeString = $"Type: {GetType()}";
            var validationString = $"Validated Success: {validated.ToString().ToUpper()}";

            string radiusString = string.Empty;
            var perimeterString = string.Empty;
            var areaString = string.Empty;

            if (validated)
            {
                radiusString = $"R: {r}";
                perimeterString = $"Perimeter: {CalculatePerimeter()}";
                areaString = $"Area: {CalculateArea()}";
            }

            return string.Join('\n', typeString, validationString, radiusString, perimeterString, areaString);
        }

        public bool Validate()
        {
            if (r > 0)
                return true;

            return false;
        }
    }
}
