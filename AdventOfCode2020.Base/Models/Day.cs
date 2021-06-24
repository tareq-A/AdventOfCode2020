using AdventOfCode2020.Base.Helper;
using AdventOfCode2020.Base.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020.Base.Models
{
    /// <summary>
    /// Day is Base Class And has Interface 
    /// </summary>
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
        ///DataNumber To read data from Prviate properties to the inherited class
        public List<int> Datanumber { get => _Datanumber; set => _Datanumber=value; }

        ///DataNumber To read data from Prviate properties to the inherited class
        public List<string> DataString { get => _DataString; set => _DataString=value; }

        FileReader Reader;
        ///declare Soluations1 as virtual Method return string for override it in the inherited class 
        public async Task<string> Soluation1()
        {
            await Task.Run(() => {

            });
            return " w";
        }

        ///declare Soluations2 as virtual Method return string for override it in the inherited class 
        public async Task<string> Soluation2()
        {
            await Task.Run(() => { 
            
            });
            return string.Empty;
        }

        /// <summary>
        /// Initialization AsyncTask Call in Constractor to init and fill all fild och prop  
        /// </summary>
        /// <returns></returns>
        public async Task Initialization(string DayName)
        {
            
            await Task.Run(async () =>
            {
                Reader = new FileReader(DayName);
                _Datanumber = await Reader.ReadNumbers();
                _DataString = await Reader.ReadString();
                
            });
        }
        #endregion

        #region Constractor
        /// <summary>
        /// Constractor to initlazie this Class with fill up data private member 
        /// </summary>
        /// <param name="DayName">using to select the Day and push it to File reader to Read the data</param>
        public Day(string DayName)
        {
            Task.WaitAll(Initialization(DayName));
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
