using AdventOfCode2020.Base;
using AdventOfCode2020.Base.Helper;
using AdventOfCode2020.Base.Interface;
using AdventOfCode2020.Base.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day2
{
    /// <summary>
    /// Soluation to the Day2 Questions Class SecondDay inhirit from class Day 
    /// </summary>
    public class SecondDay : Day
    {
        ///<summary>Decalar A instanc from class Day</summary>
        static readonly Day NewDay = new Day("Day2");

     

        ///<summary>Binde List string to the list int Class Day as we instanset</summary>
        private new static readonly List<string> DataString = NewDay.DataString;

        #region Private Member
        /// <summary>
        ///  Logger to using in our Class to display the Exception
        /// </summary>
        private static readonly Logger logger = new Logger();
        private static readonly HelperWithString helper=new HelperWithString();
        private static string Result = "";
        private static readonly List<Password> passwords = new List<Password>();
        private static int CounterSoluations1 = 0;
        private static int CounterSoluations2 = 0;

        #endregion
        /// <summary>
        /// Default Constractor
        /// </summary>
        
        static SecondDay()
        {
            _ = StartUp();
        }

        #region Soluations 
        ///<summary>Starting with pushing input string to helper for defind the keys what we need</summary>
        public static async Task StartUp()
        {
            await Task.Run(() => {
                foreach (var keys in DataString)
                {
                    passwords.Add(helper.GetPassFromString(keys));
                }
            });
            Console.WriteLine($"\n------------------Count----------------\n");
            Console.WriteLine($"\nSolution1 Password Count :{CounterSoluations1}\nSolution2 Password Count :{CounterSoluations2}");
            Console.WriteLine($"\n--------------Soluation End-------------\n");
        }

        /// <summary>
        /// Soluation 1 using Linq To figure the soluation
        /// </summary>
        /// <returns></returns>
        public static new async Task<string> Soluation1()
        {
            await Task.Run(() => {
                foreach (Password PasWord in passwords) 
                { 
                    try
                    {
                        var Amount = PasWord.Pass.Count(c => c == PasWord.Key);
                        if (Amount <= PasWord.Max && Amount >= PasWord.Min)
                        {
                            Result = $"\nPassword Vaild: {PasWord.Key} : {PasWord.Pass}   Min: {PasWord.Min}  Max: {PasWord.Max}";
                            CounterSoluations1++;
                            Console.WriteLine(Result);
                        }
                    }
                    catch (Exception ex)
                    {
                        _ = logger.WriteLogByType(Logger.LogType.WARNING, $"{ex.Message}\n {ex.StackTrace} \n{ex.InnerException}");
                    }
            
                }
            });
            return Result;
        }

        /// <summary>
        /// Soluation 2
        /// </summary>
        /// <returns></returns>
        public static new async Task<string> Soluation2()
        {
            await Task.Run(()=>
            {
                foreach (Password PasWord in passwords)
                {
                    try
                    {
                        var key = new[]
                        {
                        PasWord.Pass[PasWord.Min - 1],
                        PasWord.Pass[PasWord.Max - 1]
                        };
                        if (key.Count(K => K == PasWord.Key) == 1)
                        {
                            Result = $"\nPassword Vaild: {PasWord.Key} : {PasWord.Pass}   Min: {PasWord.Min}  Max: {PasWord.Max}";
                            CounterSoluations2++;
                            Console.WriteLine(Result);
                        }
                    }
                    catch (Exception ex)
                    {
                        _ = logger.WriteLogByType(Logger.LogType.WARNING, $"{ex.Message}\n {ex.StackTrace} \n{ex.InnerException}");
                    }
                }
            });
            return Result;
        }
        #endregion
    }
}
