using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Day1
{
    class FirstDay
    {
        static void Main(string[] args)
        {
            string InputFilePath = Directory.GetCurrentDirectory() + @"\PuzzleInput.txt";
            var FromFile = File.ReadAllLines(InputFilePath).Select(T=>Int32.Parse(T)).ToList();

            int Num1 = 0, Num2 = 0, Num3 = 0;
            int Sum = 0;
            Part1(FromFile);
           
            Part2(FromFile);
            Console.WriteLine($"Part 2\n{Num1} + {Num2} + {Num3}= {Num1 + Num2+ Num3}\n" +
                                    $"{Num1} * {Num2} * {Num3} = {Num1 * Num2 * Num3}");

            Console.ReadKey();

            #region Solve1
            void Part1(List<int> Numbers)
            {
                for (int i = 0; i < Numbers.Count; i++)
                {
                    for (int T = i+1; T <Numbers.Count; T++)
                    {
                        if (Numbers[i] + Numbers[T] == 2020)
                        {
                            Num1 = Numbers[i];
                            Num2 = Numbers[T];
                            Sum = Num1 + Num2;
                        }
                    }
                }
            }
            #endregion

            #region Solve 2
            void Part2(List<int> Numbers)
            {
                for (int i = 0; i < Numbers.Count; i++)
                {
                    for (int T = i + 1; T < Numbers.Count; T++)
                    {
                        for (int x = 0; x < Numbers.Count; x++)
                        {
                            if (Numbers[i] + Numbers[T] + Numbers[x] == 2020)
                            {
                                Num1 = Numbers[i];
                                Num2 = Numbers[T];
                                Num3 = Numbers[x];
                                Sum = Num1 + Num2 +Num3;
                            }
                        }
                    }
                }
            }
            #endregion
        }
    }
}
