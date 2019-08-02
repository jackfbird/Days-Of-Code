using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DaysOfCodeDaySeven;

namespace DaysOfCodeDaySevenTest
{
    [TestClass()]
    public class ExercisesTests
    {
        Exercises exercises = new Exercises();

        [TestMethod]
        public void noTriples()
        {
            Assert.AreEqual(true, exercises.NoTriples(new int[] { 1, 1, 2, 2, 1 }));
            Assert.AreEqual(false, exercises.NoTriples(new int[] { 1, 1, 2, 2, 2, 1 }));
            Assert.AreEqual(false, exercises.NoTriples(new int[] { 1, 1, 1, 2, 2, 2, 1 }));
            Assert.AreEqual(true, exercises.NoTriples(new int[] { 1, 1, 2, 2, 1, 2, 1 }));
            Assert.AreEqual(true, exercises.NoTriples(new int[] { 1, 2, 1 }));
            Assert.AreEqual(false, exercises.NoTriples(new int[] { 1, 1, 1 }));
            Assert.AreEqual(true, exercises.NoTriples(new int[] { 1, 1 }));
            Assert.AreEqual(true, exercises.NoTriples(new int[] { 1 }));
            Assert.AreEqual(true, exercises.NoTriples(new int[] { }));
        }


    }
}
