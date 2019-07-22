using DaysOfCodeThree;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GreenTicketTest
{
    [TestClass()]
    public class ExercisesTests
    {
        Exercises exercises = new Exercises();

        [TestMethod]
        public void GreenTicketTest()
        {
            Assert.AreEqual(0, exercises.GreenTicket(1, 2, 3), "greenTicket(1, 2, 3)");
            Assert.AreEqual(20, exercises.GreenTicket(2, 2, 2), "greenTicket(2, 2, 2)");
            Assert.AreEqual(10, exercises.GreenTicket(1, 1, 2), "greenTicket(1, 1, 2)");
            Assert.AreEqual(10, exercises.GreenTicket(2, 1, 1), "greenTicket(2, 1, 1)");
            Assert.AreEqual(10, exercises.GreenTicket(1, 2, 1), "greenTicket(1, 2, 1)");
            Assert.AreEqual(0, exercises.GreenTicket(100, 200, 300), "greenTicket(100, 200, 300)");
        }
    }
}