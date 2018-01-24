using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;


namespace UnitTestCodingChallenge
{
    [TestClass]
    public class CalcMinDiffKeyWeatherTest
    {
        [TestMethod]
        public void CalcMinDiffKeyWeatherUnitTest()
        {
            List<string[]> data = new List<string[]>();
            string[] line = { "a", "10", "2" };
            string[] line2 = { "b", "10", "5" };
            data.Add(line);
            data.Add(line2);
            CodingChallengeEnglberger.IDataType weatherData = new CodingChallengeEnglberger.DataWeather();
            string Key=weatherData.CalcMinDiffKey(data);
            Assert.IsTrue(Key == "b");
        }
    }
}
