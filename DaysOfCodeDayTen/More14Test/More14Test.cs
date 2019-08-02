using Microsoft.VisualStudio.TestTools.UnitTesting;
using DaysOfCodeDayTen;

namespace More14Test
{
    [TestClass]
    public class More14Test
    {
        Exercises exercises = new Exercises();

        [TestMethod]
        public void more14()
        {
            Assert.AreEqual(true, exercises.More14(new int[] { 1, 4, 1 }));
            Assert.AreEqual(false, exercises.More14(new int[] { 1, 4, 1, 4 }));
            Assert.AreEqual(true, exercises.More14(new int[] { 1, 1 }));

            Assert.AreEqual(true, exercises.More14(new int[] { 1, 6, 6 }));
            Assert.AreEqual(true, exercises.More14(new int[] { 1 }));
            Assert.AreEqual(false, exercises.More14(new int[] { 1, 4 }));
            Assert.AreEqual(true, exercises.More14(new int[] { 6, 1, 1 }));
            Assert.AreEqual(false, exercises.More14(new int[] { 1, 6, 4 }));
            Assert.AreEqual(true, exercises.More14(new int[] { 1, 1, 4, 4, 1 }));
            Assert.AreEqual(true, exercises.More14(new int[] { 1, 1, 6, 4, 4, 1 }));
            Assert.AreEqual(false, exercises.More14(new int[] { }));
            Assert.AreEqual(false, exercises.More14(new int[] { 4, 1, 4, 6 }));
            Assert.AreEqual(false, exercises.More14(new int[] { 4, 1, 4, 6, 1 }));
            Assert.AreEqual(true, exercises.More14(new int[] { 1, 4, 1, 4, 1, 6 }));



        }
    }
}