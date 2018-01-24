using System;
using System.IO;

/**
 * The entry class for your solution. This class is only aimed as starting point and not intended as baseline for your software
 * design. Read: create your own classes and packages as appropriate.
 *
 * @author Benjamin Schmid <benjamin.schmid@exxcellent.de>
 */

namespace CodingChallengeEnglberger
{
    class Program
    {
        static void Main(string[] args)
        {
            // Your preparation code …
            var projectFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            var directoryWeather = Path.Combine(projectFolder, "Files\\weather.csv");
            var directoryFootball = Path.Combine(projectFolder, "Files\\football.csv");

            //Defining which kind of file is used
            IReader reader = new CsvReader();
                     
            //The datahandler starts the chosen IReader and finds out which DataType is in the file. 
            //Also the datahandler does not allow acces to the data by the user. It's only possible to call it's functions to interpret the data.
            DataHandler weatherDataHandler = new DataHandler(reader, directoryWeather);
            string dayWithSmallestTempSpread=weatherDataHandler.getMinDiffKey();
            
            DataHandler footballDataHandler = new DataHandler(reader, directoryFootball);
            string teamWithSmallesGoalSpread = footballDataHandler.getMinDiffKey();


            Console.WriteLine("Day with smallest temperature spread : {0}", dayWithSmallestTempSpread);
            Console.WriteLine("Team with smallest goal spread       : {0}", teamWithSmallesGoalSpread);
            Console.ReadKey();
        }
    }
}
