using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2020.Base.Models
{
    /// <summary>
    /// Model using in First Question 
    /// </summary>
    public class Password
    {
        ///<summary>Password Prop to hold Password from string efter we spliting string</summary>
        public string Pass { get; }

        ///<summary>Key Prop to hold char from string efter we spliting string</summary>
        public char Key { get; }

        ///<summary>Min Prop to hold Minimn replace the key from string efter we spliting string</summary>
        public int Min { get; }

        ///<summary>Max Prop to hold Maximin replace the key from string efter we spliting string</summary>
        public int Max { get; }

        /// <summary>
        /// Default Constractor 
        /// <param name="pass">Initializa Password Datatype string efter spiling in Helper Class</param>
        /// <param name="key">Initializa key Datatype char  efter spiling in Helper Class</param>
        /// <param name="min">Initializa min Datatype int efter spiling in Helper Class</param>
        /// <param name="max">Initializa max Datatype int  efter spiling in Helper Class</param>
        /// /// </summary>
        public Password(string pass, char key, int min, int max)
        {
            Pass = pass;
            Key = key;
            Min = min;
            Max = max;
        }
    }
}
