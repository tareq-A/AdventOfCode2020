using AdventOfCode2020.Base.Interface;
using AdventOfCode2020.Base.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace Day2
{
    public class SecondDay : Day
    {
        #region 
        static Day NewDay = new Day("Day2");
        public new List<int> Datanumber = NewDay.Datanumber;
        public new List<string> DataString = NewDay.DataString;
        #endregion

        #region Private member
        //declare New Min replace Char And Max Replace
        private int Min = 0, Max = 0;
        //var well hold the char that we looking for
        private char key = ' ';
        //that sting we will serach efter the char in
        private string Password = " ";
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <returns> string type if </returns>
        #region Soluation1
        public override string Soluation1()
        {
            return $": {} : {} : {}";
        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        #region Soluation2
        public override string Soluation2()
        {
            //Display the numbers with summation && and 
            return $": {} : {} : {}  ";
        }
        #endregion
    }
}
