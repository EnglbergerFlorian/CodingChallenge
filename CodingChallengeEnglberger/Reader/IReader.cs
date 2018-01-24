using System.Collections.Generic;

namespace CodingChallengeEnglberger
{
    //IReader makes sure that every Reader has an Implementation of the ReadFile function
    //By extending the program to other filetypes only minimal changes to the rest of the code are necessary if this interface is used
    public interface IReader
    {
        List<string[]> ReadFile(string directory);
    }
}
