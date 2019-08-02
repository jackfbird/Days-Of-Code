using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DaysOfCodeDayNine;

namespace PlusTwoTest
{
    [TestClass]
    public class PlusTwoTest
    {
        Exercises exercises = new Exercises();

        [TestMethod]
        public void plusTwo()
        {
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4 }, exercises.PlusTwo(new int[] { 1, 2 }, new int[] { 3, 4 }));
            CollectionAssert.AreEqual(new int[] { 4, 4, 2, 2 }, exercises.PlusTwo(new int[] { 4, 4 }, new int[] { 2, 2 }));
            CollectionAssert.AreEqual(new int[] { 9, 2, 3, 4 }, exercises.PlusTwo(new int[] { 9, 2 }, new int[] { 3, 4 }));
        }
    }
}
