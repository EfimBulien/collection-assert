namespace CollectionMath
{
    public class MathCollection
    {
        // Метод для нахождение корней через дискриминант
        public static double[] FindRoots(double a, double b, double c)
        {
            double discriminant = b * b - 4 * a * c;

            if (discriminant < 0)
            {
                // Нет корней
                return [];
            }
            else if (discriminant == 0)
            {
                // Один корень
                double root = -b / (2 * a);
                return [root];
            }
            else
            {
                // Два корня
                double sqrtDiscriminant = Math.Sqrt(discriminant);
                double root1 = (-b + sqrtDiscriminant) / (2 * a);
                double root2 = (-b - sqrtDiscriminant) / (2 * a);
                return [root1, root2];
            }
        }

        // Метод для вычисления процента от числа
        public static double CalculatePercentage(double number, double percentage)
        {
            return number * (percentage / 100);
        }
    }
}
