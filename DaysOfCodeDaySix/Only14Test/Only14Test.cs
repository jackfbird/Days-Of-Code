using DaysOfCodeDaySix;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Only14Test
{
    [TestClass()]
    public class ExercisesTests
    {
        Exercises exercises = new Exercises();

        [TestMethod]
        public void only14()
        {
            Assert.AreEqual(true, exercises.Only14(new int[] { 1, 4, 1, 4 }));
            Assert.AreEqual(false, exercises.Only14(new int[] { 1, 4, 2, 4 }));
            Assert.AreEqual(true, exercises.Only14(new int[] { 1, 1 }));

            Assert.AreEqual(true, exercises.Only14(new int[] { 4, 1 }));
            Assert.AreEqual(false, exercises.Only14(new int[] { 2 }));
            Assert.AreEqual(true, exercises.Only14(new int[] { }));
            Assert.AreEqual(false, exercises.Only14(new int[] { 1, 4, 1, 3 }));
            Assert.AreEqual(false, exercises.Only14(new int[] { 3, 1, 3 }));
            Assert.AreEqual(true, exercises.Only14(new int[] { 1 }));
            Assert.AreEqual(true, exercises.Only14(new int[] { 4 }));
            Assert.AreEqual(false, exercises.Only14(new int[] { 3, 4 }));
            Assert.AreEqual(false, exercises.Only14(new int[] { 1, 3, 4 }));
            Assert.AreEqual(true, exercises.Only14(new int[] { 1, 1, 1 }));
            Assert.AreEqual(false, exercises.Only14(new int[] { 1, 1, 1, 5 }));
            Assert.AreEqual(true, exercises.Only14(new int[] { 4, 1, 4, 1 }));
        }
    }
}
