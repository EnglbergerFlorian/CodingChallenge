using System.Collections.Generic;
using System;
namespace CodingChallengeEnglberger
{
    /*The DataHandler manages the Data and controlls the access to the Data by the user. For each new file a new DataHandler is used
     * 
     */
    class DataHandler
    {
        private IReader myReader;
        private string myDirectory;
        private IDataType myDataType;
        private List<string[]> data;
      
        public DataHandler(IReader reader, string directory)
        {
            myReader = reader;
            myDirectory = directory;
            data = myReader.ReadFile(myDirectory);
            if (data!=null)
            {
                CheckDataType();
                //Remove the header line
                data.RemoveAt(0);
            }
                       
        }
        //Find out which kind of data is used. If it is not known throw an exception
        private void CheckDataType()
        {
            try
            {
                if (data[0][0] == "Team")
                {
                    myDataType = new DataFootball();
                }
                else if (data[0][0] == "Day")
                {
                    myDataType = new DataWeather();
                }
                else
                {
                    throw new System.Exception();
                }
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("unknown file");
            }
        }
        //calls the function of the dataType to find the minimum difference
        public string getMinDiffKey()
        {
            try
            {
                return myDataType.CalcMinDiffKey(data);
            }
            catch (Exception)
            {
                return "Calculation not possible";
            }
        }
    }
}
