using AdventOfCode2020.Base.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AdventOfCode2020.Base.Helper
{
    public class FileReader : IFileReader
    {
        /// <summary>
        /// funcations to read the Input File and convert lines to list<int>
        /// </summary>
        /// <param name="filename">the file where input data in </param>
        /// <returns>Well returns ListInt </returns>
        public List<int> ReadNumbers(string filename)
        {
            var numbers = new List<int>();

            using (var sr = new StreamReader(filename))
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

                return numbers;
            }
        }

        /// <summary>
        /// funcations to read the Input File and Add the lines to list<String>
        /// </summary>
        /// <param name="filename">the file where input data in </param>
        /// <returns>Well returns ListString</returns>
        public List<string> ReadString(string filename)
        {
            var Text = new List<string>();

            using (var sr = new StreamReader(filename))
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
    }
}
