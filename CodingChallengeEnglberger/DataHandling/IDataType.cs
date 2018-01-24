using System.Collections.Generic;

namespace CodingChallengeEnglberger
{
    /*The IDataType interface is used to assure that to every Type of File the important functions are implemented,
     * so that the DataHandler can call the functions without having to know the structure of the file
     */
    public interface IDataType
    {
        string CalcMinDiffKey(List<string[]> data);
    }
}
