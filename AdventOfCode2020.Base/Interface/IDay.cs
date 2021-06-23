using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020.Base.Interface
{
    public interface IDay
    {
        public List<int> Datanumber { get; set; }
        public List<string> DataString { get; set; }

        public string Soluation1();
        public string Soluation2();
    }
}
