using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Day3
{
    class ThirdDays
    {
        static void Main(string[] args)
        {
            string InputFilePath = Directory.GetCurrentDirectory() + @"\PuzzleInput.txt";
            var _input = File.ReadLines(InputFilePath).Select(T => T.ToCharArray()).ToList();

            int CountTress = _input.Select(t => t.Equals('#')).Count();
             
            //----1-----
            Solv1();
            #region Solution 1
            void Solv1()
                    {
                        int xlen = _input.First().Length;
                        int ylen = _input.Count;
                        int t = 0;
                        int Tress = 0;

                        for (int i = 1; i < ylen; i++)
                        {
                            t = (t + 3) % xlen;

                            if (_input[i][t] == '#') Tress++;
                        }
                        Console.WriteLine(Tress.ToString());
                    }
            #endregion
        }
    }
}
