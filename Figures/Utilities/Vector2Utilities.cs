
using System.Numerics;

namespace Figures.Utilities
{
    public static class Vector2Utilities
    {
        /// <summary>
        /// Суммирует все вектора последовательности.
        /// </summary>
        /// <param name="vectors">Последовательность векторов для суммирования</param>
        /// <returns>Вектор-сумма всех векторов в полученной последовательности</returns>
        public static Vector2 SumOfVectors(IEnumerable<Vector2> vectors) => vectors.Aggregate(Vector2.Zero,
               (sum, vector) => sum + vector);

        /// <summary>
        /// Обеспечивает замкнутость последовательности векторов (так, чтобы сумма всех векторов в ней была равна нулю).
        /// </summary>
        /// <param name="vectors">Последовательность векторов для замыкания</param>
        /// <returns>Новая замкнутая (или, если замыкание не требовалось, старая не изменённая) последовательность векторов</returns>
        public static IEnumerable<Vector2> SureCycled(IEnumerable<Vector2> vectors)
        {
            var newLastSide = -SumOfVectors(vectors);
            if (newLastSide != Vector2.Zero)
                vectors = vectors.Append(newLastSide);
            return vectors;
        }

        /// <summary>
        /// AngleBetween - the angle between 2 vectors
        /// </summary>
        /// <returns>
        /// Returns the the angle in degrees between vector1 and vector2
        /// </returns>
        /// <param name="vector1"> The first Vector </param>
        /// <param name="vector2"> The second Vector </param>
        public static double AngleBetween(Vector2 vector1, Vector2 vector2)
        {
            double sin = vector1.X * vector2.Y - vector2.X * vector1.Y;
            double cos = vector1.X * vector2.X + vector1.Y * vector2.Y;

            return Math.Atan2(sin, cos) * (180 / Math.PI);
        }

        /// <summary>
        /// CrossProduct - Returns the cross product: vector1.X*vector2.Y - vector1.Y*vector2.X
        /// </summary>
        /// <returns>
        /// Returns the cross product: vector1.X*vector2.Y - vector1.Y*vector2.X
        /// </returns>
        /// <param name="vector1"> The first Vector </param>
        /// <param name="vector2"> The second Vector </param>
        public static float CrossProduct(Vector2 vector1, Vector2 vector2)
        {
            return vector1.X * vector2.Y - vector1.Y * vector2.X;
        }

        /// <summary>
        /// Определяет, равен ли вектор нулевому вектору
        /// </summary>
        /// <param name="vector">Вектор для определения</param>
        /// <returns>True если вектор равен нулю, иначе false</returns>
        public static bool IsZero(Vector2 vector)
        {
            return vector == Vector2.Zero;

            //float eps = 0.00000001f;

            //if (vector.X < eps && vector.Y < eps)
            //    return true;

            //return false;
        }

    }
}
