
using AdventOfCode2020.Base.Helper;
using AdventOfCode2020.Base.Models;
using Day1;
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
      
        static void Main(string[] args)
        {
            Logger logger = new Logger();
            try
            {
                FirstDay first = new FirstDay();
                Console.WriteLine($"{first.Soluation1()}\n{first.Soluation2()}");
            }
            catch (Exception ex)
            {
                logger.WriteLogByType(Logger.LogType.TRACE, $"{ex.StackTrace} {ex.InnerException} {ex.Message}");
            }
          
            Console.ReadKey();
        }
       
    }
}
