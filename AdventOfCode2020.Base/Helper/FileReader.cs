using AdventOfCode2020.Base.Interface;
using AdventOfCode2020.Base.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020.Base.Helper
{
    /// <summary>
    /// FileReader Helping with read data from file and we can add services as reading from Api ,CSV,Xml as we need 
    /// 
    /// </summary>
    public class FileReader : IFileReader
    {
        ///Declare Logger to follow the app if has happen bugs we can catch it
        readonly Logger logger = new Logger();

        private static readonly string path = Directory.GetCurrentDirectory().Replace("\\bin\\Debug\\netcoreapp3.1", "")+ @"\Data\";

        ///FileName Prop to hold the day name as User send it to Constractor
        public string FILENAME { get; }

        ///Default Constructer to get file name and push to FILENAME FIld
        public FileReader(string filename)
        {
            FILENAME = filename;
        }

        /// <summary>
        /// <!--funcations read the Input from File and convert lines to list<int>-->
        /// </summary>
        /// <returns> Well returns ListInt </returns>
        public async  Task<List<int>> ReadNumbers()
        {
            var numbers = new List<int>();
            try
            {
               await Task.Run(()=>{
                   using var sr = new StreamReader($"{path}{FILENAME}.txt");
                   string line;
                   do
                   {
                       line = sr.ReadLine();
                       if (string.IsNullOrEmpty(line)) continue;

                       int.TryParse(line, out var number);
                       numbers.Add(number);
                       numbers.Add(number);
                   } while (!string.IsNullOrEmpty(line));
               });
                return numbers;
            }
            catch (Exception ex)
            {
               await logger.WriteLogByType(Logger.LogType.ERROR,$" {ex.Message} {ex.InnerException} {ex.StackTrace}");
            }
            finally { }
                return  numbers;
        }

        /// <summary>
        /// <!--funcations to read the Input from File and Add the lines to list<String>-->
        /// </summary>
        /// <returns>Well returns ListString</returns>
        public async Task<List<string>> ReadString()
        {
            var Text = new List<string>();
            try
            {
                await Task.Run(() =>
                {
                    using var sr = new StreamReader($"{path}{FILENAME}.txt");
                    string line;
                    do
                    {
                        line = sr.ReadLine();
                        if (string.IsNullOrEmpty(line)) continue;
                        Text.Add(line);
                    } while (!string.IsNullOrEmpty(line));
                });
                return Text;
            }
            catch (Exception ex)
            {
               await logger.WriteLogByType(Logger.LogType.ERROR, ex.Message);
            }
            finally { }
            return Text;
        }

    }
}
