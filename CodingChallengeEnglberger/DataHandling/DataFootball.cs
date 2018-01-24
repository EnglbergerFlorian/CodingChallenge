using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingChallengeEnglberger
{
    //Implementation of the IDataType class
    //Here a straight forward solution to the problem is used.
    public class DataFootball : IDataType
    {
        string IDataType.CalcMinDiffKey(List<string[]> data)
        {
            string minDiffKey = "no minimum difference found";
            int minDiff=0;
            for (int i=0;i<data.Count();i++)
            {
                string[] line = data[i];
                int diff=0;
                try
                {
                    diff = Math.Abs(Convert.ToInt32(line[5]) - Convert.ToInt32(line[6]));
                }
                catch (IndexOutOfRangeException)
                {
                    System.Console.WriteLine("The DataType does not fit to the File");
                    return "Error Reading file";
                }

                if (minDiff < diff && i!=0) continue;
                minDiff = diff;
                minDiffKey = line[0];                
            }
            return minDiffKey;
        }
    }
}
