using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingChallengeEnglberger
{
    //This is an implementation of the IDataType Interface. 
    //for calculating the minimum Differnce, a more complex but easier to extend code is written
    public class DataWeather:IDataType
    {
        //Dictionary with the name of the day as Key and the temperature spread as value
        private Dictionary<string, int> diffDic;

       
        string IDataType.CalcMinDiffKey(List<string[]> data)
        {
            //the name of the day with the minimum temperature spread
            string minDiffKey="No minimum differnce found";
            CreateDictionary(data);
            try
            {
                //find minimum and return the key
                minDiffKey = diffDic.Aggregate((l, r) => l.Value < r.Value ? l : r).Key;
            }
            catch (Exception)
            {
                Console.WriteLine("ErrorExcecutingWeatherData");
            }
            return minDiffKey;
        }
        //Function to create a Dictionary with the Name of the day as Key and the temperature spread as value
        private void CreateDictionary(List<string[]> data)
        {
            diffDic = new Dictionary<string, int>();
            foreach (string[] line in data)
            {
                int diff=0;
                try
                {
                    diff = Convert.ToInt32(line[1]) - Convert.ToInt32(line[2]);
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("The DataType does not fit to the File");
                    return;
                }
                diffDic.Add(line[0], diff);
            }
            
        }


    }
}
