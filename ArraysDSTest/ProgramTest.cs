using Arrays_DS;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Arrays_DS.Tests
{
    [TestClass()]
    public class ProgramTest
    {
        [TestMethod()]
        public void reverseArrayTest()
        {
            Program.reverseArray(new int[] { 1, 4, 3, 2 });
            //Assert.Fail();
        }
    }
}


