using Microsoft.VisualStudio.TestTools.UnitTesting;
using DaysOfCodeDay0;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCodeDay0.Tests
{
    [TestClass()]
    public class ExercisesTests
    {
        Exercises exercises = new Exercises();

        [TestMethod]
        public void SwapEnds()
        {
            CollectionAssert.AreEqual(new int[] {}, exercises.SwapEnds(new int[] {}));
            CollectionAssert.AreEqual(new int[] { 3, 2, 1 }, exercises.SwapEnds(new int[] { 1, 2, 3 }));
            CollectionAssert.AreEqual(new int[] { 1 }, exercises.SwapEnds(new int[] { 1 }));
            CollectionAssert.AreEqual(new int[] { 2, 4, 6, 7 }, exercises.SwapEnds(new int[] { 7, 4, 6, 2 }));

            CollectionAssert.AreEqual(new int[] { 3, 2, 2, 2, 2, 2, 2, 1 }, exercises.SwapEnds(new int[] { 1, 2, 2, 2, 2, 2, 2, 3 }));
            CollectionAssert.AreEqual(new int[] { 4, 7 }, exercises.SwapEnds(new int[] { 7, 4 }));
            CollectionAssert.AreEqual(new int[] { 7, 7 }, exercises.SwapEnds(new int[] { 7, 7 }));
            CollectionAssert.AreEqual(new int[] { 9, 2, 5 }, exercises.SwapEnds(new int[] { 5, 2, 9 }));
            CollectionAssert.AreEqual(new int[] { 1, 3, 4, 2 }, exercises.SwapEnds(new int[] { 2, 3, 4, 1 }));

        }
    }
}