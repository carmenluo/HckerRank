using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WriteInBallots;
namespace UnitBallots
{
    [TestClass]
    public class WriteInBallotsTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<string> ballot = new List<string>();
            ballot.Add("John");
            ballot.Add("James");
            ballot.Add("Helen");
            ballot.Add("James");
            ballot.Add("Helen");
            ballot.Add("John");
            string expected = "John";
            string actual=Result.writeIn(ballot);

            Assert.AreEqual(expected, actual);
        }
    }
}
