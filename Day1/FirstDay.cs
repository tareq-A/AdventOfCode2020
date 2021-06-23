using AdventOfCode2020.Base.Helper;
using AdventOfCode2020.Base.Interface;
using AdventOfCode2020.Base.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Day1
{
    //Inhirit From Class Day 
    public class FirstDay : Day
    {
        //declare New constractor to the Day with pushing the para to Selet wich Data Day we need to read
        static Day NewDay=new Day("Day1");
        /// <summary>
        /// declare List of int this well hold the data that coming from  Class Propety in baseClass
        /// </summary>
        public new List<int> Datanumber =NewDay.Datanumber;

        /// <summary>
        /// declare List of string this well hold the data that coming from  Class Propety in baseClass
        /// </summary>
        public new List<string> DataString = NewDay.DataString;

        // init Varibel for usig on loop Time
        int Num1 = 0, Num2 = 0, Num3 = 0;

        /// <summary>
        /// Soluations for find 2 numbers =2020 i using 2 for loop one start from 0 another one start from 1 using override to the base method
        /// with If Statment for check if The number ==2020
        /// </summary>
        /// <returns> string type if </returns>
        #region Soluation1
        public override string Soluation1()
        {
            for (int i = 0; i < Datanumber.Count; i++)
            {
                for (int T = i + 1; T < Datanumber.Count; T++)
                {
                    if (Datanumber[i] + Datanumber[T] == 2020)
                    {
                        Num1 = Datanumber[i];
                        Num2 = Datanumber[T];
                    }
                }
            }
            return $"First Number: {Num1} +Second Number: {Num2} = {Num1+Num2}";
        }
        #endregion

        /// <summary>
        /// Soluations for find 3 numbers =2020 i using 3 for loop one start from 0 another one start from 1 last one from 0 using override to the base method
        /// with If Statment for check if The numbers == 2020
        /// </summary>
        /// <returns></returns>
        #region Soluation2
        public override string Soluation2()
        {
            for (int i = 0; i < Datanumber.Count; i++)
            {
                for (int T = i + 1; T < Datanumber.Count; T++)
                {
                    for (int x = 0; x < Datanumber.Count; x++)
                    {
                        if (Datanumber[i] + Datanumber[T] + Datanumber[x] == 2020)
                        {
                            Num1 = Datanumber[i];
                            Num2 = Datanumber[T];
                            Num3 = Datanumber[x];
                        }
                    }
                }
            }
            //Display the numbers with summation && and 
            return $"First Number: {Num1} + Second Number: {Num2} + thirrd Number: {Num3} = {Num1 + Num2 + Num3} \nmultiplication :{Num1*Num2*Num3}";
        }
        #endregion
    }
}
