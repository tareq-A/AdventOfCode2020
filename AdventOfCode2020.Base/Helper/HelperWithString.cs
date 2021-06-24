using AdventOfCode2020.Base.Interface;
using AdventOfCode2020.Base.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020.Base.Helper
{
    /// <summary>
    /// I Helper Class 
    /// </summary>
    public class HelperWithString : IHelper
    {
        /// <summary>
        /// uing this Method with Day1 to defind all param from string 
        /// </summary>
        /// <param name="input"> Input string From Ui</param>
        /// <returns> Password type  </returns>
        public Password GetPassFromString(string input)
        {
            //look like Input :  "1-3 a: abcd"
            string[] splitInput = input.Split();
            string[] bounds = splitInput[0].Split("-");
            return _ = new Password(splitInput[2], splitInput[1][0], Convert.ToInt32(bounds[0]), Convert.ToInt32(bounds[1]));
        }
    }
}
