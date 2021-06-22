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
            Solv2();
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
            #region Solution 1
            void Solv2()
            {
                long Totle = 0;
                int xlen = _input.First().Length;
                int Tress = 0;
                HashSet<int> Slops = new HashSet<int> { 1,1 ,3,1,5, 1 , 7, 1 , 1, 2 };
                for (int R = 0; R < _input.Count; R++)
                {
                    if (R == xlen) {R = 0; }
                    Slops.TryGetValue(R, out int D);
                    if (_input[R][D] == '#') Tress++;
                }
                Console.WriteLine(Tress.ToString());
            }
            #endregion
        }
    }
}
