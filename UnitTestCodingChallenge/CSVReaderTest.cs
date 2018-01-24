using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestCodingChallenge
{
    [TestClass]
    public class CSVReaderTest
    {
        [TestMethod]
        public void ReadCSVUnitTest()
        {
            CodingChallengeEnglberger.IReader reader= new CodingChallengeEnglberger.CsvReader();
            List<string[]> data=reader.ReadFile(@"C:\codingChallenge\weather.csv");
            int numRows = data.Count;
            int numCol = data[0].Length;
            Assert.IsTrue(numRows == 31);
            Assert.IsTrue(numCol == 14);
        }
    }
}
