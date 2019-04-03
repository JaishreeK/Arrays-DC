using Arrays_DS;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Arrays_DS.Tests
{
    [TestClass()]
    public class ProgramTest
    {
        //[TestMethod()]
        //public void reverseArrayTest()
        //{
        //    Program.reverseArray(new int[] { 1, 4, 3, 2 });
        //    //Assert.Fail();
        //}

        //[TestMethod()]
        //public void hourGlassSumTest()
        //{
        //    int[,] Input = new int[6, 6] {{1, 1, 1, 0, 0, 0}
        //                                ,{0, 1, 0, 0, 0, 0}
        //                                ,{1, 1, 1, 0, 0, 0}
        //                                ,{0, 0, 2, 4, 4, 0}
        //                                ,{0, 0, 0, 2, 0, 0}
        //                                ,{0, 0, 1, 2, 4, 0}};
        //    int max = Program.hourglassSum(Input);
        //    Assert.AreEqual(max, 19);
        //}

        [TestMethod()]
        public void rotLeftTest()
        { //        5 4
          //1 2 3 4 5
          //sample output:5 1 2 3 4
            var trans = Program.rotLeft(new int[] { 1, 2, 3, 4, 5 }, 4);
            Assert.AreEqual(trans, new int[] { 5, 1, 2, 3, 4 });
        }

        //[TestMethod()]
        //public void rotLeftTest()
        //{ //        5 4
        //  //1 2 3 4 5
        //  //sample output:5 1 2 3 4
        //    var trans = Program.rotLeft(new int[] { 33,47, 70, 37, 8,53, 13, 93, 71, 72, 51, 100, 60, 87, 97 },13);
        //   // Assert.AreEqual(trans, new int[] { 5, 1, 2, 3, 4 });
        //}
    }
}


