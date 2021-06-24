using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020.Base.Interface
{

    /// <summary>
    /// InterFace for FileReader where the class reading the data from file
    /// have to Tasks to read the Data as String and read as Int
    /// </summary>
    public interface IFileReader
    {
        ///Filed To proccess File Path 
        public string FILENAME { get; }

        ///Funcation to read data and convert to list int
        Task<List<int>> ReadNumbers();

        /// <summary>
        /// <!--Funcation to read data and Add to list<String>-->
        /// </summary>
        /// <returns></returns>
        Task<List<string>> ReadString();


    }
}
