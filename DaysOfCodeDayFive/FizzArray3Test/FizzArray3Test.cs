using DaysOfCodeDayFive;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzArray3Test
{
    [TestClass()]
    public class ExercisesTests
    {
        Exercises exercises = new Exercises();

        [TestMethod]
        public void fizzArray3()
        {
            CollectionAssert.AreEqual(new int[] { 5, 6, 7, 8, 9 }, exercises.FizzArray3(5, 10), "fizzArray3(5, 10)");
            CollectionAssert.AreEqual(new int[] { 11, 12, 13, 14, 15, 16, 17 }, exercises.FizzArray3(11, 18), "fizzArray3(11, 18)");
            CollectionAssert.AreEqual(new int[] { 1, 2 }, exercises.FizzArray3(1, 3), "fizzArray3(1, 3)");
            CollectionAssert.AreEqual(new int[] { }, exercises.FizzArray3(3, 3), "fizzArray3(3, 3)");

        }
    }
}