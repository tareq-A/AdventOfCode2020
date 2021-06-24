
using AdventOfCode2020.Base.Helper;
using AdventOfCode2020.Base.Models;
using Day1;
using Day2;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Testing
{
    public class Program
    {
        private static readonly string Part = "1-Slouations Part1\n2-Soluations 2";
        private static string input = "";

        public static async Task Main(string[] args)
        {
            if (args is null) throw new Exception();

            Console.WriteLine("\n--------Advent Of Code2020-------\n");
            Console.WriteLine("Get Soluation by : 'Enter Day Number' ");

            await ChoiceYourDay();
            Console.ReadKey();
        }

        /// <summary>
        /// Async Task ton read user input and push to switch case t select wich day user have selected 
        /// and display a Result in commadline
        /// </summary>
        /// <returns></returns>
        public async static Task ChoiceYourDay()
        {
            await Task.Run(async() => {
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine(Part);
                        input = Console.ReadLine();
                        if (input == "1") await FirstDay.Soluation1();
                        else if (input == "2") await FirstDay.Soluation2();
                        break;
                    case "2":
                        Console.WriteLine(Part);
                        input = Console.ReadLine();
                        if (input == "1") await SecondDay.Soluation1();
                        else if (input == "2") await SecondDay.Soluation2();
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "6":
                        break;
                    default:
                        Console.WriteLine("No result for selected day");
                        break;
                }
            });
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Get Soluation by : 'Enter Day Number' ");
            await ChoiceYourDay();
        }
    }
}
