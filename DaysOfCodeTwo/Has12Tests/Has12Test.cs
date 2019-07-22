using Microsoft.VisualStudio.TestTools.UnitTesting;
using DaysOfCodeTwo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Has12Tests
{
    [TestClass()]
    public class ExercisesTests
    {
        Exercises exercises = new Exercises();

        [TestMethod]
        public void has12()
        {
            Assert.AreEqual(true, exercises.Has12(new int[] { 1, 3, 2 }), "has12(new int[]{1, 3, 2})");
            Assert.AreEqual(true, exercises.Has12(new int[] { 3, 1, 2 }), "has12(new int[]{3, 1, 2})");
            Assert.AreEqual(true, exercises.Has12(new int[] { 3, 1, 4, 5, 2 }), "has12(new int[]{3, 1, 4, 5, 2})");
            Assert.AreEqual(false, exercises.Has12(new int[] { 3, 2, 1 }), "has12(new int[]{3, 2, 1})");
            Assert.AreEqual(false, exercises.Has12(new int[] { 3, 1, 4 }), "has12(new int[]{3, 1, 4})");
            Assert.AreEqual(false, exercises.Has12(new int[] { 3, 5, 2 }), "has12(new int[]{3, 5, 2})");
            Assert.AreEqual(false, exercises.Has12(new int[] { 5, 5, 5 }), "has12(new int[]{5, 5, 5})");
            Assert.AreEqual(true, exercises.Has12(new int[] { 2, 1, 2 }), "has12(new int[]{2, 1, 2})");
        }
    }
}

