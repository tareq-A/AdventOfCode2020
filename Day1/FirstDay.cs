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
    /// <summary>
    /// Inhirit From Class Day 
    /// </summary>
    public class FirstDay : Day, IDay
    {
        ///Decalar A instanc from class Day
        static readonly Day NewDay = new Day("Day1");
        ///Binde List int to the list int Class Day as we instanset
        public static new List<int> Datanumber = NewDay.Datanumber;
        ///Binde List string to the list int Class Day as we instanset
        public static new List<string> DataString = NewDay.DataString;

        ///three variables to using in loop time
        static int Num1 = 0, Num2 = 0, Num3 = 0;

        /// <summary>
        /// Default Constractor 
        /// </summary>
        public FirstDay()
        {

        }
        /// <summary>
        /// the Soluations two using 2 for loop to found the 2 numbers =2020 with if to check sum both numbers if =2020
        /// that many ways to using Linq,Hashset,Linklist..
        /// new keyword mean at we dont care what happen in Base class "implementions Igrone"
        /// using Task Async wait the result and dont block the app or another block
        /// </summary>
        /// <returns></returns>
        public new static async Task<string> Soluation1()
        {
            Console.WriteLine($"\nSoluations To the Day: {"Day1"}");
            Console.WriteLine("---------Part1--------\n");
            await Task.Run(() =>
            {
                Task.Delay(100);
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
                Console.WriteLine($"\n {Num1} + {Num2} = {Num1 + Num2}\n");
            });
            return $" {Num1} + {Num2} = {Num1 + Num2}";
        }
        /// <summary>
        /// the Soluations two using 3 for loop to found the 3 numbers =2020
        /// that many ways to using Linq,Hashset,Linklist..
        /// new keyword mean at we dont care what happen in Base class "implementions Igrone"
        /// using Task Async wait the result and dont block the app or another block
        /// </summary>
        /// <returns></returns>
        public new static async Task<string> Soluation2()
        {
            Console.WriteLine("\n---------Part2--------\n");
            await Task.Run(() =>
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
                Console.WriteLine($"\n {Num1} + {Num2} + {Num3} = {Num1 + Num2 + Num3} \n \nmultiplication : {Num1 * Num2 * Num3}\n");
            });
            return $" {Num1} + {Num2} + {Num3} = {Num1 + Num2 + Num3} \n \nmultiplication : {Num1 * Num2 * Num3}";
        }
    }
}
