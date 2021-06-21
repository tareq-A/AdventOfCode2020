using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Day4
{
    class FouthDay
    {
        static void Main(string[] args)
        {

            string InputFilePath = Directory.GetCurrentDirectory() + @"\PuzzleInput.txt";

            string FromFile = File.ReadAllText(InputFilePath);
            var Passport = FromFile.Replace("\r", "").Replace("\n\n", "@").Split(new char[] { '@' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, bool> Allfiled = new Dictionary<string, bool> {
                { "byr" ,true}, {"iyr", true }, {"eyr", true }, {"hgt",true},
                                {"hcl",true}, {"ecl",true}, {"pid",true} };

            int FildCount = Allfiled.Count(x => x.Value);

            //*       Part 1          */
            int Valid = 0;
            foreach (string pass in Passport)
            {
                string[] delData = pass.Split(new char[] { '\n', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var Fileds = delData.Select(T => T.Split(':')).Select(T => new { key = T[0], Value = T[1] }).ToList();
                int Requerid = 0;
                int Optionel = 0;
                foreach (var filed in Fileds)
                {
                    if (Allfiled.TryGetValue(filed.key, out bool requird))
                    {
                        if (requird) ++Requerid;
                        else ++Optionel;
                    }
                }
                if (Requerid == FildCount) ++Valid;
            }
            Console.WriteLine($"Vaild : {Valid}");
            Console.ReadKey();

        }
    }
}
