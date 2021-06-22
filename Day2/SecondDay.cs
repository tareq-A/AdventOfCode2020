using System;
using System.IO;

namespace Day2
{
    class SecondDay
    {
        static void Main(string[] args)
        {
            string InputFilePath = Directory.GetCurrentDirectory() + @"\PuzzleInput.txt";
            string[] FromFile = File.ReadAllLines(InputFilePath);
            int Passcounter = 0;
            int Min = 0, Max = 0;
            char key = ' ';
            string Password = " ";


            foreach (string line in FromFile)
            {
                GetValueFromString(line);

                /*  Part 1 */   //CheckIfVailadPart1(Min,Max,key,Password);
                /*  Part 2 */   CheckIfVailadPart2(Min,Max,key,Password);
            }

            void GetValueFromString(string input)
            {
                // Input :  "1-3 a: abcd"
                string[] splitInput = input.Split();
                string[] bounds = splitInput[0].Split("-");
                Password = splitInput[2];
                key = splitInput[1][0];
                Min = Convert.ToInt32(bounds[0]);
                Max = Convert.ToInt32(bounds[1]);
            }

            Console.WriteLine(Passcounter);

            #region Solve1
            void CheckIfVailadPart1(int min, int max, char CharToFind, string pass)
            {
                int counter = 0;
                bool Isvalid = false;
                foreach (char c in pass)
                {
                    if (c == CharToFind)
                    {
                        counter++;
                    }
                }
                if (counter <= max && counter >= min)
                {
                    Isvalid = true;
                    Console.WriteLine(pass + " \\ Status : " + Isvalid);
                    Passcounter++;
                }
            }
            #endregion

            #region Solve2
            void CheckIfVailadPart2(int min, int max, char CharToFind, string pass)
            {
                bool min1 = pass[min - 1] == CharToFind;
                bool max1 = pass[max - 1] == CharToFind;
                if (min1 ^ max1)
                {
                    Console.WriteLine($"{pass}\n{CharToFind}  {min}={pass[min - 1]} {max}={pass[max - 1]}");
                    Passcounter++;
                }
                

            }
            #endregion
            
            Console.ReadLine();
        }
    }
}
