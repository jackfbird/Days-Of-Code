using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DaysOfCodeDayEIght;

namespace No23Test
{
    [TestClass]
    public class No23Test
    {
        Exercises exercises = new Exercises();

        [TestMethod]
        public void no23()
        {
            Assert.AreEqual(true, exercises.No23(new int[] { 4, 5 }));
            Assert.AreEqual(false, exercises.No23(new int[] { 4, 2 }));
            Assert.AreEqual(false, exercises.No23(new int[] { 3, 5 }));

            Assert.AreEqual(true, exercises.No23(new int[] { 1, 9 }));
            Assert.AreEqual(false, exercises.No23(new int[] { 2, 9 }));
            Assert.AreEqual(false, exercises.No23(new int[] { 1, 3 }));
            Assert.AreEqual(true, exercises.No23(new int[] { 1, 1 }));
            Assert.AreEqual(false, exercises.No23(new int[] { 2, 2 }));
            Assert.AreEqual(false, exercises.No23(new int[] { 3, 3 }));
            Assert.AreEqual(true, exercises.No23(new int[] { 7, 8 }));
            Assert.AreEqual(true, exercises.No23(new int[] { 8, 7 }));


        }
    }
}
