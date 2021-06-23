using AdventOfCode2020.Base.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2020.Base.Helper
{
    public class HelperWithString<T> : IHelper<T>
    {
        Dictionary<string, string> keys = new Dictionary<string, string>() { };

        public List<IEnumerable<T>> GetTheKeysBySpiltSpace(string input)
        {
            throw new NotImplementedException();
        }
    }
}
