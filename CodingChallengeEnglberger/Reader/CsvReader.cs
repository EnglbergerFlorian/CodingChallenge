using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CodingChallengeEnglberger
{
    //Reads CSV Files
    // Implements IReader so that the Programm can be easily extended to other file-formats
    public class CsvReader:IReader
    {
        List<string[]> IReader.ReadFile(string directory)
        {
            List<string[]> data = new List<string[]>();
            try
            {
                data = File.ReadAllLines(directory)
                //.Skip(1)
                .Select(v => v.Split(','))
                .ToList();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
                return null;
            }
            catch (Exception)
            {
                Console.WriteLine("ErrorReadingCSVFile");
                return null;
            }

            return data;
        }

        
    }
}

