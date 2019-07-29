using DaysOfCodeDayFour;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Start1Test
{
    [TestClass()]
    public class ExercisesTests
    {
        Exercises exercises = new Exercises();

        [TestMethod]
        public void start1()
        {
            Assert.AreEqual(2, exercises.Start1(new int[] { 1, 2, 3 }, new int[] { 1, 3 }));
            Assert.AreEqual(1, exercises.Start1(new int[] { 7, 2, 3 }, new int[] { 1 }));
            Assert.AreEqual(1, exercises.Start1(new int[] { 1, 2 }, new int[] { }));

            Assert.AreEqual(1, exercises.Start1(new int[] { }, new int[] { 1, 2 }));
            Assert.AreEqual(0, exercises.Start1(new int[] { 7 }, new int[] { }));
            Assert.AreEqual(1, exercises.Start1(new int[] { 7 }, new int[] { 1 }));
            Assert.AreEqual(2, exercises.Start1(new int[] { 1 }, new int[] { 1 }));
            Assert.AreEqual(0, exercises.Start1(new int[] { 7 }, new int[] { 8 }));
            Assert.AreEqual(0, exercises.Start1(new int[] { }, new int[] { }));
            Assert.AreEqual(2, exercises.Start1(new int[] { 1, 3 }, new int[] { 1 }));
        }
    }
}