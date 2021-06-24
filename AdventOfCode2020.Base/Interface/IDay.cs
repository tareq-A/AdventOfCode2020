using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020.Base.Interface
{
    /// <summary>
    /// Day interface have two lists as defernt input date String |and| int
    /// task Initialization to start up the class and inin all fild and load data to them
    /// Soluation1 and Soluation2 in them Tasks we will implementions the Soluations for Questions
    /// </summary>
    public interface IDay
    {   
        ///DataNumber Prop As List int to get and set date from Filereader Data as lsit of Interger
        public List<int> Datanumber { get; set; }
        ///DataString Prop As List of string to get and set date from FilereaderData as lsit of String
        public List<string> DataString { get; set; }

        ///using this Task to stand up the Class in The Constractor 
        Task Initialization(string DayName);

        ///using this Task to Defind Soluation 1 
        Task<string> Soluation1();

        ///using this Task to Defind Soluation 2
        Task<string> Soluation2();
    }
}
