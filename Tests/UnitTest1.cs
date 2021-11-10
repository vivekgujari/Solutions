using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        [TestCase(new int[] { 2, 5, 9, 3, 1, 6, 4, 7 })]
        public static void QuickSort_Test(int[] array)
        {
            Solutions.QuickSort.sort(array);
            Assert.That(array, Is.EqualTo(new int[] { 1, 2, 3, 4, 5, 6, 7, 9 }));
        }
    }
}