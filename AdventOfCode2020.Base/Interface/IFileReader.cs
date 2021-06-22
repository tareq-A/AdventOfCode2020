using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2020.Base.Interface
{
    /// <summary>
    /// InterFace for FileReader where the class reading the data from file
    /// first Funcation to read data and convert to list<int>
    /// second Funcation to read data and Add to list<String>
    /// </summary>
    public interface IFileReader
    {
        public List<int> ReadNumbers(string filename);
        public List<string> ReadString(string filename);
    }
}
