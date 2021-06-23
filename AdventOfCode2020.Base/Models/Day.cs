using AdventOfCode2020.Base.Helper;
using AdventOfCode2020.Base.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2020.Base.Models
{
    public class Day : IDay
    {
        #region Private Member
        /// <summary>
        /// declare List of int this well hold the data when we push the arg to Constractor
        /// </summary>
        private List<int> _Datanumber;
        /// <summary>
        /// declare List of string this well hold the data when we push the arg to Constractor
        /// </summary>
        private List<string> _DataString;
        #endregion

        #region Public Member
        //DataNumber Box&unBoxing To read data from Prviate properties to the inherited class
        public List<int> Datanumber { get => _Datanumber; set => _Datanumber=value; }
        //DataNumber Box&unBoxing To read data from Prviate properties to the inherited class
        public List<string> DataString { get => _DataString; set => _DataString=value; }

        //declare Soluations1 as virtual Method return string for override it in the inherited class 
        public virtual string Soluation1()
        {
            return string.Empty;
        }
        //declare Soluations2 as virtual Method return string for override it in the inherited class 
        public virtual string Soluation2()
        {
            return string.Empty;
        }
        #endregion

        #region Constractor
        /// <summary>
        /// Constractor to initlazie this Class with fill up data private member 
        /// </summary>
        /// <param name="DayName">using to select the Day and push it to File reader to Read the data</param>
        public Day(string DayName)
        {
             FileReader Reader = new FileReader(DayName);
            _Datanumber = Reader.ReadNumbers();
            _DataString = Reader.ReadString();
            Console.WriteLine($"Soluations To the Day: {DayName}");
        }
        /// <summary>
        /// Default Constractor for inhirit
        /// </summary>
        public Day()
        {
            
        }
        #endregion
    }
}
