using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;


namespace UnitTestCodingChallenge
{
    [TestClass]
    public class CalcMinDiffKeyFootballTest
    {
        [TestMethod]
        public void CalcMinDiffKeyFootballUnitTest()
        {
            List<string[]> data = new List<string[]>();
            string[] line = { "a","x","x","x","x", "10", "2" };
            string[] line2 = { "b", "x", "x", "x", "x", "10", "5" };
            data.Add(line);
            data.Add(line2);
            CodingChallengeEnglberger.IDataType footballData = new CodingChallengeEnglberger.DataFootball();
            string Key = footballData.CalcMinDiffKey(data);
            Assert.IsTrue(Key == "b");
        }
    }
}
