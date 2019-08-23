using System.Collections.Generic;
using System.Linq;
using Task2.Interface;

namespace Task2.Implementation
{
    public class Sum : ISum
    {
        public int Addition(List<int> values)
        {
            return values.Sum();
        }
    }
}
