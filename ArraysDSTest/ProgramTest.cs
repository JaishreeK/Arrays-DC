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

        //[TestMethod()]
        //public void rotLeftTest()
        //{ //        5 4
        //  //1 2 3 4 5
        //  //sample output:5 1 2 3 4
        //    var trans = Program.rotLeft(new int[] { 1, 2, 3, 4, 5 }, 4);
        //    Assert.AreEqual(trans, new int[] { 5, 1, 2, 3, 4 });
        //}

        //[TestMethod()]
        //public void minimumBribesTest()
        //{
        //    //Program.minimumBribes(new int[] { 2 ,1, 5, 3, 4 });
        //    Program.minimumBribes(new int[] { 1, 2, 5, 3, 7, 8, 6, 4 });

        //}

        //[TestMethod()]
        //public void arrayManipulationTest()
        //{
        //    Program.arrayManipulation(10, new int[3, 3] { { 1, 5, 3 }, { 4, 8, 7 }, { 6, 9, 1 } });

        //}

        //        6 4
        //give me one grand today night
        //give one grand today

        //[TestMethod()]
        //public void checkMagazineTest()
        //{
        //    Program.checkMagazine(new string[6] { "give", "me", "one", "grand", "today", "night" }, new string[4] { "give", "one", "grand", "today" });
        //}

        [TestMethod()]
        public void sherlockAndAnagramsTest()
        {            
            //Program.sherlockAndAnagrams("abba");
            int result = Program.sherlockAndAnagrams("cdcd");
            Assert.AreEqual(result, 5);
        }

        //[TestMethod()]
        //public void Check_AnagramTest()
        //{
        //    bool result = Program.Check_Anagram("ab", "ba");
        //    Assert.AreEqual(result, true);
        //}

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


