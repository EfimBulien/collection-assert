using CollectionMath;

namespace CollectionMathTests
{
    [TestClass]
    public class MathCollectionTests
    {
        private static List<double[]> _testRootsCollection;

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            
            _testRootsCollection = [
                [1, -3, 2],  // D > 0
                [1, 2, 1],   // D = 0
                [1, 0, 1]    // D < 0
            ];
        }

        // Тест для случая D > 0 (два корня)
        [TestMethod]
        public void FindRoots_TwoRoots_DiscriminantGreaterThanZero()
        {
            int expected = 2;

            double a = _testRootsCollection[0][0];
            double b = _testRootsCollection[0][1];
            double c = _testRootsCollection[0][2];

            double[] actual = MathCollection.FindRoots(a, b, c);
            double expected1 = 2;
            double expected2 = 1;
            
            Assert.AreEqual(expected, actual.Length, $"Ожидается {expected} корня для a={a}, b={b}, c={c}");
            Assert.AreEqual(expected1, actual[0], 0.001, $"Ожидаемый корень 1 для a={a}, b={b}, c={c}: {expected1}");
            Assert.AreEqual(expected2, actual[1], 0.001, $"Ожидаемый корень 2 для a={a}, b={b}, c={c}: {expected2}");
        }

        // Тест для случая D = 0 (один корень)
        [TestMethod]
        public void FindRoots_OneRoot_DiscriminantEqualToZero()
        {
            int expected = 1;
            double expected1 = -1;

            double a = _testRootsCollection[1][0];
            double b = _testRootsCollection[1][1];
            double c = _testRootsCollection[1][2];

            double[] actual = MathCollection.FindRoots(a, b, c);
            
            Assert.AreEqual(expected, actual.Length, $"Ожидается {expected} корень для a={a}, b={b}, c={c}");
            Assert.AreEqual(expected1, actual[0], 0.001, $"Ожидаемый корень для a={a}, b={b}, c={c}: {expected1}");
        }

        // Тест для случая D < 0 (корней нет)
        [TestMethod]
        public void FindRoots_NoRoots_DiscriminantLessThanZero()
        {
            int expected = 0;

            double a = _testRootsCollection[2][0];
            double b = _testRootsCollection[2][1];
            double c = _testRootsCollection[2][2];

            double[] actual = MathCollection.FindRoots(a, b, c);
            
            Assert.AreEqual(expected, actual.Length, $"Ожидается отсутствие корней для a={a}, b={b}, c={c}");
        }

        // Тест для вычисления процента от числа с использованием дельты
        [TestMethod]
        public void CalculatePercentage_CorrectResultWithDelta()
        {
            double delta = 0.001;
            double number = 200;
            double percentage = 15.5;

            double expected = 31;
            double actual = MathCollection.CalculatePercentage(number, percentage);
            
            Assert.AreEqual(expected, actual, delta, $"Ожидаемый результат процента {percentage} для числа {number}: {expected}");
        }
    }
}