using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2020.Base.Interface
{
    public interface IHelper<T>
    {
        public List<IEnumerable<T>> GetTheKeysBySpiltSpace(string input);
    }
}
