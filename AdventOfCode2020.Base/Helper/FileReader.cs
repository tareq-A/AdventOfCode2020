using AdventOfCode2020.Base.Interface;
using AdventOfCode2020.Base.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020.Base.Helper
{

    public class FileReader : IFileReader
    {
        Logger logger = new Logger();

        public string FILENAME { get; set; }

        //Default Constructer to get file name and push to FILENAME FIld
        public FileReader(string filename)
        {
            FILENAME = filename;
        }

        /// <summary>
        /// funcations read the Input from File and convert lines to list<int>
        /// </summary>
        /// <returns>Well returns ListInt </returns>
        public List<int> ReadNumbers()
        {
            var numbers = new List<int>();
            try
            {
                using (var sr = new StreamReader(FILENAME + ".txt"))
                {
                    string line;
                    do
                    {
                        line = sr.ReadLine();
                        if (string.IsNullOrEmpty(line)) continue;

                        int.TryParse(line, out var number);
                        numbers.Add(number);
                        numbers.Add(number);
                    } while (!string.IsNullOrEmpty(line));
                }
                return numbers;
            }
            catch (Exception ex)
            {
                logger.WriteLogByType(Logger.LogType.ERROR,$" {ex.Message} {ex.InnerException} {ex.StackTrace}");
            }
            finally { }
                return  numbers;
        }

        /// <summary>
        /// funcations to read the Input from File and Add the lines to list<String>
        /// </summary>
        /// <returns>Well returns ListString</returns>
        public List<string> ReadString()
        {
            var Text = new List<string>();
            try
            {
                using (var sr = new StreamReader(FILENAME + ".txt"))
                {
                    string line;
                    do
                    {
                        line = sr.ReadLine();
                        if (string.IsNullOrEmpty(line)) continue;
                        Text.Add(line);
                    } while (!string.IsNullOrEmpty(line));
                    return Text;
                }
            }
            catch (Exception ex)
            {
                logger.WriteLogByType(Logger.LogType.ERROR, ex.Message);
            }
            finally { }
            return Text;
        }

    }
}
