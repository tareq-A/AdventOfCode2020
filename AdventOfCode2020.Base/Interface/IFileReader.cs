using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020.Base.Interface
{

    /// <summary>
    /// InterFace for FileReader where the class reading the data from file
    /// </summary>
    public interface IFileReader
    {
        //Filed To proccess File Path 
        public string FILENAME { get; set; }

        //Funcation to read data and convert to list<int>
        public List<int> ReadNumbers();

        // Funcation to read data and Add to list<String>
        public List<string> ReadString();


    }
}
